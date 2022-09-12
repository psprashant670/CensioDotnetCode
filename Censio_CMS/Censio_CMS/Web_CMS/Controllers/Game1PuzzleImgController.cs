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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class Game1PuzzleImgController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public Game1PuzzleImgController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblPuzzleGame
                         join S in this.DbContext.TblGameChallengelevel on T.IdLevel equals S.IdLevel

                         where T.IdOrganization == ID_ORGANIZATION
                         select new
                         {

                             S.ChallengeName,
                             T.IdPuzzle,
                             T.IdLevel,
                             T.RowColumn,
                             T.Images,
                             T.IdOrganization,
                             T.AnswerSequence,
                             T.IsActive,
                             T.UpdatedDateTime,
                             T.Coins,
                            
                         }).Select(X => new PuzzleGameModel
                         {
                             IdLevel = X.IdLevel,
                             IdPuzzle = X.IdPuzzle,
                             RowColumn = X.RowColumn,
                             ChallengeName = X.ChallengeName,
                             Images = X.Images,
                             IdOrganization = X.IdOrganization,
                             AnswerSequence = X.AnswerSequence,
                             IsActive = X.IsActive,
                             UpdatedDateTime = X.UpdatedDateTime,
                             Coins = X.Coins,
                             
                         }).ToList();

            ViewBag.PageName = "Game PuzzleImage List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            PuzzleGameModel model = new PuzzleGameModel();

            TblPuzzleGame tblData = new TblPuzzleGame();

            tblData = this.DbContext.TblPuzzleGame.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdLevel = tblData.IdLevel;
                model.IdPuzzle = tblData.IdPuzzle;
                model.RowColumn = tblData.RowColumn;
                model.Images = tblData.Images;
                model.AnswerSequence = tblData.AnswerSequence;
                model.Coins = tblData.Coins;
                model.IdOrganization = tblData.IdOrganization;
                model.IsActive = tblData.IsActive;
                model.UpdatedDateTime = tblData.UpdatedDateTime;

            }

            ViewBag.modelTitle = "Edit";
            model.ChallengeNameList = DbContext.TblGameChallengelevel.ToList().Select(X => new SelectListItem
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
            PuzzleGameModel model = new PuzzleGameModel();

            model.ChallengeNameList = DbContext.TblGameChallengelevel.ToList().Select(X => new SelectListItem
            {
                Text = X.ChallengeName,
                Value = X.IdLevel.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddEditAsync(TblPuzzleGame model)
        {
            model.IdOrganization = (int)ID_ORGANIZATION;
            model.UpdatedDateTime = DateTime.UtcNow;
            model.IdCmsUser = HttpContext.Session.GetInt32("userid");
            try
            {


                var files = HttpContext.Request.Form.Files;
                if (model.IdPuzzle != 0)
                {
                    TblPuzzleGame objData = (from c in this.DbContext.TblPuzzleGame
                                             where c.IdPuzzle == model.IdPuzzle
                                                     select c).FirstOrDefault();
                    if (objData != null)
                    {
                        for (int i = 0; i < files.Count; ++i)
                        {
                            if (files[i].Name == "Imagesfile")
                            {
                                var file = files[i];
                                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg" };
                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GamePuzzleImg");
                                if (files[i].Length > 0)
                                {
                                    var ext = Path.GetExtension(files[i].FileName);
                                    if (allowedExtensions.Contains(ext))
                                    {
                                        var fileName = model.IdOrganization + "_"+Path.GetFileName(files[i].FileName) ;
                                        HttpContext.Session.SetString("BuildingImgFileName", fileName);

                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.Images = "UploadeImage/GamePuzzleImg/"+ fileName;
                                        }
                                    }
                                    else
                                    {
                                        return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                    }

                                }

                            }
                            
                        }

                        objData.IdLevel = model.IdLevel;
                        objData.RowColumn = model.RowColumn;
                        objData.Images = model.Images;
                        objData.AnswerSequence = model.AnswerSequence;
                        objData.Coins = model.Coins;
                        objData.UpdatedDateTime = DateTime.UtcNow;
                        objData.IsActive = model.IsActive;
                        objData.IdOrganization = model.IdOrganization;
                        objData.IdCmsUser = model.IdCmsUser;
                        _unitOfWork.Complete();

                    }
                    return Json(new { Message = "Successfully Updated", data = 1 });

                }
                else
                {

                    _unitOfWork.Game1PuzzleImg.Add(model);
                    _unitOfWork.Complete();
                    for (int i = 0; i < files.Count; ++i)
                    {
                        if (files[i].Name == "Imagesfile")
                        {
                            var file = files[i];
                            var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg", ".mp3", ".ogg", ".wav", ".mp4", ".mov", ".wmv" };
                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GamePuzzleImg");
                            if (files[i].Length > 0)
                            {
                                var ext = Path.GetExtension(files[i].FileName);
                                if (allowedExtensions.Contains(ext))
                                {
                                    var fileName = model.IdOrganization + "_"+ Path.GetFileName(files[i].FileName);
                                    HttpContext.Session.SetString("BuildingImg_FileName", fileName);

                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.Images = "UploadeImage/GamePuzzleImg/"+ fileName;
                                    }
                                }
                                else
                                {
                                    return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                }
                            }

                        }
                       
                    }
                    TblPuzzleGame objData = (from c in this.DbContext.TblPuzzleGame
                                             where c.IdPuzzle == model.IdPuzzle
                                                     select c).FirstOrDefault();
                    if (objData != null)
                    {
                        objData.Images = model.Images;
                       
                        _unitOfWork.Complete();

                    }
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
