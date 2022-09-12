using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Game3LogModel
    {
        // Tbl_Game3_User_Log
        public int? IdUser { get; set; }
        public int? IdOrganization { get; set; }
        public int? IdGame { get; set; }
        public int? IdFestival { get; set; }
        public string FestivalName { get; set; }
        public int? LifeNo { get; set; }
        public string RawMaterial { get; set; }
        public int? FestivalRawMatPresented { get; set; }
        public int? FestivalRawMatSelected { get; set; }
        public int? FestivalScore { get; set; }
        public int? FestivalSuccess { get; set; }
        public string SecondaryFestivalName1 { get; set; }
        public string SecondaryFestivalType1 { get; set; }
        public int? SecondaryRawMatPresented1 { get; set; }
        public int? SecondaryRawMatSelected1 { get; set; }
        public int? SecondaryScore1 { get; set; }
        public int? SecondarySuccess1 { get; set; }
        public string SecondaryFestivalName2 { get; set; }
        public string SecondaryFestivalType2 { get; set; }
        public int? SecondaryRawMatPresented2 { get; set; }
        public int? SecondaryRawMatSelected2 { get; set; }
        public int? SecondaryScore2 { get; set; }
        public int? SecondarySuccess2 { get; set; }
        public string SecondaryFestivalName3 { get; set; }
        public string SecondaryFestivalType3 { get; set; }
        public int? SecondaryRawMatPresented3 { get; set; }
        public int? SecondaryRawMatSelected3 { get; set; }
        public int? SecondaryScore3 { get; set; }
        public int? SecondarySuccess3 { get; set; }
        public int? TimeTaken { get; set; }
        public int? FestivalExcessAmountCollected { get; set; }
        public int? LevelFestivalAmount { get; set; }
        public string LevelName { get; set; }
        //public DateTime? UpdatedDateTime { get; set; }

        // Tbl_Game3_Level_Log
        //public int? IdUser { get; set; }
        public int? StartIdLevel { get; set; }
        public string StartLevelName { get; set; }
        public int? EndIdLevel { get; set; }
        public string EndLevelName { get; set; }
        //public string FestivalName { get; set; }
        public int? FestivalLevelScore { get; set; }
        public int? LevelStartScore { get; set; }
        public int? LevelEndScore { get; set; }
        public int? LevelCumulativeScore { get; set; }
        //public DateTime? UpdatedDateTime { get; set; }

        
    }
}
