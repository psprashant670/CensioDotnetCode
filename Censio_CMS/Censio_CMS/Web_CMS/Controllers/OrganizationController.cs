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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class OrganizationController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public OrganizationController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }




        public ActionResult Index()
        {
            var model = this.DbContext.TblOrganization.ToList();
            ViewBag.PageName = "Organization List";


            return View(model);

        }

        public ActionResult Edit(int? id)
        {
            OrganizationModel model = new OrganizationModel();

            TblOrganization tblData = new TblOrganization();

            tblData = this.DbContext.TblOrganization.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdOrganization = tblData.IdOrganization;
                model.OrganizationName = tblData.OrganizationName;
                model.Description = tblData.Description;
                model.Logo = tblData.Logo;
                model.Name = tblData.Name;
                model.PhoneNo = tblData.PhoneNo;
                model.DefaultEmail = tblData.DefaultEmail;
                model.ContactEmail = tblData.ContactEmail;
                model.Status = tblData.Status;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
              
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
            OrganizationModel model = new OrganizationModel();

           
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddEditAsync(TblOrganization model)
        {
            try
            {
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");
                string ImageName = string.Empty;
                string StrPath = string.Empty;

                if (model.IdOrganization != 0)
                {

                    TblOrganization objData = (from c in this.DbContext.TblOrganization
                                               where c.IdOrganization == model.IdOrganization
                                               select c).FirstOrDefault();
                    if (objData != null)
                    {
                        var files = HttpContext.Request.Form.Files;
                        foreach (var Image in files)
                        {
                            if (Image != null && Image.Length > 0)
                            {
                                var file = Image;

                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/OrganizationLogo");
                                if (file.Length > 0)
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.Logo = "UploadeImage/OrganizationLogo/"+fileName;
                                    }

                                }
                            }
                        }
                        objData.OrganizationName = model.OrganizationName;
                        objData.Description = model.Description;
                        objData.Logo = model.Logo;
                        objData.ContactEmail = model.ContactEmail;
                        objData.DefaultEmail = model.DefaultEmail;
                        objData.Status = model.Status;
                        objData.UpdatedDateTime = DateTime.UtcNow;
                        objData.PhoneNo = model.PhoneNo;
                         objData.Name = model.Name;
                         objData.IdCmsUser = HttpContext.Session.GetInt32("CMSuserId");
                        _unitOfWork.Complete();
                    }
                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    model.IdCmsUser = HttpContext.Session.GetInt32("CMSuserId");

                    model.UpdatedDateTime = DateTime.UtcNow;
                    _unitOfWork.Organization.Add(model);
                    _unitOfWork.Complete();
                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;

                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/OrganizationLogo");
                            if (file.Length > 0)
                            {
                                var fileName = model.IdOrganization + "_" + Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                    model.Logo = "UploadeImage/OrganizationLogo/"+fileName;
                                }

                            }
                        }
                    }
                    TblOrganization objData = (from c in this.DbContext.TblOrganization
                                               where c.IdOrganization == model.IdOrganization
                                               select c).FirstOrDefault();
                    if (objData != null)
                    {
                        objData.Logo = model.Logo;
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
