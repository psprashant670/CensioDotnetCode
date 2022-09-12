using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGame4LevelMaster
    {
        public TblGame4LevelMaster()
        {
            TblGame4LevelInstructions = new HashSet<TblGame4LevelInstructions>();
            TblGame4Userlog = new HashSet<TblGame4Userlog>();
            TblGame4WordMaster = new HashSet<TblGame4WordMaster>();
        }

        public int IdLevel { get; set; }
        public int IdGame { get; set; }
        public string LevelName { get; set; }
        public int? LevelWordcount { get; set; }
        public int? LevelTimerequired { get; set; }
        public int? LevelBonuspts { get; set; }
        public string IdLevelStatus { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public virtual ICollection<TblGame4LevelInstructions> TblGame4LevelInstructions { get; set; }
        public virtual ICollection<TblGame4Userlog> TblGame4Userlog { get; set; }
        public virtual ICollection<TblGame4WordMaster> TblGame4WordMaster { get; set; }
    }
}
