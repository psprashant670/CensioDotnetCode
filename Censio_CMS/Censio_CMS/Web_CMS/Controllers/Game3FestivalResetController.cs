using Censio_CMS.Web;
using Censio_CMS.Web.Filter;
using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class Game3FestivalResetController : Controller
    {
        
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game3FestivalResetController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame3FestivalReset
                             //join S in this.DbContext.TblGame3FestivalReset on T.IdFestivalLog equals S.IdFestivalResetLog
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdGame == 3
                         select new TblGame3FestivalReset
                         {
                             IdFestivalResetLog = T.IdFestivalResetLog,
                             IdGame = T.IdGame,
                             IdFestival = T.IdFestival,
                             FestivalName = T.FestivalName,
                             PastFestivalReset = T.PastFestivalReset,
                             FutureFestivalReset = T.FutureFestivalReset,
                             Status = T.Status,
                             UpdatedDateTime = T.UpdatedDateTime

                         }).ToList();

            ViewBag.PageName = "Game3 Festival Reset List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            TblGame3FestivalReset model = new TblGame3FestivalReset();
            var idFestival = this.DbContext.TblGame3FestivalReset.OrderByDescending(o => o.IdFestival).Select(o => o.IdFestival).FirstOrDefault();
            model.IdFestival = idFestival + 1;

            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame3FestivalReset model)
        {

            try
            {

               
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdGame = 3;
               

                if (model.IdFestivalResetLog != 0)
                {
                    List<TblGame3FestivalReset> tblData = new List<TblGame3FestivalReset>();
                    tblData = this.DbContext.TblGame3FestivalReset.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 3 && o.Status == "A" && o.IdFestival == model.IdFestival && o.FestivalName == model.FestivalName).Select(o => o.IdFestivalResetLog ).Any(o => o == model.IdFestivalResetLog))
                    {
                        _unitOfWork.Game3FestvalReset.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdGame == 3 && o.Status == "A").Select(o => o.IdFestival).Any(o => o == model.IdFestival))
                    {
                        errorLst.Add("Festival Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdFestival == model.IdFestival && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists for Festival Id:" + model.IdFestival);
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game3FestvalReset.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame3FestivalReset> tblData = new List<TblGame3FestivalReset>();
                    tblData = this.DbContext.TblGame3FestivalReset.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 3 && o.Status == "A").Select(o => o.IdFestival).Any(o => o == model.IdFestival))
                    {
                        errorLst.Add("Festival Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdFestival == model.IdFestival && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists for Festival Id:" + model.IdFestival);
                    }
                   
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                   
                    _unitOfWork.Game3FestvalReset.Add(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Added", data = 2 });
                }

            }
            catch (Exception ex)
            {

                return Json(new { Message = "error", data = 3 });
            }

        }

        public ActionResult Edit(int? id)
        {


            TblGame3FestivalReset tblData = new TblGame3FestivalReset();

            tblData = this.DbContext.TblGame3FestivalReset.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }



            return View("Create", tblData);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame3FestivalReset tblData = new TblGame3FestivalReset();

            tblData = this.DbContext.TblGame3FestivalReset.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "D";
               _unitOfWork.Game3FestvalReset.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame3FestivalReset tblData = new TblGame3FestivalReset();

            tblData = this.DbContext.TblGame3FestivalReset.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "A";
               _unitOfWork.Game3FestvalReset.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
