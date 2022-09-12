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
    public class GameChallengelevelController : Controller
    {
        int ID_ORGANIZATION = CommonFunctions.ID_ORGANIZATION;
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        string hrefURL = Startup.GethrefURL();
        private readonly IWebHostEnvironment webHostEnvironment;
        public GameChallengelevelController(IUnitOfWork unitOfWork, db_censio_betaContext context, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public ActionResult Index()
        {
            var model = (from T in this.DbContext.TblGameChallengelevel
                         join S in this.DbContext.TblGame on T.IdGame equals S.IdGame
                       
                         where T.IdOrganization == ID_ORGANIZATION 
                         select new
                         {

                             S.GameName,
                             T.IdLevel,
                             T.IdGame,
                             T.ChallengeName,
                             T.ChallengeSmallImgUrl,
                             T.IdOrganization,
                             T.ChallengeBigImgUrl,
                             T.IsActive,
                             T.UpdatedDateTime,
                             T.BigImgText,
                             T.ChallengeIntroMessage,
                             T.BottomCompleteMessage,
                             T.BottomFailMessage,
                             T.ChallengePieceMapImgUrl,
                             T.ChallengePieceMapMsg,
                             T.AgainPlayCoins,
                             T.AttemptsAllowed,
                             T.AttemptTimer,
                             T.ThirdGameScore,
                             T.SpecialPoint,
                             T.NotBackingOutMsg,
                             T.SuperpowerCoinGame3,
                         }).Select(X => new GameChallengelevelModel
                         {
                             IdLevel = X.IdLevel,
                             IdGame = X.IdGame,
                             GameName = X.GameName,
                             ChallengeName = X.ChallengeName,
                             ChallengeSmallImgUrl = X.ChallengeSmallImgUrl,
                             IdOrganization = X.IdOrganization,
                             ChallengeBigImgUrl = X.ChallengeBigImgUrl,
                             IsActive = X.IsActive,
                             UpdatedDateTime = X.UpdatedDateTime,
                             BigImgText = X.BigImgText,
                             ChallengeIntroMessage = X.ChallengeIntroMessage,
                             BottomCompleteMessage = X.BottomCompleteMessage,
                             BottomFailMessage = X.BottomFailMessage,
                             ChallengePieceMapImgUrl = X.ChallengePieceMapImgUrl,
                             ChallengePieceMapMsg = X.ChallengePieceMapMsg,
                             AgainPlayCoins = X.AgainPlayCoins,
                             AttemptTimer = X.AttemptTimer,
                             ThirdGameScore = X.ThirdGameScore,
                             SpecialPoint = X.SpecialPoint,
                             NotBackingOutMsg = X.NotBackingOutMsg,
                             SuperpowerCoinGame3 = X.SuperpowerCoinGame3,
                             AttemptsAllowed = X.AttemptsAllowed,
                         }).ToList();

            ViewBag.PageName = "Game Challengelevel List";


            return View(model);

        }


        public ActionResult Edit(int? id)
        {
            GameChallengelevelModel model = new GameChallengelevelModel();

            TblGameChallengelevel tblData = new TblGameChallengelevel();

            tblData = this.DbContext.TblGameChallengelevel.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.IdLevel = tblData.IdLevel;
                model.ChallengeName = tblData.ChallengeName;
                model.IdGame = tblData.IdGame;
                model.ChallengeSmallImgUrl = tblData.ChallengeSmallImgUrl;
                model.ChallengeBigImgUrl = tblData.ChallengeBigImgUrl;
                model.BigImgText = tblData.BigImgText;
                model.ChallengeIntroMessage = tblData.ChallengeIntroMessage;
                model.BottomCompleteMessage = tblData.BottomCompleteMessage;
                model.BottomFailMessage = tblData.BottomFailMessage;
                model.ChallengePieceMapImgUrl = tblData.ChallengePieceMapImgUrl;
                model.ChallengePieceMapMsg = tblData.ChallengePieceMapMsg;
                model.AgainPlayCoins = tblData.AgainPlayCoins;
                model.AttemptsAllowed = tblData.AttemptsAllowed;
                model.AttemptTimer = tblData.AttemptTimer;
                model.IdOrganization = tblData.IdOrganization;
                model.IsActive = tblData.IsActive;
                model.UpdatedDateTime = tblData.UpdatedDateTime;
                model.ThirdGameScore = tblData.ThirdGameScore;
                model.SpecialPoint = tblData.SpecialPoint;
                model.NotBackingOutMsg = tblData.NotBackingOutMsg;
                model.SuperpowerCoinGame3 = tblData.SuperpowerCoinGame3;
            }

            ViewBag.modelTitle = "Edit";
            model.GameNameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });

            return View("Create", model);

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            GameChallengelevelModel model = new GameChallengelevelModel();

            model.GameNameList = DbContext.TblGameMaster.ToList().Select(X => new SelectListItem
            {
                Text = X.GameName,
                Value = X.IdGame.ToString()
            });
            ViewBag.modelTitle = "Add";
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddEditAsync(TblGameChallengelevel model)
        {
            model.IdOrganization = (int)ID_ORGANIZATION;
            model.UpdatedDateTime = DateTime.UtcNow;
            model.IdCmsUser = HttpContext.Session.GetInt32("userid");
            try
            {


                var files = HttpContext.Request.Form.Files;
                if (model.IdLevel != 0)
                {
                    TblGameChallengelevel objData = (from c in this.DbContext.TblGameChallengelevel
                                                     where c.IdLevel == model.IdLevel
                                                        select c).FirstOrDefault();
                    if (objData != null)
                    {
                        for (int i = 0; i < files.Count; ++i)
                        {
                            if (files[i].Name == "ChallengeSmallImgUrlfile")
                            {
                                var file = files[i];
                                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg"};
                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengeSmallImgUrl");
                                if (files[i].Length > 0)
                                {
                                    var ext = Path.GetExtension(files[i].FileName);
                                    if (allowedExtensions.Contains(ext))
                                    {
                                        var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                        HttpContext.Session.SetString("BuildingImgFileName", fileName);

                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.ChallengeSmallImgUrl = "UploadeImage/GameChallengelevel/ChallengeSmallImgUrl/"+fileName;
                                        }
                                    }
                                    else
                                    {
                                        return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                    }

                                }
                              
                            }
                            if (files[i].Name == "ChallengeBigImgUrlfile")
                            {
                                var file = files[i];
                                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg"};
                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengeBigImgUrl");
                                if (files[i].Length > 0)
                                {
                                    var ext = Path.GetExtension(files[i].FileName);
                                    if (allowedExtensions.Contains(ext))
                                    {
                                        var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                        HttpContext.Session.SetString("BuildingOrgLogoImgFileName", fileName);

                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.ChallengeBigImgUrl = "UploadeImage/GameChallengelevel/ChallengeBigImgUrl/"+fileName;
                                        }
                                    }
                                    else
                                    {
                                        return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                    }
                                }

                               
                            }
                            if (files[i].Name == "ChallengePieceMapImgUrlfile")
                            {
                                var file = files[i];
                                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg" };
                                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengePieceMapImgUrl");
                                if (files[i].Length > 0)
                                {
                                    var ext = Path.GetExtension(files[i].FileName);
                                    if (allowedExtensions.Contains(ext))
                                    {
                                        var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                        HttpContext.Session.SetString("BuildingOrgLogoImgFileName", fileName);

                                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.ChallengePieceMapImgUrl = "UploadeImage/GameChallengelevel/ChallengePieceMapImgUrl/"+fileName;
                                        }
                                    }
                                    else
                                    {
                                        return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                    }
                                }


                            }
                        }

                        objData.IdGame = model.IdGame;
                        objData.ChallengeName = model.ChallengeName;
                        objData.IdGame = model.IdGame;
                        objData.ChallengeName = model.ChallengeName;
                        objData.ChallengeSmallImgUrl = model.ChallengeSmallImgUrl;
                        objData.ChallengeBigImgUrl = model.ChallengeBigImgUrl;
                        objData.BigImgText = model.BigImgText;
                        objData.ChallengeIntroMessage = model.ChallengeIntroMessage;
                        objData.BottomCompleteMessage = model.BottomCompleteMessage;
                        objData.BottomFailMessage = model.BottomFailMessage;
                        objData.ChallengePieceMapImgUrl = model.ChallengePieceMapImgUrl;
                        objData.ChallengePieceMapMsg = model.ChallengePieceMapMsg;
                        objData.AgainPlayCoins = model.AgainPlayCoins;
                        objData.AttemptsAllowed = model.AttemptsAllowed;
                        objData.AttemptTimer = model.AttemptTimer;
                        objData.UpdatedDateTime = DateTime.UtcNow;
                        objData.IsActive = model.IsActive;
                        objData.IdOrganization = model.IdOrganization;
                        objData.IdCmsUser = model.IdCmsUser;
                        objData.ThirdGameScore = model.ThirdGameScore;
                        objData.SpecialPoint = model.SpecialPoint;
                        objData.NotBackingOutMsg = model.NotBackingOutMsg;
                        objData.SuperpowerCoinGame3 = model.SuperpowerCoinGame3;
                        _unitOfWork.Complete();



                    }
                    return Json(new { Message = "Successfully Updated", data = 1 });

                }
                else
                {

                    _unitOfWork.GameChallengelevel.Add(model);
                    _unitOfWork.Complete();
                    for (int i = 0; i < files.Count; ++i)
                    {
                        if (files[i].Name == "ChallengeSmallImgUrlfile")
                        {
                            var file = files[i];
                            var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg", ".mp3", ".ogg", ".wav", ".mp4", ".mov", ".wmv" };
                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengeSmallImgUrl");
                            if (files[i].Length > 0)
                            {
                                var ext = Path.GetExtension(files[i].FileName);
                                if (allowedExtensions.Contains(ext))
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                    HttpContext.Session.SetString("BuildingImg_FileName", fileName);

                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.ChallengeSmallImgUrl = "UploadeImage/GameChallengelevel/ChallengeSmallImgUrl/"+ fileName;
                                    }
                                }
                                else
                                {
                                    return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                }
                            }

                        }
                        if (files[i].Name == "ChallengeBigImgUrlfile")
                        {
                            var file = files[i];
                            var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg"};
                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengeBigImgUrl");
                            if (files[i].Length > 0)
                            {
                                var ext = Path.GetExtension(files[i].FileName);
                                if (allowedExtensions.Contains(ext))
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                    HttpContext.Session.SetString("BuildingOrgLogoImg_FileName", fileName);

                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.ChallengeBigImgUrl = "UploadeImage/GameChallengelevel/ChallengeBigImgUrl/"+fileName;
                                    }
                                }
                                else
                                {
                                    return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                }
                            }

                        }
                        if (files[i].Name == "ChallengePieceMapImgUrlfile")
                        {
                            var file = files[i];
                            var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".svg", ".mp3", ".ogg", ".wav", ".mp4", ".mov", ".wmv" };
                            var uploads = Path.Combine(webHostEnvironment.WebRootPath, "UploadeImage/GameChallengelevel/ChallengePieceMapImgUrl");
                            if (files[i].Length > 0)
                            {
                                var ext = Path.GetExtension(files[i].FileName);
                                if (allowedExtensions.Contains(ext))
                                {
                                    var fileName = model.IdOrganization + "_" + Path.GetFileName(files[i].FileName);
                                    HttpContext.Session.SetString("BuildingOrgLogoImg_FileName", fileName);

                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.ChallengePieceMapImgUrl = "UploadeImage/GameChallengelevel/ChallengePieceMapImgUrl/"+fileName;
                                    }
                                }
                                else
                                {
                                    return Json(new { Message = "Sorry!! Uploade only .Jpg, .png, jpeg, .svg", data = 3 });
                                }
                            }

                        }
                    }
                    TblGameChallengelevel objData = (from c in this.DbContext.TblGameChallengelevel
                                                        where c.IdLevel == model.IdLevel
                                                        select c).FirstOrDefault();
                    if (objData != null)
                    {
                        objData.ChallengeSmallImgUrl = model.ChallengeSmallImgUrl;
                        objData.ChallengeBigImgUrl = model.ChallengeBigImgUrl;
                        objData.ChallengePieceMapImgUrl = model.ChallengePieceMapImgUrl;
                      
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
