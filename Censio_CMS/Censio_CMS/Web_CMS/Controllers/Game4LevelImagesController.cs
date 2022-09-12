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
    public class Game4LevelImagesController : Controller
    {


        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game4LevelImagesController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGame4LevelImages
                         join S in this.DbContext.TblGame4LevelMaster on T.IdLevel equals S.IdLevel
                         //join U in this.DbContext.TblGame on T.IdGame equals U.IdGame

                         where T.IdGame == 4
                         select new Game4LevelImages
                         {
                             IdLevelImage = T.IdLevelImage,
                             IdGame = T.IdGame,
                             IdLevel = T.IdLevel,
                             LevelName = S.LevelName,
                             IdImage = T.IdImage
                         }).ToList();

            ViewBag.PageName = "Game4 Level Images List";


            return View("Index", model);

        }

        public ActionResult Create()
        {
            Game4LevelImages model = new Game4LevelImages();

            model.LevelList = DbContext.TblGame4LevelMaster.ToList().Where(x => x.IdGame == 4 && x.IdLevelStatus == "A").ToList().Select(X => new SelectListItem
            {
                Text = X.LevelName,
                Value = X.IdLevel.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(TblGame4LevelImages model)
        {

            try
            {
                model.IdGame = 4;
                if (model.IdLevelImage != 0)
                {
                    List<TblGame4LevelImages> tblData = new List<TblGame4LevelImages>();
                    tblData = this.DbContext.TblGame4LevelImages.AsNoTracking().ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel).Select(o => o.IdLevelImage).Any(o => o == model.IdLevelImage))
                    {
                        _unitOfWork.Game4LevelImages.Update(model);
                        _unitOfWork.Complete();
                        return Json(new { Message = "Successfully Updated", data = 1 });
                    }
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel).Select(o => o.IdLevel).Any(o => o == model.IdLevel))
                    {
                        errorLst.Add("Image URL Already Exists for this Level.");
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelImages.Update(model);
                    _unitOfWork.Complete();
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    List<TblGame4LevelImages> tblData = new List<TblGame4LevelImages>();
                    tblData = this.DbContext.TblGame4LevelImages.ToList();
                    List<String> errorLst = new List<String>();
                    if (tblData.Where(o => o.IdGame == 4 && o.IdLevel == model.IdLevel).Select(o => o.IdLevel).Any(o => o == model.IdLevel))
                    {
                        errorLst.Add("Image URL Already Exists for this Level.");
                    }

                    if (errorLst.Any())
                    {
                        return Json(new { Message = errorLst, data = 4 });
                    }

                    _unitOfWork.Game4LevelImages.Add(model);
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


            TblGame4LevelImages tblData = new TblGame4LevelImages();

            Game4LevelImages model = new Game4LevelImages();

            tblData = this.DbContext.TblGame4LevelImages.Find(id);

            if (tblData == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdLevelImage = tblData.IdLevelImage;
                model.IdGame = tblData.IdGame;
                model.IdLevel = tblData.IdLevel;
                //model.LevelName = tblData.LevelName;
                model.IdImage = tblData.IdImage;

            }

            model.LevelList = DbContext.TblGame4LevelMaster.Where(x => x.IdGame == 4).ToList().Select(X => new SelectListItem
            {
                Text = X.LevelName,
                Value = X.IdLevel.ToString()
            });

            ViewBag.modelTitle = "Edit";



            return View("Create", model);

        }


        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
