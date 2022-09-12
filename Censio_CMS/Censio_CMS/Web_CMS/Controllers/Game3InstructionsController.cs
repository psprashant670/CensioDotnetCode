using Censio_CMS.Models;
using Censio_CMS.Web;
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
    public class Game3InstructionsController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game3InstructionsController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame3Instructions
                             //join S in this.DbContext.TblGame3FestivalReset on T.IdFestivalLog equals S.IdFestivalResetLog
                             //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdOrganization == ID_ORGANIZATION && T.IdGame == 3
                         select new TblGame3Instructions
                         {
                             IdGameInstructionLog = T.IdGameInstructionLog,
                             IdInstruction = T.IdInstruction,
                             IdGame = T.IdGame,
                             IdOrganization = T.IdOrganization,
                             FestivalName = T.FestivalName,
                             InstructionPostion = T.InstructionPostion,
                             InstructionSequence = T.InstructionSequence,
                             InstructionText = T.InstructionText,
                             InstructionImagepath = T.InstructionImagepath,
                             Status = T.Status,
                             UpdatedDateTime = T.UpdatedDateTime

                         }).ToList();

            ViewBag.PageName = "Game3 Instructions List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            Game3InstructionsModel model = new Game3InstructionsModel();
            var idInstruction = this.DbContext.TblGame3Instructions.OrderByDescending(o => o.IdInstruction).Select(o => o.IdInstruction).FirstOrDefault();
            model.IdInstruction = idInstruction + 1;
            var instructionSequence = this.DbContext.TblGame3Instructions.OrderByDescending(o => o.InstructionSequence).Select(o => o.InstructionSequence).FirstOrDefault();
            model.IdInstruction = idInstruction + 1;
            model.InstructionSequence = instructionSequence + 1;
            model.FestivalList = DbContext.TblGame3Festivals.Where(x => x.IdGame == 3 && x.Status == "A").Select(X => new SelectListItem
            {
                Text = X.FestivalName,
                Value = X.IdFestival.ToString()
            }).ToList();

            var startItem = new SelectListItem { Text = "Start", Value = "Start" };
            var endItem = new SelectListItem { Text = "End", Value = "End" };
            List<SelectListItem> staticLst = null;
            staticLst = model.FestivalList.ToList();
            staticLst.Add(startItem);
            staticLst.Add(endItem);
            model.FestivalList = staticLst;
           



            ViewBag.modelTitle = "Add";
            
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame3Instructions model)
        {

            try
            {

                model.IdOrganization = (int)ID_ORGANIZATION;
                model.UpdatedDateTime = DateTime.UtcNow;
                model.IdGame = 3;
                int id = model.IdGameInstructionLog;
                
                if (model.IdGameInstructionLog != 0)
                {
                    List<TblGame3Instructions> tblData = new List<TblGame3Instructions>();
                    tblData = this.DbContext.TblGame3Instructions.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A" && o.IdInstruction == model.IdInstruction && o.FestivalName == model.FestivalName  && o.InstructionSequence == model.InstructionSequence).Select(o => o.IdGameInstructionLog).All(o => o == model.IdGameInstructionLog))
                    {
                        _unitOfWork.Game3Instructions.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.IdInstruction).Any(o => o == model.IdInstruction))
                    {
                        errorLst.Add("Instruction Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists");
                    }
                    //if (tblData.Where(o => o.IdOrganization == 1 && o.IdGame == 3).Select(o => o.InstructionPostion).Any(o => o == model.InstructionPostion))
                    //{
                    //    errorLst.Add("Instruction Postion Already Exists");
                    //}
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.InstructionSequence).Any(o => o == model.InstructionSequence))
                    {
                        errorLst.Add("Instruction Sequence Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game3Instructions.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame3Instructions> tblData = new List<TblGame3Instructions>();
                    tblData = this.DbContext.TblGame3Instructions.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status=="A").Select(o => o.IdInstruction).Any(o => o == model.IdInstruction))
                    {
                        errorLst.Add("Instruction Id Already Exists");
                    }
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.FestivalName).Any(o => o == model.FestivalName))
                    {
                        errorLst.Add("Festival Name Already Exists");
                    }
                    //if (tblData.Where(o => o.IdOrganization == 1 && o.IdGame == 3).Select(o => o.InstructionPostion).Any(o => o == model.InstructionPostion))
                    //{
                    //    errorLst.Add("Instruction Postion Already Exists");
                    //}
                    if (tblData.Where(o => o.IdOrganization == model.IdOrganization && o.IdGame == 3 && o.Status == "A").Select(o => o.InstructionSequence).Any(o => o == model.InstructionSequence))
                    {
                        errorLst.Add("Instruction Sequence Already Exists");
                    }
                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }
                    _unitOfWork.Game3Instructions.Add(model);
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


            TblGame3Instructions tblData = new TblGame3Instructions();
            Game3InstructionsModel model = new Game3InstructionsModel();

            tblData = this.DbContext.TblGame3Instructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdGameInstructionLog = tblData.IdGameInstructionLog;
                model.IdInstruction = tblData.IdInstruction;
                model.IdGame = tblData.IdGame;
                model.IdOrganization = tblData.IdOrganization;
                model.FestivalName = tblData.FestivalName;
                model.InstructionPostion = tblData.InstructionPostion;
                model.InstructionSequence = tblData.InstructionSequence;
                model.InstructionText = tblData.InstructionText;
                model.InstructionImagepath = tblData.InstructionImagepath;
                model.Status = tblData.Status;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
            }
            model.FestivalList = DbContext.TblGame3Festivals.Where(x => x.IdGame == 3 && x.Status == "A").Select(X => new SelectListItem
            {
                Text = X.FestivalName,
                Value = X.IdFestival.ToString()
            }).ToList();

            var startItem = new SelectListItem { Text = "Start", Value = "Start" };
            var endItem = new SelectListItem { Text = "End", Value = "End" };
            List<SelectListItem> staticLst = null;
            staticLst = model.FestivalList.ToList();
            staticLst.Add(startItem);
            staticLst.Add(endItem);
            model.FestivalList = staticLst;



            return View("Create", model);

        }
        public ActionResult DeActivate(int? id)
        {


            TblGame3Instructions tblData = new TblGame3Instructions();

            tblData = this.DbContext.TblGame3Instructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "D";
                _unitOfWork.Game3Instructions.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame3Instructions tblData = new TblGame3Instructions();

            tblData = this.DbContext.TblGame3Instructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.Status = "A";
                tblData.UpdatedDateTime = DateTime.UtcNow;
                _unitOfWork.Game3Instructions.Update(tblData);
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


