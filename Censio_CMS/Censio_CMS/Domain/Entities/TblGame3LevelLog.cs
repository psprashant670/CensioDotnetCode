using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3LevelLog
    {
        public int IdGame3LevelLog { get; set; }
        public int? IdUser { get; set; }
        public int? StartIdLevel { get; set; }
        public string StartLevelName { get; set; }
        public int? EndIdLevel { get; set; }
        public string EndLevelName { get; set; }
        public string FestivalName { get; set; }
        public int? FestivalLevelScore { get; set; }
        public int? LevelStartScore { get; set; }
        public int? LevelEndScore { get; set; }
        public int? LevelCumulativeScore { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
