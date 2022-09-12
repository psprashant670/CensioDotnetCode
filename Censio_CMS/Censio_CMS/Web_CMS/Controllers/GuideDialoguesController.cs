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
    public class GuideDialoguesController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public GuideDialoguesController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGuideDialogues
                         join S in this.DbContext.TblGame on T.IdGame equals S.IdGame

                         where T.IdOrganization == ID_ORGANIZATION
                         select new
                         {


                             S.GameName,
                             T.IdGame,
                             T.IdGuideDialogues,
                             T.GuideDialogue,
                             T.IdOrganization,
                             T.GuideIntroMessage,
                             T.IsActive,
                             T.UpdatedDateTime,
                             T.TypeDialogue,
                             T.TypeDialogueName,
                             T.Sequence,
                           
                         }).Select(X => new GuideDialoguesModel
                         {
                            
                             IdGame = X.IdGame,
                             GameName = X.GameName,
                             IdGuideDialogues = X.IdGuideDialogues,
                             GuideIntroMessage = X.GuideIntroMessage,
                             IdOrganization = X.IdOrganization,
                             TypeDialogue = X.TypeDialogue,
                             IsActive = X.IsActive,
                             UpdatedDateTime = X.UpdatedDateTime,
                             TypeDialogueName = X.TypeDialogueName,
                             Sequence = X.Sequence,
                             GuideDialogue = X.GuideDialogue,
                         }).ToList();

            ViewBag.PageName = "Guide Dialogues List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            GuideDialoguesModel model = new GuideDialoguesModel();

            TblGuideDialogues tblData = new TblGuideDialogues();

            tblData = this.DbContext.TblGuideDialogues.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
               
                model.IdGuideDialogues = tblData.IdGuideDialogues;
                model.IdGame = tblData.IdGame;
                model.GuideDialogue = tblData.GuideDialogue;
                model.GuideIntroMessage = tblData.GuideIntroMessage;
                model.TypeDialogue = tblData.TypeDialogue;
                model.TypeDialogueName = tblData.TypeDialogueName;
                model.Sequence = tblData.Sequence;
                model.IdOrganization = tblData.IdOrganization;
                model.IsActive = tblData.IsActive;
                model.UpdatedDateTime = tblData.UpdatedDateTime;


            }

            ViewBag.modelTitle = "Edit";
            model.GameNameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
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
            GuideDialoguesModel model = new GuideDialoguesModel();

            model.GameNameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGuideDialogues model)
        {
            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");


                if (model.IdGuideDialogues != 0)
                {
                    _unitOfWork.GuideDialogues.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    _unitOfWork.GuideDialogues.Add(model);
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
