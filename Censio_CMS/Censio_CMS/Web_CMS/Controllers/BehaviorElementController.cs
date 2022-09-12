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
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class BehaviorElementController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public BehaviorElementController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        public ActionResult Index()
        {
            var model = this.DbContext.TblBehaviorElement.ToList();
            ViewBag.PageName = "BehaviorElement List";
            return View(model);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblBehaviorElement model = this.DbContext.TblBehaviorElement.Find(id);

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
        public ActionResult AddEdit(TblBehaviorElement model)
        {
            try
            {
                model.IdCmsUser = HttpContext.Session.GetInt32("userid");

                model.UpdatedDateTime = DateTime.UtcNow;
                if (model.IdBehavior != 0)
                {
                    _unitOfWork.BehaviorElement.Update(model);
                    _unitOfWork.Complete();

                    return Json(new { Message = "Successfully Updated", data = 1 });
                }
                else
                {
                    _unitOfWork.BehaviorElement.Add(model);
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
