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
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class SubliminalMeasurement1Controller : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public SubliminalMeasurement1Controller(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblSubliminalMeasurement1
                         join U in this.DbContext.TblGame on T.IdGame equals U.IdGame
                         join V in this.DbContext.TblBehaviorElement on T.IdBehavior equals V.IdBehavior
                         where T.IdOrganization == ID_ORGANIZATION
                         select new
                         {

                             V.BehaviorElement,
                             U.GameName,
                             T.IdSubliminalMeasurement1,
                             T.BehaviorScore,
                             T.SubliminalMeasurementName,
                             T.IdOrganization,
                             T.Status,
                             T.IdBehavior,
                             T.IdGame,
                             T.UpdatedDateTime,

                         }).Select(X => new SubliminalMeasurement1Model
                         {
                             BehaviorElement = X.BehaviorElement,
                             GameName = X.GameName,
                             IdSubliminalMeasurement1 = X.IdSubliminalMeasurement1,
                             BehaviorScore = X.BehaviorScore,
                             SubliminalMeasurementName = X.SubliminalMeasurementName,
                             IdGame = X.IdGame,
                             IdOrganization = X.IdOrganization,
                             Status = X.Status,
                             UpdatedDateTime = X.UpdatedDateTime,



                         }).ToList();

            ViewBag.PageName = "Measurement1 List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            SubliminalMeasurement1Model model = new SubliminalMeasurement1Model();

            TblSubliminalMeasurement1 tblData = new TblSubliminalMeasurement1();

            tblData = this.DbContext.TblSubliminalMeasurement1.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdSubliminalMeasurement1 = tblData.IdSubliminalMeasurement1;
                model.IdGame = tblData.IdGame;
                model.IdBehavior = tblData.IdBehavior;
                model.IdGame = tblData.IdGame;
                model.SubliminalMeasurementName = tblData.SubliminalMeasurementName;
                model.IdBehavior = tblData.IdBehavior;
                model.BehaviorScore = tblData.BehaviorScore;
                model.IdOrganization = tblData.IdOrganization;
                model.Status = tblData.Status;
                model.UpdatedDateTime = tblData.UpdatedDateTime;


            }

            ViewBag.modelTitle = "Edit";
            model.BehaviorElementNameList = DbContext.TblBehaviorElement.ToList().Where(x => x.IdOrganization == ID_ORGANIZATION && x.Status == "A").Select(X => new SelectListItem
            {
                Text = X.BehaviorElement,
                Value = X.IdBehavior.ToString()
            });

            model.GameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });

           
            return View("Create", model);

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            SubliminalMeasurement1Model model = new SubliminalMeasurement1Model();

            model.BehaviorElementNameList = DbContext.TblBehaviorElement.ToList().Where(x => x.IdOrganization == ID_ORGANIZATION && x.Status == "A").Select(X => new SelectListItem
            {
                Text = X.BehaviorElement,
                Value = X.IdBehavior.ToString()
            });

            model.GameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });

           
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblSubliminalMeasurement1 model)
        {
            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");


                if (model.IdSubliminalMeasurement1 != 0)
                {
                    _unitOfWork.SubliminalMeasurement1.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    _unitOfWork.SubliminalMeasurement1.Add(model);
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
