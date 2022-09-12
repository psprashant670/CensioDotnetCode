using Censio_CMS.Web;
using Censio_CMS.Web.Filter;
using DataAccess.Data;
using Domain.Entities;
using Domain.Interfaces;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class AvatarController : Controller
    {

        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public AvatarController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }



        public ActionResult Index()
        {
            var model = this.DbContext.TblAvatar.Where(x => x.IdOrganization == ID_ORGANIZATION).ToList();
            ViewBag.PageName = "Avatar  List";

            return View(model);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblAvatar model = this.DbContext.TblAvatar.Find(id);
            //model.Url =hrefURL + model.Url;

            if (model == null)
            {
                return HttpNotFound();
            }
            ViewBag.modelTitle = "Edit";
            return View("Create", model);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            ViewBag.modelTitle = "Add";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddEditAsync(TblAvatar model)
        {
            model.IdOrganization = (int)ID_ORGANIZATION;
            model.UpdatedDateTime = DateTime.UtcNow;
            model.IdCmsUser = HttpContext.Session.GetInt32("userid");
            try
            {
                
                if (model.IdAvatar != 0)
                {
                    TblAvatar objData = (from c in this.DbContext.TblAvatar
                                                        where c.IdAvatar == model.IdAvatar
                                                        select c).FirstOrDefault();
                    if (objData != null)
                    {
                       

                        var files = HttpContext.Request.Form.Files;
                        foreach (var Image in files)
                        {
                            if (Image != null && Image.Length > 0)
                            {
                                var file = Image;

                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/AvatarImg");
                                if (file.Length > 0)
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.Url = "UploadeImage/AvatarImg/" + fileName;
                                    }

                                }
                            }
                        }


                        objData.Url = model.Url;
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

                    _unitOfWork.Avatar.Add(model);
                    _unitOfWork.Complete();
                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;

                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/AvatarImg");
                            if (file.Length > 0)
                            {
                                var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                    model.Url = "UploadeImage/AvatarImg/" + fileName;
                                }

                            }
                        }
                    }
                    TblAvatar objData = (from c in this.DbContext.TblAvatar
                                                        where c.IdAvatar == model.IdAvatar
                                                        select c).FirstOrDefault();
                    if (objData != null)
                    {

                        objData.Url = model.Url;
                       

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
