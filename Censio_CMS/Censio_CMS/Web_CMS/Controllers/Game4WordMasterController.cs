using Censio_CMS.Models;
using Censio_CMS.Web;
using Censio_CMS.Web.Filter;
using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class Game4WordMasterController : Controller
    {

        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game4WordMasterController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame4WordMaster
                             join S in this.DbContext.TblGame4LevelMaster on T.IdLevelMaster equals S.IdLevel
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdGame == 4
                         select new Game4WordMaster
                         {
                             IdLevelWord = T.IdLevelWord,
                             IdGame = T.IdGame,
                             IdLevelMaster = T.IdLevelMaster,
                             LevelName = S.LevelName,
                             IdWordNo = T.IdWordNo,
                             IdWordDetail = T.IdWordDetail,
                             IdWordStatus = T.IdWordStatus,
                           UpdateDatetime = T.UpdateDatetime

                         }).ToList();

            ViewBag.PageName = "Game4 Word Master List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            Game4WordMaster model = new Game4WordMaster();

            model.LevelList = DbContext.TblGame4LevelMaster.ToList().Where(x => x.IdGame == 4 && x.IdLevelStatus == "A").ToList().Select(X => new SelectListItem
            {
                Text = X.LevelName,
                Value = X.IdLevel.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame4WordMaster model)
        {

            try
            {


                model.UpdateDatetime = DateTime.UtcNow;
                model.IdGame = 4;


                if (model.IdLevelWord != 0)
                {
                    List<TblGame4WordMaster> tblData = new List<TblGame4WordMaster>();
                    tblData = this.DbContext.TblGame4WordMaster.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevelMaster == model.IdLevelMaster && o.IdWordStatus == "A" && o.IdWordNo == model.IdWordNo && o.IdWordDetail == model.IdWordDetail).Select(o => o.IdLevelWord).All(o => o == model.IdLevelWord))
                    {
                        _unitOfWork.Game4WordMaster.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevelMaster == model.IdLevelMaster && o.IdWordStatus == "A").Select(o => o.IdWordNo).Any(o => o == model.IdWordNo))
                    {
                        errorLst.Add("Word No. Already Exists for this Level.");
                    }
                    if (tblData.Where(o => o.IdGame == 4 && o.IdWordStatus == "A").Select(o => o.IdWordDetail).Any(o => o == model.IdWordDetail))
                    {
                        errorLst.Add("Word Detail Already Exists.");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4WordMaster.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame4WordMaster> tblData = new List<TblGame4WordMaster>();
                    tblData = this.DbContext.TblGame4WordMaster.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevelMaster == model.IdLevelMaster && o.IdWordStatus == "A").Select(o => o.IdWordNo).Any(o => o == model.IdWordNo))
                    {
                        errorLst.Add("Word No. Already Exists for this Level.");
                    }
                    if (tblData.Where(o => o.IdGame == 4 && o.IdWordStatus == "A").Select(o => o.IdWordDetail).Any(o => o == model.IdWordDetail))
                    {
                        errorLst.Add("Word Detail Already Exists.");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4WordMaster.Add(model);
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


            TblGame4WordMaster tblData = new TblGame4WordMaster();

            Game4WordMaster model = new Game4WordMaster();

            tblData = this.DbContext.TblGame4WordMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else {
                model.IdLevelWord = tblData.IdLevelWord;
                model.IdGame = tblData.IdGame;
                model.IdLevelMaster = tblData.IdLevelMaster;
                //model.LevelName = tblData.LevelName;
                model.IdWordNo = tblData.IdWordNo;
                model.IdWordDetail = tblData.IdWordDetail;
                model.IdWordStatus = tblData.IdWordStatus;
                model.UpdateDatetime = tblData.UpdateDatetime;

            }

            model.LevelList = DbContext.TblGame4LevelMaster.Where(x => x.IdGame == 4).ToList().Select(X => new SelectListItem
            {
                Text = X.LevelName,
                Value = X.IdLevel.ToString()
            });

            ViewBag.modelTitle = "Edit";



            return View("Create", model);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame4WordMaster tblData = new TblGame4WordMaster();

            tblData = this.DbContext.TblGame4WordMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.IdWordStatus = "D";
                _unitOfWork.Game4WordMaster.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame4WordMaster tblData = new TblGame4WordMaster();

            tblData = this.DbContext.TblGame4WordMaster.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.IdWordStatus = "A";
                _unitOfWork.Game4WordMaster.Update(tblData);
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
