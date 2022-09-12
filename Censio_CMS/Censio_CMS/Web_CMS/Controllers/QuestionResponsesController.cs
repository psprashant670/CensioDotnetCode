using Censio_CMS.Models;
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
    public class QuestionResponsesController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        private readonly db_censio_betaContext _DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public QuestionResponsesController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            _DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblQuestionResponses
                             join S in this.DbContext.TblQuestions on T.IdQuestion equals S.IdQuestion
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         select new QuestionResponsesModel
                         {
                             IdResponse = T.IdResponse,
                             IdQuestionText = S.IdQuestionText,
                             QuestionType = T.QuestionType,
                             IdResponseGroup = T.IdResponseGroup,
                             ReponseOptionNo = T.ReponseOptionNo,
                             ResponseOptionName = T.ResponseOptionName,
                             ResponseOptionDescription = T.ResponseOptionDescription,
                             AdditionInformation = T.AdditionInformation,
                             IdResponseImagepath = T.IdResponseImagepath,
                             Status = T.Status,
                             UpdatedDateTime = T.UpdatedDateTime

                         }).ToList();

            ViewBag.PageName = "Question Responses List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            TblQuestions model = new TblQuestions();
            var questionSequence = this.DbContext.TblQuestions.OrderByDescending(o => o.IdQuestionSequence).Select(o => o.IdQuestionSequence).FirstOrDefault();

            model.IdQuestionSequence = questionSequence + 1;
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblQuestions model)
        {

            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdGame = 3;


                if (model.IdQuestion == 0)
                {
                    List<TblQuestions> tbleData = new List<TblQuestions>();
                    tbleData = this.DbContext.TblQuestions.ToList();
                    List<String> errorList = new List<String>();
                    if (tbleData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdQuestionSequence).Any(o => o == model.IdQuestionSequence))
                    {
                        errorList.Add("Question Sequence Already Exists");
                    }

                    if (errorList.Any())
                    {
                        return Json(new { Message = errorList, data = 4 });
                    }


                    _unitOfWork.Questions.Add(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Added", data = 2 });
                }

                List<TblQuestions> tblData = new List<TblQuestions>();
                tblData = _DbContext.TblQuestions.AsNoTracking().ToList();
                List<String> errorLst = new List<String>();
                if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A" && o.IdQuestionSequence == model.IdQuestionSequence).Select(o => o.IdQuestion).All(o => o == model.IdQuestion))
                {
                    _unitOfWork.Questions.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdQuestionSequence).Any(o => o == model.IdQuestionSequence))
                {
                    errorLst.Add("Question Sequence Already Exists");
                }

                if (errorLst.Any())
                {
                    return Json(new { Message = errorLst, data = 4 });
                }

                _unitOfWork.Questions.Update(model);
                _unitOfWork.Complete();
                return Json(new { Message = "Successfully Updated", data = 1 });


            }
            catch (Exception ex)
            {

                return Json(new { Message = "error", data = 3 });
            }

        }

        public ActionResult Edit(int? id)
        {


            TblQuestions tblData = new TblQuestions();

            tblData = this.DbContext.TblQuestions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }



            return View("Create", tblData);

        }
        public ActionResult DeActivate(int? id)
        {


            TblQuestions tblData = new TblQuestions();

            tblData = this.DbContext.TblQuestions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "D";
                _unitOfWork.Questions.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblQuestions tblData = new TblQuestions();

            tblData = this.DbContext.TblQuestions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "A";
                _unitOfWork.Questions.Update(tblData);
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
