using Acclimate_Models;
using DataAccess.EFCore.Game4Data;
using DataAccess.EFCore.Game4DataEntites;
using Domain.Game4DataEntites;
using Domain.Interfaces;
using Domain.Models;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Game4MapController")]
    [ApiController]
    public class Game4MapController : ControllerBase
    {
        private readonly db_cencio_game4DataDBContext _DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        public Game4MapController(IUnitOfWork unitOfWork, db_cencio_game4DataDBContext context)
        {
            _unitOfWork = unitOfWork;
            _DbContext = context;
        }

        [Route("~/api/GetGame4UserLevel")]
        [HttpGet]
        public IActionResult GetGame4UserLevel(int UserId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame4Userlog.Where(x => x.IdUser == UserId && x.IdGame == GameId).OrderBy(o => o.IdUserlog).ToList();

                if (data != null)
                {

                    string Data = JsonSerializer.Serialize(data);
                    string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }
        [Route("~/api/GetGame4LevelInfo")]
        [HttpGet]
        public IActionResult GetGame4LevelInfo(int LevelId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame4LevelMaster.Where(x => x.IdLevel == LevelId && x.IdGame == GameId).ToList();

                if (data != null)
                {

                    string Data = JsonSerializer.Serialize(data);
                    string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }
        [Route("~/api/GetGame4LevelImage")]
        [HttpGet]
        public IActionResult GetGame4LevelImage(int LevelId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame4LevelImages.Where(x => x.IdLevel == LevelId && x.IdGame == GameId).ToList();

                if (data != null)
                {

                    string Data = JsonSerializer.Serialize(data);
                    string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }
        [Route("~/api/GetGame4WordMaster")]
        [HttpGet]
        public IActionResult GetGame4WordMaster(int LevelId, int GameId)
        {
            try
            {
                var random = new Random();
                var data = this._DbContext.TblGame4WordMaster.Where(x => x.IdLevelMaster == LevelId && x.IdGame == GameId).ToList();
                var dataRandom = data.OrderBy(r => random.Next()).Take(4);

                if (dataRandom.Any())
                {

                    string Data = JsonSerializer.Serialize(dataRandom);
                    string Result = ency.getEncryptedString(Data);
                    return Ok(dataRandom);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }
        [Route("~/api/GetGame4LevelInstructions")]
        [HttpGet]
        public IActionResult GetGame4LevelInstructions(int LevelId, int GameId)
        {
            try
            {
                var data = this._DbContext.TblGame4LevelInstructions.Where(x => x.IdLevel == LevelId && x.IdGame == GameId).ToList();

                if (data != null)
                {

                    string Data = JsonSerializer.Serialize(data);
                    string Result = ency.getEncryptedString(Data);
                    return Ok(data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        [Route("~/api/Game4Userlog")]
        [HttpPost]
        public IActionResult Game4Userlog([FromBody] TblGame4Userlog ReqData)
        {
            try
            {
                //bool isExist = false;
                //isExist = _DbContext.TblGame4Userlog.Where(x => x.IdLevelMaster == ReqData.IdLevelMaster && x.IdGame == ReqData.IdGame).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (ReqData.IdGame != 0)
                {
                    ReqData.UpdateDatetime = DateTime.UtcNow;

                    _DbContext.TblGame4Userlog.Add(ReqData);
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

        [Route("~/api/Game4WordsLog")]
        [HttpPost]
        public IActionResult Game4WordsLog([FromBody] TblGame4WordsLog ReqData)
        {
            try
            {
                //bool isExist = false;
                //isExist = _DbContext.TblGame4WordsLog.Where(x => x.IdLevelMaster == ReqData.IdLevelMaster && x.IdGame == ReqData.IdGame).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (ReqData.IdGame != 0)
                {
                    ReqData.UpdateDatetime = DateTime.UtcNow;

                    _DbContext.TblGame4WordsLog.Add(ReqData);
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

        [Route("~/api/GetUserGame1Status")]
        [HttpGet]
        public IActionResult GetUserGame1Status(int IdGame, int UID)
        {
            int gamecomplete = 0;
            try
            {
                var data = this._DbContext.TblGame1UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame).ToList();
                var data4 = this._DbContext.TblGame1UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame && x.IdLevel == 4).ToList();

                //if (data.Any())
                //{
                if (!data.Any(x => x.IdLevel == 4))
                {
                    gamecomplete = 0;
                }

                if (data.Any(x => x.IdLevel == 4))
                {

                    if (data4.Any(x => x.IsCompleted == 1) || data4.Any(x => x.AttemptNo == 4) || data4.Any(x => x.BehaviorScore == -1))
                    {
                        gamecomplete = 1;
                    }
                }
                var result = new { IdGame = IdGame, Gamecompleted = gamecomplete };
                string Data = JsonSerializer.Serialize(result);
                string Result = ency.getEncryptedString(Data);
                return Ok(result);
                //}
                //else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }

        [Route("~/api/GetUserGame2Status")]
        [HttpGet]
        public IActionResult GetUserGame2Status(int IdGame, int UID)
        {
            int gamecomplete = 0;
            try
            {
                var data = this._DbContext.TblGame2UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame).ToList();
                var data8 = this._DbContext.TblGame2UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame && x.IdLevel == 8).ToList();

                //if (data.Any())
                //{
                if (!data.Any(x => x.IdLevel == 8))
                {
                    gamecomplete = 0;
                }

                if (data.Any(x => x.IdLevel == 8))
                {

                    if (data8.Any(x => x.IsCompleted == 1) || data8.Any(x => x.AttemptNo == 4) || data8.Any(x => x.BehaviorScore == -1))
                    {
                        gamecomplete = 1;
                    }
                }

                var result = new { IdGame = IdGame, Gamecompleted = gamecomplete };
                string Data = JsonSerializer.Serialize(result);
                string Result = ency.getEncryptedString(Data);
                return Ok(result);
                //}
                //else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }

        [Route("~/api/GetUserGame4Status")]
        [HttpGet]
        public IActionResult GetUserGame4Status(int IdGame, int UID)
        {
            int gamecomplete = 0;
            try
            {
                var data = this._DbContext.TblGame4Userlog.Where(x => x.IdUser == UID && x.IdGame == IdGame).ToList();

                //if (data.Any())
                //{
                if (!data.Any(x => x.IdLevelMasterid == 3))
                {
                    gamecomplete = 0;
                }

                if (data.Any(x => x.IdLevelMasterid == 3))
                {


                    gamecomplete = 1;

                }

                var result = new { IdGame = IdGame, Gamecompleted = gamecomplete };
                string Data = JsonSerializer.Serialize(result);
                string Result = ency.getEncryptedString(Data);
                return Ok(result);
                //}
                //else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }

        [Route("~/api/GetUserGame5Status")]
        [HttpGet]
        public IActionResult GetUserGame5Status(int IdGame, int UID)
        {
            int gamecomplete = 0;
            try
            {
                var data = this._DbContext.TblGame5UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame).ToList();
                var data16 = this._DbContext.TblGame5UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame && x.IdLevel == 16).ToList();
                //if (data.Any())
                //{
                if (!data.Any(x => x.IdLevel == 16))
                {
                    gamecomplete = 0;
                }

                if (data.Any(x => x.IdLevel == 16))
                {

                    if (data16.Any(x => x.IsCompleted == 1) || data16.Any(x => x.AttemptNo == 4) || data16.Any(x => x.BehaviorScore == -1))
                    {
                        gamecomplete = 1;
                    }
                }

                var result = new { IdGame = IdGame, Gamecompleted = gamecomplete };
                string Data = JsonSerializer.Serialize(result);
                string Result = ency.getEncryptedString(Data);
                return Ok(result);
                //}
                //else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }

        [Route("~/api/GetGame2Dashboard")]
        [HttpGet]
        public IActionResult GetGame2Dashboard(int IdGame, int UID)
        {
            try
            {

                var TotalGameCoins = (from l in this._DbContext.TblGame2UserLog
                                      where l.IdGame == IdGame
                                       && l.IdUser == UID
                                       && l.IsCompleted == 1
                                      select new
                                      {
                                          l.IdUser,
                                          l.RewardCoins
                                          //l.GameCoins,
                                          //l.GoldCoins

                                      }).GroupBy(x => new { x.IdUser }).Select(g => new
                                      {
                                          IdUser = g.Key.IdUser,
                                          RewardCoins = g.Sum(s => s.RewardCoins)
                                          //GameCoins = g.Sum(s => s.GameCoins),
                                          //GoldCoins = g.Sum(s => s.GoldCoins)
                                      }).FirstOrDefault();


                var Accuracy_Level = (from l in this._DbContext.TblGame2UserLog

                                      where l.IdGame == IdGame
                                          && l.IdUser == UID

                                      select new
                                      {
                                          l.IdUser,
                                          l.AccuracyLevel

                                      }).ToList();

                var averageLst = Accuracy_Level.Select(x => x.AccuracyLevel).Average();

                if (TotalGameCoins != null)
                {
                    DashboardModel Data = new DashboardModel();
                    Data.Accuracy_Level = ((double)(averageLst == null ? 0 : averageLst));
                    //Data.GoldCoins = TotalGameCoins.GoldCoins;
                    Data.RewardCoins = (int)TotalGameCoins.RewardCoins;
                    //Data.GameCoins = TotalGameCoins.GameCoins;
                    //string Data = JsonSerializer.Serialize(Total_Coins);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(Data);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }

        [Route("~/api/GetUserGame1LevelStatus")]
        [HttpGet]
        public IActionResult GetUserGame1LevelStatus(int IdGame, int UID)
        {

            int levelcomplete = 0;
            try
            {
                var data = this._DbContext.TblGame1UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame).OrderBy(o => o.IdLevel).ThenBy(o => o.AttemptNo).ToList();
                var latestLevelData = data.OrderBy(o => o.IdLevel).ThenByDescending(o => o.AttemptNo).GroupBy(o => o.IdLevel).Select(o => o.FirstOrDefault()).ToList();


                List<LevelStatusModel> lstStatus = new List<LevelStatusModel>();


                if (latestLevelData.Any())
                {
                    for (int i = 0; i < latestLevelData.Count(); i++)
                    {
                        levelcomplete = 0;
                        if (latestLevelData[i].IsCompleted == 1)
                        {
                            levelcomplete = 1;
                        }
                        else if (latestLevelData[i].IsCompleted == 0 && latestLevelData[i].AttemptNo == 4)
                        {
                            levelcomplete = -1;
                        }
                        else if (latestLevelData[i].BehaviorScore == -1)
                        {
                            levelcomplete = -1;
                        }
                        else if (latestLevelData[i].IsCompleted == 0 && latestLevelData[i].AttemptNo == 1 || latestLevelData[i].AttemptNo == 2 || latestLevelData[i].AttemptNo == 3)
                        {
                            levelcomplete = 0;
                            latestLevelData[i].AttemptNo = latestLevelData[i].AttemptNo + 1;
                        }
                        LevelStatusModel lstLevelStatus = new LevelStatusModel
                        {
                            IdLevel = (int)latestLevelData[i].IdLevel,
                            LevelStatus = levelcomplete,
                            Attempt_No = latestLevelData[i].AttemptNo
                        };
                        lstStatus.Add(lstLevelStatus);




                    }

                    var result = JsonSerializer.Serialize(lstStatus);
                    var finalResult = JsonSerializer.Deserialize<List<LevelStatusModel>>(result);

                    return Ok(finalResult);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }

        [Route("~/api/GetUserGame2LevelStatus")]
        [HttpGet]
        public IActionResult GetUserGame2LevelStatus(int IdGame, int UID)
        {

            int levelcomplete = 0;
            try
            {
                var data = this._DbContext.TblGame2UserLog.Where(x => x.IdUser == UID && x.IdGame == IdGame).OrderBy(o => o.IdLevel).ThenBy(o => o.AttemptNo).ToList();
                var latestLevelData = data.OrderBy(o => o.IdLevel).ThenByDescending(o => o.AttemptNo).GroupBy(o => o.IdLevel).Select(o => o.FirstOrDefault()).ToList();


                List<LevelStatusModel> lstStatus = new List<LevelStatusModel>();


                if (latestLevelData.Any())
                {
                    for (int i = 0; i < latestLevelData.Count(); i++)
                    {
                        levelcomplete = 0;
                        if (latestLevelData[i].IsCompleted == 1)
                        {
                            levelcomplete = 1;
                        }
                        else if (latestLevelData[i].IsCompleted == 0 && latestLevelData[i].AttemptNo == 4)
                        {
                            levelcomplete = -1;
                        }
                        else if (latestLevelData[i].IdSubliminalMeasurement1 == 4)
                        {
                            levelcomplete = -1;
                        }
                        else if (latestLevelData[i].IsCompleted == 0 && latestLevelData[i].AttemptNo == 1 || latestLevelData[i].AttemptNo == 2 || latestLevelData[i].AttemptNo == 3)
                        {
                            levelcomplete = 0;
                            latestLevelData[i].AttemptNo = latestLevelData[i].AttemptNo + 1;
                        }
                        LevelStatusModel lstLevelStatus = new LevelStatusModel
                        {
                            IdLevel = (int)latestLevelData[i].IdLevel,
                            LevelStatus = levelcomplete,
                            Attempt_No = latestLevelData[i].AttemptNo
                        };
                        lstStatus.Add(lstLevelStatus);




                    }

                    var result = JsonSerializer.Serialize(lstStatus);
                    var finalResult = JsonSerializer.Deserialize<List<LevelStatusModel>>(result);

                    return Ok(finalResult);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }

        }
    }

}
