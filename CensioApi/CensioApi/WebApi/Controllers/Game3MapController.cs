using DataAccess.EFCore.Data;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Game3MapController")]
    [ApiController]
    public class Game3MapController : ControllerBase
    {
        private readonly db_censio_betaContext _DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        public Game3MapController(IUnitOfWork unitOfWork, db_censio_betaContext context)
        {
            _unitOfWork = unitOfWork;
            _DbContext = context;
        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Instructions")]
        [HttpGet]
        public IActionResult GetGame3Instructions(int OrgId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame3Instructions.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Reset")]
        [HttpGet]
        public IActionResult GetGame3Reset(int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame3FestivalReset.Where(x => x.IdGame == GameId && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Festival")]
        [HttpGet]
        public IActionResult GetGame3Festival(int OrgId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame3Festivals.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Level")]
        [HttpGet]
        public IActionResult GetGame3Level(int OrgId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame3Levels.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Question")]
        [HttpGet]
        public IActionResult GetGame3Question(int OrgId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblQuestions.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3Response")]
        [HttpGet]
        public IActionResult GetGame3Response(int Ques)
        {
            try
            {
                var data = this._DbContext.TblQuestionResponses.Where(x => x.IdQuestion == Ques && x.Status == "A").ToList();

                if (data != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/Game3ResponseLog")]
        [HttpPost]
        public IActionResult Game3ResponseLog([FromBody] List<TblQuestionResponsesLog> ReqData)
        {
            try
            {
                bool isExist = false;

                foreach (var data in ReqData)
                {
                    //isExist = _DbContext.TblQuestionResponsesLog.Where(x => x.IdUser == data.IdUser && x.LifeNo == data.LifeNo && x.FestivalName == data.FestivalName && x.RawMaterial == data.RawMaterial && x.RawMaterialType == data.RawMaterialType).Any();

                    if (!isExist)
                    {
                        data.UpdatedDateTime = DateTime.UtcNow;

                        _DbContext.TblQuestionResponsesLog.Add(data);
                        _DbContext.SaveChanges();
                        //string Data = JsonSerializer.Serialize(ReqData);
                        //string Result = ency.getEncryptedString(Data);

                    }
                    else
                    {
                        return BadRequest("Duplicate attempt");
                    }
                }
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        // Developed by Raj Lakhwani
        [Route("~/api/Game3Log")]
        [HttpPost]
        public IActionResult Game3Log([FromBody] Game3LogModel ReqData)
        {
            try
            {
                TblGame3UserLog user = new TblGame3UserLog();
                TblGame3LevelLog level = new TblGame3LevelLog();
                bool isExist = false;
                //isExist = _DbContext.TblGame3UserLog.Where(x => x.IdLevelMaster == ReqData.IdLevelMaster && x.IdGame == ReqData.IdGame).Any();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (!isExist)
                {
                    user.IdUser = ReqData.IdUser;
                    user.IdOrganization = ReqData.IdOrganization;
                    user.IdGame = ReqData.IdGame;
                    user.IdFestival = ReqData.IdFestival;
                    user.FestivalName = ReqData.FestivalName;
                    user.LifeNo = ReqData.LifeNo;
                    user.RawMaterial = ReqData.RawMaterial;
                    user.FestivalRawMatPresented = ReqData.FestivalRawMatPresented;
                    user.FestivalRawMatSelected = ReqData.FestivalRawMatSelected;
                    user.FestivalScore = ReqData.FestivalScore;
                    user.FestivalSuccess = ReqData.FestivalSuccess;
                    user.SecondaryFestivalName1 = ReqData.SecondaryFestivalName1;
                    user.SecondaryFestivalType1 = ReqData.SecondaryFestivalType1;
                    user.SecondaryRawMatPresented1 = ReqData.SecondaryRawMatPresented1;
                    user.SecondaryRawMatSelected1 = ReqData.SecondaryRawMatSelected1;
                    user.SecondaryScore1 = ReqData.SecondaryScore1;
                    user.SecondarySuccess1 = ReqData.SecondarySuccess1;
                    user.SecondaryFestivalName2 = ReqData.SecondaryFestivalName2;
                    user.SecondaryFestivalType2 = ReqData.SecondaryFestivalType2;
                    user.SecondaryRawMatPresented2 = ReqData.SecondaryRawMatPresented2;
                    user.SecondaryRawMatSelected2 = ReqData.SecondaryRawMatSelected2;
                    user.SecondaryScore2 = ReqData.SecondaryScore2;
                    user.SecondarySuccess2 = ReqData.SecondarySuccess2;
                    user.SecondaryFestivalName3 = ReqData.SecondaryFestivalName3;
                    user.SecondaryFestivalType3 = ReqData.SecondaryFestivalType3;
                    user.SecondaryRawMatPresented3 = ReqData.SecondaryRawMatPresented3;
                    user.SecondaryRawMatSelected3 = ReqData.SecondaryRawMatSelected3;
                    user.SecondaryScore3 = ReqData.SecondaryScore3;
                    user.SecondarySuccess3 = ReqData.SecondarySuccess3;
                    user.TimeTaken = ReqData.TimeTaken;
                    user.FestivalExcessAmountCollected = ReqData.FestivalExcessAmountCollected;
                    user.LevelFestivalAmount = ReqData.LevelFestivalAmount;
                    user.LevelName = ReqData.LevelName;
                    user.UpdatedDateTime = DateTime.UtcNow;

                    _DbContext.TblGame3UserLog.Add(user);
                    _DbContext.SaveChanges();

                    level.IdUser = ReqData.IdUser;
                    level.StartIdLevel = ReqData.StartIdLevel;
                    level.StartLevelName = ReqData.StartLevelName;
                    level.EndIdLevel = ReqData.EndIdLevel;
                    level.EndLevelName = ReqData.EndLevelName;
                    level.FestivalName = ReqData.FestivalName;
                    level.FestivalLevelScore = ReqData.FestivalLevelScore;
                    level.LevelStartScore = ReqData.LevelStartScore;
                    level.LevelEndScore = ReqData.LevelEndScore;
                    level.LevelCumulativeScore = ReqData.LevelCumulativeScore;
                    level.UpdatedDateTime = DateTime.UtcNow;

                    _DbContext.TblGame3LevelLog.Add(level);
                    _DbContext.SaveChanges();

                    //string Data = JsonSerializer.Serialize(ReqData);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("No Valid Input(s) Found.");
                }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        // Developed by Raj Lakhwani
        [Route("~/api/Game3RawMaterialLog")]
        [HttpPost]
        public IActionResult Game3RawMaterialLog([FromBody] List<TblGame3RawMaterialLog> ReqData)
        {
            try
            {
                bool isExist = false;
                foreach (var data in ReqData)
                {
                    //isExist = _DbContext.TblGame3RawMaterialLog.Where(x => x.IdUser == data.IdUser && x.LifeNo == data.LifeNo && x.FestivalName == data.FestivalName && x.RawMaterial == data.RawMaterial && x.RawMaterialType == data.RawMaterialType).Any();

                    if (!isExist)
                    {
                        data.UpdatedDateTime = DateTime.UtcNow;

                        _DbContext.TblGame3RawMaterialLog.Add(data);
                        _DbContext.SaveChanges();
                        //string Data = JsonSerializer.Serialize(ReqData);
                        //string Result = ency.getEncryptedString(Data);

                    }
                    else
                    {
                        return BadRequest("Duplicate attempt");
                    }
                }
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3UserStatus")]
        [HttpGet]
        public IActionResult GetGame3UserStatus(int OrgId, int GameId, int UID)
        {
            try
            {
                var userData = this._DbContext.TblGame3UserLog.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.IdUser == UID).ToList();
                var levelData = this._DbContext.TblGame3LevelLog.Where(x => x.IdUser == UID).ToList();
                List<object> finalLst = userData.Cast<object>().Concat(levelData).ToList();

                if (userData != null)
                {

                    //string Data = JsonSerializer.Serialize(data);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(finalLst);

                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        // Developed by Raj Lakhwani
        [Route("~/api/GetGame3GameCompletion")]
        [HttpGet]
        public IActionResult GetGame3GameCompletion(int OrgId, int GameId, int UID)
        {
            int gamecomplete = 0;
            try
            {
                var festivalId = this._DbContext.TblGame3Festivals.Where(x => x.IdOrganization == OrgId && x.IdGame == GameId && x.FestivalSequence == 4 && x.Status == "A").Select(o => o.IdFestival).ToList();
                var userLst = this._DbContext.TblGame3UserLog.Where(x => x.IdUser == UID && x.IdGame == GameId && x.IdFestival == festivalId[0]).ToList();
                if (userLst.Any())
                {
                        gamecomplete = 1;
                }
                else { gamecomplete = 0; }

                var result = new { IdGame = GameId, Gamecompleted = gamecomplete };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }
    }
}
