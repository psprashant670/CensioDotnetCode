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
using System.Net;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class GameController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public GameController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public ActionResult Index()
        {
            var model = this.DbContext.TblGame.ToList();
            ViewBag.PageName = "Game List";
            return View(model);
        }
        public ActionResult Edit(int? id)
        {
            GameModel model = new GameModel();

            TblGame tblData = new TblGame();

            tblData = DbContext.TblGame.Find(id); ;

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.Id = tblData.Id;
                model.IdGame = tblData.IdGame;
                model.GameName = tblData.GameName;
                model.IdOrganization = tblData.IdOrganization;
                model.Status = tblData.Status;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
                model.MapImgUrl = tblData.MapImgUrl;


            }

            model.GameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });


            ViewBag.modelTitle = "Edit";


            return View("Create", model);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            GameModel model = new GameModel();
            model.GameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });

            ViewBag.modelTitle = "Add";
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> AddEditAsync(TblGame model)
        {
            try
            {
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");
                string ImageName = string.Empty;
                string StrPath = string.Empty;

                if (model.Id != 0)
                {

                    TblGame objData = (from c in this.DbContext.TblGame
                                               where c.Id == model.Id
                                               select c).FirstOrDefault();
                    if (objData != null)
                    {
                        var files = HttpContext.Request.Form.Files;
                        foreach (var Image in files)
                        {
                            if (Image != null && Image.Length > 0)
                            {
                                var file = Image;

                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameMapImg");
                                if (file.Length > 0)
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.MapImgUrl = "UploadeImage/GameMapImg/"+ fileName;
                                    }

                                }
                            }
                        }
                        objData.IdGame = model.IdGame;
                        objData.GameName = model.GameName;
                        objData.MapImgUrl = model.MapImgUrl;
                        objData.IdOrganization = model.IdOrganization;
                        objData.Status = model.Status;
                        objData.UpdatedDateTime = DateTime.UtcNow;
                        objData.IdCmsUser = HttpContext.Session.GetInt32("CMSuserId");
                        _unitOfWork.Complete();
                    }
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    model.IdCmsUser = HttpContext.Session.GetInt32("CMSuserId");

                    model.UpdatedDateTime = DateTime.UtcNow;
                    _unitOfWork.Game.Add(model);
                    _unitOfWork.Complete();
                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;

                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameMapImg");
                            if (file.Length > 0)
                            {
                                var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                    model.MapImgUrl = "UploadeImage/GameMapImg/"+fileName;
                                }

                            }
                        }
                    }
                    TblGame objData = (from c in this.DbContext.TblGame
                                               where c.Id == model.Id
                                               select c).FirstOrDefault();
                    if (objData != null)
                    {
                        objData.MapImgUrl = model.MapImgUrl;
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
