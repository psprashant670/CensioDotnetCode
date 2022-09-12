using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblGame4LevelMaster
    {
        public int IdLevel { get; set; }
        public int IdGame { get; set; }
        public string LevelName { get; set; }
        public int? LevelWordcount { get; set; }
        public int? LevelTimerequired { get; set; }
        public int? LevelBonuspts { get; set; }
        public string IdLevelStatus { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
