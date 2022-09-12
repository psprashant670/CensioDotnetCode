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
    public class GameAttemptdataController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public GameAttemptdataController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGameAttemptdata
                         join S in this.DbContext.TblGameChallengelevel on T.IdLevel equals S.IdLevel
                         join U in this.DbContext.TblGame on T.IdGame equals U.IdGame
                         join V in this.DbContext.TblBehaviorElement on T.IdBehavior equals V.IdBehavior
                         where T.IdOrganization == ID_ORGANIZATION 
                         select new
                         {
                             V.BehaviorElement,
                             U.GameName,
                             S.ChallengeName,
                             T.IdAttempt,
                             T.IdLevel,
                             T.AttemptNo,
                             T.IdGame,
                             T.GoldCoins,
                             T.IdBehavior,
                             T.BehaviorScore,
                             T.TimeInSecond,
                             T.ChallengeCompletedTime1,
                             T.RewardCoinsTime1,
                             T.ChallengeCompletedTime2,
                             T.RewardCoinsTime2,
                             T.FailAttemptMessage,
                             T.SuccessAttemptMessage,
                             T.IdOrganization,
                             T.IsActive,
                             T.UpdatedDateTime,
                           
                         }).Select(X => new GameAttemptdataModel
                         {
                             BehaviorElement = X.BehaviorElement,
                             GameName = X.GameName,
                             ChallengeName = X.ChallengeName,
                             IdAttempt = X.IdAttempt,
                             IdLevel = X.IdLevel,
                             AttemptNo = X.AttemptNo,
                             IdGame = X.IdGame,
                             GoldCoins = X.GoldCoins,
                             IdBehavior = X.IdBehavior,
                             BehaviorScore = X.BehaviorScore,
                             TimeInSecond = X.TimeInSecond,
                             ChallengeCompletedTime1 = X.ChallengeCompletedTime1,
                             RewardCoinsTime1 = X.RewardCoinsTime1,
                             ChallengeCompletedTime2 = X.ChallengeCompletedTime2,
                             RewardCoinsTime2 = X.RewardCoinsTime2,
                             FailAttemptMessage = X.FailAttemptMessage,
                             SuccessAttemptMessage = X.SuccessAttemptMessage,
                             IdOrganization = X.IdOrganization,
                             IsActive = X.IsActive,
                             UpdatedDateTime = X.UpdatedDateTime,

                         }).ToList();

            ViewBag.PageName = "Game Attemptdata List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            GameAttemptdataModel model = new GameAttemptdataModel();

            TblGameAttemptdata tblData = new TblGameAttemptdata();

            tblData = this.DbContext.TblGameAttemptdata.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdAttempt = tblData.IdAttempt;
                model.IdLevel = tblData.IdLevel;
                model.AttemptNo = tblData.AttemptNo;
                model.IdGame = tblData.IdGame;
                model.GoldCoins = tblData.GoldCoins;
                model.IdBehavior = tblData.IdBehavior;
                model.BehaviorScore = tblData.BehaviorScore;
                model.TimeInSecond = tblData.TimeInSecond;
                model.ChallengeCompletedTime1 = tblData.ChallengeCompletedTime1;
                model.RewardCoinsTime1 = tblData.RewardCoinsTime1;
                model.ChallengeCompletedTime2 = tblData.ChallengeCompletedTime2;
                model.RewardCoinsTime2 = tblData.RewardCoinsTime2;
                model.FailAttemptMessage = tblData.FailAttemptMessage;
                model.SuccessAttemptMessage = tblData.SuccessAttemptMessage;
                model.IdOrganization = tblData.IdOrganization;
                model.IsActive = tblData.IsActive;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
               
            }

           

           
            ViewBag.modelTitle = "Edit"; 
            model.BehaviorElementNameList = DbContext.TblBehaviorElement.ToList().Where(x=>x.IdOrganization== ID_ORGANIZATION && x.Status=="A").Select(X => new SelectListItem
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
            GameAttemptdataModel model = new GameAttemptdataModel();
           
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
        public ActionResult AddEdit(TblGameAttemptdata model)
        {
           
            try
            {
               
                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");
               




                if (model.IdAttempt != 0)
                {
                    _unitOfWork.GameAttemptdata.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    _unitOfWork.GameAttemptdata.Add(model);
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
