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
    public class Game4LevelInstructionsController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game4LevelInstructionsController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame4LevelInstructions
                         join S in this.DbContext.TblGame4LevelMaster on T.IdLevel equals S.IdLevel
                         //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdGame == 4
                         select new Game4InstructionsModel
                         {
                             IdInstruction = T.IdInstruction,
                             IdGame = T.IdGame,
                             LevelName = S.LevelName,
                             IdInstructionNo = T.IdInstructionNo,
                             InstructionDetail = T.InstructionDetail,
                             InstructionStatus = T.InstructionStatus,
                             InstructionImage = T.InstructionImage,
                             UpdateDatetime = T.UpdateDatetime

                         }).ToList();

            ViewBag.PageName = "Game4 Level Instruction List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            Game4InstructionsModel model = new Game4InstructionsModel();

            model.LevelList = DbContext.TblGame4LevelMaster.ToList().Where(x => x.IdGame == 4 && x.IdLevelStatus == "A").ToList().Select(X => new SelectListItem
            {
                Text = X.LevelName,
                Value = X.IdLevel.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame4LevelInstructions model)
        {

            try
            {


                model.UpdateDatetime = DateTime.UtcNow;
                model.IdGame = 4;


                if (model.IdInstruction != 0)
                {
                    List<TblGame4LevelInstructions> tblData = new List<TblGame4LevelInstructions>();
                    tblData = this.DbContext.TblGame4LevelInstructions.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel && o.InstructionStatus == "Y" && o.IdInstructionNo == model.IdInstructionNo).Select(o => o.IdInstruction).All(o => o == model.IdInstruction))
                    {
                        _unitOfWork.Game4LevelInstructions.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }

                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel && o.InstructionStatus == "Y").Select(o => o.IdInstructionNo).Any(o => o == model.IdInstructionNo))
                    {
                        errorLst.Add("Instruction No Already Exists for this Level.");
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelInstructions.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame4LevelInstructions> tblData = new List<TblGame4LevelInstructions>();
                    tblData = this.DbContext.TblGame4LevelInstructions.ToList();
                    List<String> errorLst = new List<String>();

                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel && o.InstructionStatus == "Y").Select(o => o.IdInstructionNo).Any(o => o == model.IdInstructionNo))
                    {
                        errorLst.Add("Instruction No Already Exists for this Level.");
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelInstructions.Add(model);
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


            TblGame4LevelInstructions tblData = new TblGame4LevelInstructions();

            Game4InstructionsModel model = new Game4InstructionsModel();

            tblData = this.DbContext.TblGame4LevelInstructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdInstruction = tblData.IdInstruction;
                model.IdGame = tblData.IdGame;
                model.IdLevel = tblData.IdLevel;
                model.IdInstructionNo = tblData.IdInstructionNo;
                model.InstructionDetail = tblData.InstructionDetail;
                model.InstructionStatus = tblData.InstructionStatus;
                model.InstructionImage = tblData.InstructionImage;
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


            TblGame4LevelInstructions tblData = new TblGame4LevelInstructions();

            tblData = this.DbContext.TblGame4LevelInstructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.InstructionStatus = "N";
                _unitOfWork.Game4LevelInstructions.Update(tblData);
                _unitOfWork.Complete();



            }


            return RedirectToAction("Index");

        }

        public ActionResult Activate(int? id)
        {


            TblGame4LevelInstructions tblData = new TblGame4LevelInstructions();

            tblData = this.DbContext.TblGame4LevelInstructions.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                tblData.InstructionStatus = "Y";
                _unitOfWork.Game4LevelInstructions.Update(tblData);
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

