
using m2ostnextservice.Models;
using Censio_CMS.Helpers;
using Censio_CMS.Models;
using Censio_CMS.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using Domain.Entities;

namespace Censio_CMS.Controllers
{
    public class LoginController : Controller
    {
        AESAlgorithm ency = new AESAlgorithm();
        private readonly db_censio_betaContext censio_Context;
        public LoginController(db_censio_betaContext dbContext)
        {
            censio_Context = dbContext;
        }

        public bool IsEmailPassExist(string email, string Password)
        {
            bool isExist = false;
            isExist = censio_Context.TblCmsUsers.Where(x => x.Email.Trim().ToLower() == email.Trim().ToLower() && x.Password.Trim().ToLower() == Password.Trim().ToLower()).Any();
            return isExist;
        }

        public TblCmsUsers GetCmsUserBYemail(string Email)
        {
            var user = (from x in censio_Context.TblCmsUsers
                        where x.Email.Trim().ToLower() == Email.Trim().ToLower()
                        select x).SingleOrDefault();
            return user;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogins(TblCmsUsers User)
        {
            var pass = ency.getEncryptedString(User.Password.Trim());
            var _user = censio_Context.TblCmsUsers.Where(s => s.Email == User.Email);
            if (_user.Any())
            {
                if (_user.Where(s => s.Password == pass).Any())
                {

                    TblCmsUsers user = GetCmsUserBYemail(User.Email);
                    var role_ids = Convert.ToString(user.IdCmsRole);
                    List<MenuModel> _menus = censio_Context.TblSubmenu.Where(X => X.IdCmsRole.Contains(role_ids)).Select(x => new MenuModel


                    {
                        MainMenuId = x.MainMenu.MainMenuId,
                        MainMenuName = x.MainMenu.MainMenuName,
                        sequence = x.MainMenu.Sequence,
                        SubMenuId = x.SubMenuId,
                        SubMenuName = x.SubMenuName,
                        Sequence = x.Sequence,
                        ControllerName = x.Controller,
                        ActionName = x.Action,
                        Status = x.Status
                    }).OrderBy(x => x.sequence).ToList();
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "LoginCredentials", user);
                    HttpContext.Session.SetInt32("CMSuserId", user.IdCmsUser);
                    HttpContext.Session.SetString("UserName", user.Name);
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "Menudata", _menus);
                    HttpContext.Session.SetInt32("userid", user.IdCmsUser);
                    HttpContext.Session.SetString("EmailId", user.Email);

                    int org_id = (int)user.IdOrganization;

                    HttpContext.Session.SetInt32("id_org", org_id);
                    HttpContext.Session.SetInt32("idorg", (int)user.IdOrganization);
                    string org_name = censio_Context.TblOrganization.Where(x => x.Status == "A" && x.IdOrganization == user.IdOrganization).Single().OrganizationName;
                    CommonFunctions.ID_ORGANIZATION = (int)HttpContext.Session.GetInt32("idorg");
                    HttpContext.Session.SetObjectAsJson("id_org", org_name);
                    HttpContext.Session.SetString("OrgName", org_name);
                    return Json(new { status = true, message = " Success", data = 1 });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!", data = 2 });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!", data = 3 });
            }
        }


        public ActionResult Logout()
        {

            HttpContext.Session.Clear();
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("");
            return RedirectToAction("Login", "Login");
        }
    }
}
