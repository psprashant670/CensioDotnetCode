using Censio_CMS.Models;
using Censio_CMS.Web;
using Censio_CMS.Web.Filter;
using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class Game3FestivalsController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game3FestivalsController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame3Festivals
                             //join S in this.DbContext.TblGame3FestivalReset on T.IdFestivalLog equals S.IdFestivalResetLog
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdOrganization == ID_ORGANIZATION && T.IdGame == 3
                         select new TblGame3Festivals
                         {
                             IdFestivalLog = T.IdFestivalLog,
                             IdFestival = T.IdFestival,
                             IdOrganization = T.IdOrganization,
                             IdGame = T.IdGame,
                             GameName = T.GameName,
                             FestivalSequence = T.FestivalSequence,
                             FestivalName = T.FestivalName,
                             FestivalImagepath = T.FestivalImagepath,
                             RawMaterial = T.RawMaterial,
                             RawMaterialExactqty = T.RawMaterialExactqty,
                             RawMaterialMinQtyPast = T.RawMaterialMinQtyPast,
                             RawMaterialMinQtyFuture = T.RawMaterialMinQtyFuture,
                             ScoreAbsoluteCalculated = T.ScoreAbsoluteCalculated,
                             PrimaryMaterialScore = T.PrimaryMaterialScore,
                             SecondaryMaterialScorePositive = T.SecondaryMaterialScorePositive,
                             SecondaryMaterialScoreNegative = T.SecondaryMaterialScoreNegative,
                             RawMaterialImagepath = T.RawMaterialImagepath,
                             MessageMaxQtySuccess = T.MessageMaxQtySuccess,
                             MessageMaxQtyFail = T.MessageMaxQtyFail,
                             MessageMinQtySuccess = T.MessageMinQtySuccess,
                             MessageMinQtyFail = T.MessageMinQtyFail,
                             MessageFestivalFail = T.MessageFestivalFail,
                             MessageFestivalSuccess = T.MessageFestivalSuccess,
                             TimeRequiredSeconds = T.TimeRequiredSeconds,
                             Status = T.Status,
                             CreatedBy = T.CreatedBy,
                             UpdatedBy = T.UpdatedBy,
                             UpdatedDateTime = T.UpdatedDateTime

                         }).ToList();

            ViewBag.PageName = "Game3 Festivals List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
           TblGame3Festivals model = new TblGame3Festivals();
            var idFestival = this.DbContext.TblGame3Festivals.OrderByDescending(o => o.IdFestival).Select(o => o.IdFestival).FirstOrDefault();
            var festivalSequence = this.DbContext.TblGame3Festivals.OrderByDescending(o => o.FestivalSequence).Select(o => o.FestivalSequence).FirstOrDefault();
            
            model.IdFestival = idFestival + 1;
            model.FestivalSequence = festivalSequence + 1;
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame3Festivals model)
        {

            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdGame = 3;
                model.GameName = "The Restauranteur";
                
                if (model.IdFestivalLog != 0)
                {
                    List<TblGame3Festivals> tblData = new List<TblGame3Festivals>();
                    tblData = this.DbContext.TblGame3Festivals.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A" && o.FestivalSequence == model.FestivalSequence && o.FestivalName == model.FestivalName && o.RawMaterial == model.RawMaterial).Select(o => o.IdFestivalLog).All(o => o == model.IdFestivalLog))
                    {
                        model.UpdatedBy = HttpContext.Session.GetInt32("userid");
                        _unitOfWork.Game3Festvals.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdFestival).Any(o => o == model.IdFestival))
                    {
                        errorLst.Add("Festival Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalSequence).Any(o => o == model.FestivalSequence))
                    {
                        errorLst.Add("Festival Sequence Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.RawMaterial).Any(o => o == model.RawMaterial))
                    {
                        errorLst.Add("Raw Material Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    model.UpdatedBy = HttpContext.Session.GetInt32("userid");
                    _unitOfWork.Game3Festvals.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame3Festivals> tblData = new List<TblGame3Festivals>();
                    tblData = this.DbContext.TblGame3Festivals.ToList();
                    List<String> errorLst = new List<String>();
                    //if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdFestival).Any(o => o == model.IdFestival))
                    //{
                    //    errorLst.Add("Festival Id Already Exists");
                    //}----------------------------
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalSequence).Any(o => o == model.FestivalSequence))
                    {
                        errorLst.Add("Festival Sequence Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.RawMaterial).Any(o => o == model.RawMaterial))
                    {
                        errorLst.Add("Raw Material Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    model.CreatedBy = HttpContext.Session.GetInt32("userid");
                    _unitOfWork.Game3Festvals.Add(model);
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


            TblGame3Festivals tblData = new TblGame3Festivals();

            tblData = this.DbContext.TblGame3Festivals.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }



            return View("Create", tblData);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame3Festivals tblData = new TblGame3Festivals();

            tblData = this.DbContext.TblGame3Festivals.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "D";
                tblData.UpdatedBy = HttpContext.Session.GetInt32("userid");
                _unitOfWork.Game3Festvals.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame3Festivals tblData = new TblGame3Festivals();

            tblData = this.DbContext.TblGame3Festivals.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "A";
                tblData.UpdatedBy = HttpContext.Session.GetInt32("userid");
                _unitOfWork.Game3Festvals.Update(tblData);
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
