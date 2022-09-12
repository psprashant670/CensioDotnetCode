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
    public class SubliminalMeasurement2Controller : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public SubliminalMeasurement2Controller(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblSubliminalMeasurement2
                         join U in this.DbContext.TblGame on T.IdGame equals U.IdGame
                         join V in this.DbContext.TblBehaviorElement on T.IdBehavior equals V.IdBehavior
                         join S in this.DbContext.TblGameChallengelevel on T.IdLevel equals S.IdLevel
                         where T.IdOrganization == ID_ORGANIZATION
                         select new
                         {

                             V.BehaviorElement,
                             U.GameName,
                             T.IdSubliminalMeasurement2,
                             T.BehaviorScore,
                             T.SubliminalMeasurement2Name,
                             T.IdOrganization,
                             T.Status,
                             T.IdBehavior,
                             T.IdGame,
                             T.UpdatedDateTime,
                             T.GameFeedbackMsg,
                             S.ChallengeName,
                             T.IdLevel
                         }).Select(X => new SubliminalMeasurement2Model
                         {
                             BehaviorElement = X.BehaviorElement,
                             GameName = X.GameName,
                             IdSubliminalMeasurement2 = X.IdSubliminalMeasurement2,
                             BehaviorScore = X.BehaviorScore,
                             SubliminalMeasurement2Name = X.SubliminalMeasurement2Name,
                             IdGame = X.IdGame,
                             IdOrganization = X.IdOrganization,
                             Status = X.Status,
                             UpdatedDateTime = X.UpdatedDateTime,
                             GameFeedbackMsg=X.GameFeedbackMsg,
                             ChallengeName = X.ChallengeName,
                             IdLevel = (int)X.IdLevel


                         }).ToList();

            ViewBag.PageName = "Measurement2 List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            SubliminalMeasurement2Model model = new SubliminalMeasurement2Model();

            TblSubliminalMeasurement2 tblData = new TblSubliminalMeasurement2();

            tblData = this.DbContext.TblSubliminalMeasurement2.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdSubliminalMeasurement2 = tblData.IdSubliminalMeasurement2;
                model.IdGame = tblData.IdGame;
                model.IdBehavior = tblData.IdBehavior;
                model.IdGame = tblData.IdGame;
                model.SubliminalMeasurement2Name = tblData.SubliminalMeasurement2Name;
                model.IdBehavior = tblData.IdBehavior;
                model.BehaviorScore = tblData.BehaviorScore;
                model.IdOrganization = tblData.IdOrganization;
                model.Status = tblData.Status;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
                model.GameFeedbackMsg = tblData.GameFeedbackMsg;
                model.IdLevel = (int)tblData.IdLevel;
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

            model.ChallengeNameList = DbContext.TblGameChallengelevel.ToList().Where(x => x.IdOrganization == ID_ORGANIZATION && x.IsActive == "A").Select(X => new SelectListItem
            {
                Text = X.ChallengeName,
                Value = X.IdLevel.ToString()
            });
            return View("Create", model);

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            SubliminalMeasurement2Model model = new SubliminalMeasurement2Model();

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

            model.ChallengeNameList = DbContext.TblGameChallengelevel.ToList().Where(x => x.IdOrganization == ID_ORGANIZATION && x.IsActive == "A").Select(X => new SelectListItem
            {
                Text = X.ChallengeName,
                Value = X.IdLevel.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }
        public ActionResult FillChallenge(int idGame)
        {
            var Challenges = this.DbContext.TblGameChallengelevel.Where(c => c.IdGame == idGame).ToList();
            return Json(Challenges);
        }
        [HttpPost]
        public ActionResult AddEdit(TblSubliminalMeasurement2 model)
        {
            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");


                if (model.IdSubliminalMeasurement2 != 0)
                {
                    _unitOfWork.SubliminalMeasurement2.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    _unitOfWork.SubliminalMeasurement2.Add(model);
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
