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
    public class Game4LevelMasterController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game4LevelMasterController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame4LevelMaster
                             //join S in this.DbContext.TblGame3FestivalReset on T.IdFestivalLog equals S.IdFestivalResetLog
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdGame == 4
                         select new TblGame4LevelMaster
                         {
                             IdLevel = T.IdLevel,
                             IdGame = T.IdGame,
                             LevelName = T.LevelName,
                             LevelWordcount = T.LevelWordcount,
                             LevelTimerequired = T.LevelTimerequired,
                             LevelBonuspts = T.LevelBonuspts,
                             IdLevelStatus = T.IdLevelStatus,
                            UpdateDatetime = T.UpdateDatetime

                         }).ToList();

            ViewBag.PageName = "Game4 Level Master List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            ViewBag.modelTitle = "Add";
            return View();
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame4LevelMaster model)
        {

            try
            {

              
                model.UpdateDatetime = DateTime.UtcNow;
                model.IdGame = 4;
              

                if (model.IdLevel != 0)
                {
                    List<TblGame4LevelMaster> tblData = new List<TblGame4LevelMaster>();
                    tblData = this.DbContext.TblGame4LevelMaster.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevelStatus == "A" && o.LevelName == model.LevelName).Select(o => o.IdLevel).All(o => o == model.IdLevel))
                    {
                        _unitOfWork.Game4LevelMaster.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevelStatus == "A").Select(o => o.LevelName).Any(o => o == model.LevelName))
                    {
                        errorLst.Add("Level Name Already Exists");
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelMaster.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame4LevelMaster> tblData = new List<TblGame4LevelMaster>();
                    tblData = this.DbContext.TblGame4LevelMaster.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o =>o.IdGame == 4 && o.IdLevelStatus == "A").Select(o => o.LevelName).Any(o => o == model.LevelName))
                    {
                        errorLst.Add("Level Name Already Exists");
                    }
                    
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelMaster.Add(model);
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


            TblGame4LevelMaster tblData = new TblGame4LevelMaster();

            tblData = this.DbContext.TblGame4LevelMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }



            return View("Create", tblData);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame4LevelMaster tblData = new TblGame4LevelMaster();

            tblData = this.DbContext.TblGame4LevelMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.IdLevelStatus = "D";
               _unitOfWork.Game4LevelMaster.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame4LevelMaster tblData = new TblGame4LevelMaster();

            tblData = this.DbContext.TblGame4LevelMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.IdLevelStatus = "A";
               _unitOfWork.Game4LevelMaster.Update(tblData);
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
