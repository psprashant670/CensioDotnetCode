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
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class Game3LevelsController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game3LevelsController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame3Levels
                             //join S in this.DbContext.TblGame3FestivalReset on T.IdFestivalLog equals S.IdFestivalResetLog
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdOrganization == ID_ORGANIZATION && T.IdGame == 3
                         select new TblGame3Levels
                         {
                             IdLevelLog = T.IdLevelLog,
                             IdLevel = T.IdLevel,
                             IdOrganization = T.IdOrganization,
                             IdGame = T.IdGame,
                             GameName = T.GameName,
                             LevelName = T.LevelName,
                             LevelSequence = T.LevelSequence,
                             LevelClearenceAmount = T.LevelClearenceAmount,
                             LevelClearenceCurrency = T.LevelClearenceCurrency,
                             LevelImagepath = T.LevelImagepath,
                             MessageLevelSuccess = T.MessageLevelSuccess,
                             Status = T.Status,
                             CreatedBy = T.CreatedBy,
                             UpdatedBy = T.UpdatedBy,
                             UpdatedDateTime = T.UpdatedDateTime

                         }).ToList();

            ViewBag.PageName = "Game3 Levels List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            TblGame3Levels model = new TblGame3Levels();
            var idLevel = this.DbContext.TblGame3Levels.OrderByDescending(o => o.IdLevel).Select(o => o.IdLevel).FirstOrDefault();
            var levelSequence = this.DbContext.TblGame3Levels.OrderByDescending(o => o.LevelSequence).Select(o => o.LevelSequence).FirstOrDefault();

            model.IdLevel = idLevel + 1;
            model.LevelSequence = levelSequence + 1;
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        public ActionResult Edit(int? id)
        {


            TblGame3Levels tblData = new TblGame3Levels();

            tblData = this.DbContext.TblGame3Levels.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }



            return View("Create", tblData);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame3Levels tblData = new TblGame3Levels();

            tblData = this.DbContext.TblGame3Levels.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "D";
                tblData.UpdatedBy = HttpContext.Session.GetInt32("userid");
                _unitOfWork.Game3Levels.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame3Levels tblData = new TblGame3Levels();

            tblData = this.DbContext.TblGame3Levels.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "A";
                tblData.UpdatedBy = HttpContext.Session.GetInt32("userid");
                _unitOfWork.Game3Levels.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame3Levels model)
        {

            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdGame = 3;
                model.GameName = "The Restauranteur";

                if (model.IdLevelLog != 0)
                {
                    List<TblGame3Levels> tblData = new List<TblGame3Levels>();
                    tblData = this.DbContext.TblGame3Levels.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A" && o.IdLevel == model.IdLevel && o.LevelName == model.LevelName && o.LevelSequence == model.LevelSequence).Select(o => o.IdLevelLog).All(o => o == model.IdLevelLog))
                    {
                        model.UpdatedBy = HttpContext.Session.GetInt32("userid");
                        _unitOfWork.Game3Levels.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdLevel).Any(o => o == model.IdLevel))
                    {
                        errorLst.Add("Level Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.LevelName).Any(o => o == model.LevelName))
                    {
                        errorLst.Add("Level Name Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.LevelSequence).Any(o => o == model.LevelSequence))
                    {
                        errorLst.Add("Level Sequence Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    model.UpdatedBy = HttpContext.Session.GetInt32("userid");
                    _unitOfWork.Game3Levels.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame3Levels> tblData = new List<TblGame3Levels>();
                    tblData = this.DbContext.TblGame3Levels.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdLevel).Any(o => o == model.IdLevel))
                    {
                        errorLst.Add("Level Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.LevelName).Any(o => o == model.LevelName))
                    {
                        errorLst.Add("Level Name Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.LevelSequence).Any(o => o == model.LevelSequence))
                    {
                        errorLst.Add("Level Sequence Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    model.CreatedBy = HttpContext.Session.GetInt32("userid");
                    _unitOfWork.Game3Levels.Add(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Added", data = 2 });
                }

            }
            catch (Exception ex)
            {

                return Json(new { Message = "error", data = 3 });
            }

        }
    }

}

