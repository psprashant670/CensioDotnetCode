using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Acclimate_Models;
using DataAccess.EFCore.Data;
using Domain.Entities;
using Domain.Interfaces;
using m2ostnextservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Game1GoldMineTreasureMapController")]

    public class Game1GoldMineTreasureMapController : ControllerBase
    {
        private readonly db_censio_betaContext DbContext;
        AESAlgorithm ency = new AESAlgorithm();
        private readonly IUnitOfWork _unitOfWork;
        public Game1GoldMineTreasureMapController(IUnitOfWork unitOfWork, db_censio_betaContext context)
        {
            _unitOfWork = unitOfWork;
            DbContext = context;
        }
        [Route("~/api/GetGameList")]
        [HttpGet]
        public IActionResult GetGameList(int OrgID)
        {
            try
            {
                var data = this.DbContext.TblGame.Where(x => x.IdOrganization == OrgID && x.Status == "A").ToList();

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
        [Route("~/api/GetAvatarList")]
        [HttpGet]
        public IActionResult GetAvatarList(int OrgID)
        {
            try
            {
                var data = this.DbContext.TblAvatar.Where(x => x.IdOrganization == OrgID && x.IsActive == "A").ToList();

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

        [Route("~/api/UserAvatarName")]
        [HttpGet]
        public IActionResult UserAvatarName(int UID, string UserAvatarName)
        {
            try
            {

                if (UID != 0 && UserAvatarName != null && UserAvatarName != "")
                {
                    TblUsers objData = (from c in DbContext.TblUsers
                                        where c.UserId == UID
                                        select c).FirstOrDefault();
                    if (objData != null)
                    {
                        objData.AvatarUserName = UserAvatarName;
                        DbContext.SaveChanges();
                    }
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Invalid Data");
                }
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        [Route("~/api/GetGameGuideDialogueList")]
        [HttpGet]
        public IActionResult GetGameGuideDialogueList(int IdGame, int OrgID)
        {
            try
            {
                var data = this.DbContext.TblGuideDialogues.Where(x => x.IdGame == IdGame && x.IdOrganization == OrgID && x.IsActive == "A").ToList();

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

        [Route("~/api/GetGameChallengeByGameId")]
        [HttpGet]
        public IActionResult GetGameChallengeByGameId(int IdGame, int OrgID)
        {
            try
            {
                var data = this.DbContext.TblGameChallengelevel.Where(x => x.IdGame == IdGame && x.IdOrganization == OrgID && x.IsActive == "A").ToList();

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

        [Route("~/api/GetpuzzelGameData")]
        [HttpGet]
        public IActionResult GetpuzzelGameData(int IdLevel, int OrgID)
        {
            try
            {
                var data = this.DbContext.TblPuzzleGame.Where(x => x.IdLevel == IdLevel && x.IdOrganization == OrgID && x.IsActive == "A").ToList();

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

        [Route("~/api/GetSubliminal_Measurement1")]
        [HttpGet]
        public IActionResult GetSubliminal_Measurement1(int IdGame, int OrgID)
        {
            try
            {
                var data = this.DbContext.TblSubliminalMeasurement1.Where(x => x.IdGame == IdGame && x.IdOrganization == OrgID && x.Status == "A").ToList();

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
        [Route("~/api/GetSubliminal_Measurement2")]
        [HttpGet]
        public IActionResult GetSubliminal_Measurement2(int IdGame, int OrgID, int IdLevel)
        {
            try
            {
                var data = this.DbContext.TblSubliminalMeasurement2.Where(x => x.IdGame == IdGame && x.IdLevel == IdLevel && x.IdOrganization == OrgID && x.Status == "A").ToList();

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
        [Route("~/api/GetGameAttemptData")]
        [HttpGet]
        public IActionResult GetGameAttemptData(int IdGame, int OrgID)
        {
            try
            {
                var data = this.DbContext.TblGameAttemptdata.Where(x => x.IdGame == IdGame && x.IdOrganization == OrgID && x.IsActive == "A").ToList();

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

        //[Route("~/api/GetGameAttempNumber")]
        //[HttpGet]
        //public IActionResult GetGameAttempNumber(int IdGame, int UID)
        //{
        //    try
        //    {
        //        var data = this.DbContext.TblGameUserLog.Where(x => x.IdGame == IdGame && x.IdUser == UID).OrderByDescending(o => o.UpdatedDateTime).ToList();

        //        if (data != null)
        //        {

        //            string Data = JsonSerializer.Serialize(data);
        //            string Result = ency.getEncryptedString(Data);
        //            return Ok(data);
        //        }
        //        else { return NotFound("No Data Available"); }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Conflict("Error in Code"); ;
        //    }

        //}

        [Route("~/api/GetGame1AttempNumber")]
        [HttpGet]
        public IActionResult GetGame1AttempNumber(int IdGame, int UID)
        {
            try
            {
                var data = this.DbContext.TblGame1UserLog.Where(x => x.IdGame == IdGame && x.IdUser == UID).OrderByDescending(o => o.UpdatedDateTime).FirstOrDefault();

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

        [Route("~/api/GetGame2AttempNumber")]
        [HttpGet]
        public IActionResult GetGame2AttempNumber(int IdGame, int UID)
        {
            try
            {
                var data = this.DbContext.TblGame2UserLog.Where(x => x.IdGame == IdGame && x.IdUser == UID).OrderByDescending(o => o.UpdatedDateTime).FirstOrDefault();

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



        //[Route("~/api/GetGame3AttempNumber")]
        //[HttpGet]
        //public IActionResult GetGame3AttempNumber(int IdGame, int UID)
        //{
        //    try
        //    {
        //        var data = this.DbContext.TblGame3UserLog.Where(x => x.IdGame == IdGame && x.IdUser == UID).OrderByDescending(o => o.UpdatedDateTime).FirstOrDefault();

        //        if (data != null)
        //        {

        //            string Data = JsonSerializer.Serialize(data);
        //            string Result = ency.getEncryptedString(Data);
        //            return Ok(data);
        //        }
        //        else { return NotFound("No Data Available"); }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Conflict("Error in Code"); ;
        //    }

        //}


        [Route("~/api/GetGame5AttempNumber")]
        [HttpGet]
        public IActionResult GetGame5AttempNumber(int IdGame, int UID)
        {
            try
            {
                var data = this.DbContext.TblGame5UserLog.Where(x => x.IdGame == IdGame && x.IdUser == UID).OrderByDescending(o => o.UpdatedDateTime).FirstOrDefault();

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

        [Route("~/api/Game1UserLog")]
        [HttpPost]
        public IActionResult Game1UserLog([FromBody] TblGame1UserLog ReqData)
        {
            try
            {
                bool isExist = false;
                isExist = DbContext.TblGame1UserLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo && x.IdLevel == ReqData.IdLevel && x.IdSubliminalMeasurement2 == ReqData.IdSubliminalMeasurement2).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (!isExist)
                {
                    ReqData.UpdatedDateTime = DateTime.UtcNow;
                    DbContext.TblGame1UserLog.Add(ReqData);
                    DbContext.SaveChanges();
                    string Data = JsonSerializer.Serialize(ReqData);
                    string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Dublicate attempt");
                }
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        [Route("~/api/Game2UserLog")]
        [HttpPost]
        public IActionResult Game2UserLog([FromBody] TblGame2UserLog ReqData)
        {
            try
            {
                bool isExist = false;
                isExist = DbContext.TblGame2UserLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo && x.IdLevel == ReqData.IdLevel && x.IdSubliminalMeasurement2 == ReqData.IdSubliminalMeasurement2).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (!isExist)
                {
                    ReqData.UpdatedDateTime = DateTime.UtcNow;

                    DbContext.TblGame2UserLog.Add(ReqData);
                    DbContext.SaveChanges();
                    string Data = JsonSerializer.Serialize(ReqData);
                    string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Duplicate attempt");
                }
            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        //[Route("~/api/Game3UserLog")]
        //[HttpPost]
        //public IActionResult Game3UserLog([FromBody] TblGame3UserLog ReqData)
        //{
        //    try
        //    {
        //        bool isExist = false;
        //        isExist = DbContext.TblGame3UserLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo && x.IdLevel == ReqData.IdLevel).Any();
        //        //TblGameUserLog ReqData = new TblGameUserLog();
        //        //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
        //        //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
        //        if (!isExist)
        //        {
        //            ReqData.UpdatedDateTime = DateTime.UtcNow;

        //            DbContext.TblGame3UserLog.Add(ReqData);
        //            DbContext.SaveChanges();
        //            string Data = JsonSerializer.Serialize(ReqData);
        //            string Result = ency.getEncryptedString(Data);
        //            return Ok("Success");
        //        }
        //        else
        //        {
        //            return BadRequest("Duplicate attempt");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Conflict("Error in Code");
        //    }
        //}

        [Route("~/api/Game5UserLog")]
        [HttpPost]
        public IActionResult Game5UserLog([FromBody] TblGame5UserLog ReqData)
        {
            try
            {
                bool isExist = false;
                isExist = DbContext.TblGame5UserLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo && x.IdLevel == ReqData.IdLevel).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (!isExist)
                {
                    ReqData.UpdatedDateTime = DateTime.UtcNow;

                    DbContext.TblGame5UserLog.Add(ReqData);
                    DbContext.SaveChanges();
                    string Data = JsonSerializer.Serialize(ReqData);
                    string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Duplicate attempt");
                }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        [Route("~/api/GameUserAttemptPurchaseLog")]
        [HttpPost]
        public IActionResult GameUserAttemptPurchaseLog([FromBody] TblGameUserAttemptPurchaseLog ReqData)
        {
            try
            {
                bool isExist = false;
                isExist = DbContext.TblGameUserAttemptPurchaseLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo).Any();
                //TblGameUserLog ReqData = new TblGameUserLog();
                //string Requestdata = ency.getDecryptedString(ApiRequestdata.Data);
                //ReqData = JsonSerializer.Deserialize<TblGameUserLog>(Requestdata);
                if (!isExist)
                {
                    ReqData.UpdatedDateTime = DateTime.UtcNow;

                    DbContext.TblGameUserAttemptPurchaseLog.Add(ReqData);
                    DbContext.SaveChanges();
                    string Data = JsonSerializer.Serialize(ReqData);
                    string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Duplicate attempt");
                }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }


        [Route("~/api/GetTotalGame1Coins")]
        [HttpGet]
        public IActionResult GetTotalGame1Coins(int IdGame, int UID)
        {
            try
            {

                var TotalGameCoins = (from l in DbContext.TblGame1UserLog
                                      where l.IdGame == IdGame
                                       && l.IdUser == UID
                                       && l.IsCompleted == 1
                                      select new
                                      {
                                          l.IdUser,
                                          l.RewardCoins,
                                          l.GameCoins,
                                          l.GoldCoins

                                      }).GroupBy(x => new { x.IdUser }).Select(g => new
                                      {
                                          IdUser = g.Key.IdUser,
                                          RewardCoins = g.Sum(s => s.RewardCoins),
                                          GameCoins = g.Sum(s => s.GameCoins),
                                          GoldCoins = g.Sum(s => s.GoldCoins)
                                      }).FirstOrDefault();


                int TotalDeductionCoins = (from l in DbContext.TblGameUserAttemptPurchaseLog

                                           where l.IdGame == IdGame
                                           && l.IdUser == UID

                                           select new
                                           {
                                               l.IdUser,
                                               l.Coins

                                           }).GroupBy(x => new { x.IdUser }).Select(g => new
                                           {
                                               IdUser = g.Key.IdUser,
                                               DeductionCoins = g.Sum(s => s.Coins)
                                           }).Select(x => x.DeductionCoins ?? 0).FirstOrDefault();

                if (TotalGameCoins != null)
                {
                    int Total_Coins = (TotalGameCoins.GoldCoins + TotalGameCoins.RewardCoins + TotalGameCoins.GameCoins) - TotalDeductionCoins;
                    //string Data = JsonSerializer.Serialize(Total_Coins);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(Total_Coins);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }


        [Route("~/api/GetTotalGame2Coins")]
        [HttpGet]
        public IActionResult GetTotalGame2Coins(int IdGame, int UID)

        {
            try
            {
                var TotalGameCoins = (from l in DbContext.TblGame2UserLog
                                      where l.IdGame == IdGame
                                       && l.IdUser == UID
                                       && l.IsCompleted == 1
                                      select new
                                      {
                                          l.IdUser,
                                          l.RewardCoins

                                      }).GroupBy(x => new { x.IdUser }).Select(g => new
                                      {
                                          IdUser = g.Key.IdUser,
                                          Score = g.Sum(s => s.RewardCoins) ?? 0,
                                      }).FirstOrDefault();

                //var TotalGameCoins = (from l in DbContext.TblGame2UserLog
                //                      where l.IdUser == UID && l.IdGame == IdGame
                //                      select new
                //                      {
                //                          l.Game2UserLog,
                //                          l.IdUser,
                //                          l.IdLevel,
                //                          l.RewardCoins,
                //                          l.AttemptNo

                //                      }).ToList();


              //  var data = TotalGameCoins.GroupBy(x => x.IdLevel)
              // .Select(g =>
              //g.GroupBy(item => item.AttemptNo)
              //.OrderByDescending(e => e.Key)
              //.First().First()).ToList();

                //int RewardCoins = data.GroupBy(x => new { x.IdUser }).Select(g => new
                //{
                //    RewardCoins = g.Sum(s => s.RewardCoins)

                //}).Select(x => x.RewardCoins ?? 0).FirstOrDefault();

                //int TotalDeductionCoins = (from l in DbContext.TblGameUserAttemptPurchaseLog

                //                           where l.IdGame == IdGame
                //                           && l.IdUser == UID

                //                           select new
                //                           {
                //                               l.IdUser,
                //                               l.Coins

                //                           }).GroupBy(x => new { x.IdUser }).Select(g => new
                //                           {
                //                               IdUser = g.Key.IdUser,
                //                               DeductionCoins = g.Sum(s => s.Coins)
                //                           }).Select(x => x.DeductionCoins ?? 0).FirstOrDefault();

                if (TotalGameCoins != null)
                {
                    ///int Total_Coins = (TotalGameCoins.) - TotalDeductionCoins;
                    //string Data = JsonSerializer.Serialize(Total_Coins);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(TotalGameCoins.Score);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }


        //[Route("~/api/GetTotalGame3Coins")]
        //[HttpGet]
        //public IActionResult GetTotalGame3Coins(int IdGame, int UID)
        //{
        //    try
        //    {

        //        var TotalGameCoins = (from l in DbContext.TblGame3UserLog
        //                              where l.IdGame == IdGame
        //                               && l.IdUser == UID
        //                               && l.IsCompleted == 1
        //                              select new
        //                              {
        //                                  l.IdUser,
        //                                  l.Score

        //                              }).GroupBy(x => new { x.IdUser }).Select(g => new
        //                              {
        //                                  IdUser = g.Key.IdUser,
        //                                  Score = g.Sum(s => s.Score) ?? 0,
        //                              }).FirstOrDefault();


        //        int TotalDeductionCoins = (from l in DbContext.TblGameUserAttemptPurchaseLog

        //                                   where l.IdGame == IdGame
        //                                   && l.IdUser == UID

        //                                   select new
        //                                   {
        //                                       l.IdUser,
        //                                       l.Coins

        //                                   }).GroupBy(x => new { x.IdUser }).Select(g => new
        //                                   {
        //                                       IdUser = g.Key.IdUser,
        //                                       DeductionCoins = g.Sum(s => s.Coins)
        //                                   }).Select(x => x.DeductionCoins ?? 0).FirstOrDefault();

        //        if (TotalGameCoins != null)
        //        {
        //            int Total_Coins = (TotalGameCoins.Score) - TotalDeductionCoins;
        //            //string Data = JsonSerializer.Serialize(Total_Coins);
        //            //string Result = ency.getEncryptedString(Data);
        //            return Ok(Total_Coins);
        //        }
        //        else { return NotFound("No Data Available"); }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Conflict("Error in Code"); ;
        //    }

        //}

        [Route("~/api/GetTotalGame5Coins")]
        [HttpGet]
        public IActionResult GetTotalGame5Coins(int IdGame, int UID)
        {
            try
            {

                var TotalGameCoins = (from l in DbContext.TblGame5UserLog
                                      where l.IdGame == IdGame
                                       && l.IdUser == UID
                                       && l.IsCompleted == 1
                                      select new
                                      {
                                          l.IdUser,
                                          l.GoldCoins

                                      }).GroupBy(x => new { x.IdUser }).Select(g => new
                                      {
                                          IdUser = g.Key.IdUser,
                                          GoldCoins = g.Sum(s => s.GoldCoins) ?? 0,
                                      }).FirstOrDefault();


                int TotalDeductionCoins = (from l in DbContext.TblGameUserAttemptPurchaseLog

                                           where l.IdGame == IdGame
                                           && l.IdUser == UID

                                           select new
                                           {
                                               l.IdUser,
                                               l.Coins

                                           }).GroupBy(x => new { x.IdUser }).Select(g => new
                                           {
                                               IdUser = g.Key.IdUser,
                                               DeductionCoins = g.Sum(s => s.Coins)
                                           }).Select(x => x.DeductionCoins ?? 0).FirstOrDefault();

                if (TotalGameCoins != null)
                {
                    int Total_Coins = (TotalGameCoins.GoldCoins) - TotalDeductionCoins;
                    //string Data = JsonSerializer.Serialize(Total_Coins);
                    //string Result = ency.getEncryptedString(Data);
                    return Ok(Total_Coins);
                }
                else { return NotFound("No Data Available"); }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code"); ;
            }

        }


        [Route("~/api/GetGame1Dashboard")]
        [HttpGet]
        public IActionResult GetGame1Dashboard(int IdGame, int UID)
        {
            try
            {

                var TotalGameCoins = (from l in DbContext.TblGame1UserLog
                                      where l.IdGame == IdGame
                                       && l.IdUser == UID
                                       && l.IsCompleted == 1
                                      select new
                                      {
                                          l.IdUser,
                                          l.RewardCoins,
                                          l.GameCoins,
                                          l.GoldCoins

                                      }).GroupBy(x => new { x.IdUser }).Select(g => new
                                      {
                                          IdUser = g.Key.IdUser,
                                          RewardCoins = g.Sum(s => s.RewardCoins),
                                          GameCoins = g.Sum(s => s.GameCoins),
                                          GoldCoins = g.Sum(s => s.GoldCoins)
                                      }).FirstOrDefault();


                decimal Behaviour_Score = (from l in DbContext.TblGame1UserLog

                                           where l.IdGame == IdGame
                                               && l.IdUser == UID

                                           select new
                                           {
                                               l.IdUser,
                                               l.BehaviorScore

                                           }).GroupBy(x => new { x.IdUser }).Select(g => new
                                           {
                                               IdUser = g.Key.IdUser,
                                               BehaviorScore = g.Sum(s => s.BehaviorScore)
                                           }).Select(x => x.BehaviorScore ?? 0).FirstOrDefault();

                if (TotalGameCoins != null)
                {
                    DashboardModel Data = new DashboardModel();
                    Data.Behaviour_Score = Behaviour_Score;
                    Data.GoldCoins = TotalGameCoins.GoldCoins;
                    Data.RewardCoins = TotalGameCoins.RewardCoins;
                    Data.GameCoins = TotalGameCoins.GameCoins;
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

        // Developed by Raj Lakhwani
        [Route("~/api/GamePlayLog")]
        [HttpPost]
        public IActionResult GamePlayLog([FromBody] TblPlayLog ReqData)
        {
            try
            {
                bool isExist = false;
                //isExist = DbContext.TblPlayLog.Where(x => x.IdUser == ReqData.IdUser && x.AttemptNo == ReqData.AttemptNo && x.IdLevel == ReqData.IdLevel).Any();

                if (!isExist)
                {
                    ReqData.PlayDateTime = DateTime.UtcNow;

                    DbContext.TblPlayLog.Add(ReqData);
                    DbContext.SaveChanges();
                    string Data = JsonSerializer.Serialize(ReqData);
                    string Result = ency.getEncryptedString(Data);
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Duplicate attempt");
                }

            }
            catch (Exception ex)
            {
                return Conflict("Error in Code");
            }
        }

        // Developed by Raj Lakhwani
        [Route("~/api/Game1CorrectTilesLog")]
        [HttpPost]
        public IActionResult Game1CorrectTilesLog([FromBody] List<TblGame1CorrectTiles> ReqData)
        {
            try
            {
                bool isExist = false;
                foreach (var data in ReqData)
                {
                    isExist = DbContext.TblGame1CorrectTiles.Where(x => x.GameName == data.GameName && x.IdUser == data.IdUser && x.AttemptNo == data.AttemptNo && x.IdLevel == data.IdLevel && x.TileNo == data.TileNo).Any();

                    if (!isExist)
                    {
                        data.UpdatedDateTime = DateTime.UtcNow;

                        DbContext.TblGame1CorrectTiles.Add(data);
                        DbContext.SaveChanges();
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
        [Route("~/api/Game5ClickLog")]
        [HttpPost]
        public IActionResult Game5ClickLog([FromBody] List<TblGame5ClickLog> ReqData)
        {
            try
            {
                bool isExist = false;
                foreach (var data in ReqData)
                {
                    isExist = DbContext.TblGame5ClickLog.Where(x => x.GameName == data.GameName && x.IdUser == data.IdUser && x.AttemptNo == data.AttemptNo && x.IdLevel == data.IdLevel && x.InteractableName == data.InteractableName && x.SequenceNo == data.SequenceNo).Any();

                    if (!isExist)
                    {
                        data.UpdatedDateTime = DateTime.UtcNow;

                        DbContext.TblGame5ClickLog.Add(data);
                        DbContext.SaveChanges();
                        string Data = JsonSerializer.Serialize(ReqData);
                        string Result = ency.getEncryptedString(Data);

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
        [Route("~/api/Game2BlockAccuracyLog")]
        [HttpPost]
        public IActionResult Game2BlockAccuracyLog([FromBody] List<TblGame2BlockAccuracy> ReqData)
        {
            try
            {
                bool isExist = false;
                foreach (var data in ReqData)
                {
                    isExist = DbContext.TblGame2BlockAccuracy.Where(x => x.GameName == data.GameName && x.IdUser == data.IdUser && x.AttemptNo == data.AttemptNo && x.IdLevel == data.IdLevel && x.BlockNo == data.BlockNo).Any();

                    if (!isExist)
                    {
                        data.UpdatedDateTime = DateTime.UtcNow;

                        DbContext.TblGame2BlockAccuracy.Add(data);
                        DbContext.SaveChanges();
                        string Data = JsonSerializer.Serialize(ReqData);
                        string Result = ency.getEncryptedString(Data);

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

    }
}