using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGame4Userlog
    {
        //public TblGame4Userlog()
        //{
        //    TblGame4WordsLog = new HashSet<TblGame4WordsLog>();
        //}

        public int IdUserlog { get; set; }
        public int IdGame { get; set; }
        public int? IdLevelMasterid { get; set; }
        public int? IdUser { get; set; }
        public string WordSelected { get; set; }
        public int? CountofWordsMade { get; set; }
        public int? BonusPoint { get; set; }
        public int? TimeTaken { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        //public virtual TblGame4LevelMaster IdLevelMaster { get; set; }
        //public virtual ICollection<TblGame4WordsLog> TblGame4WordsLog { get; set; }
    }
}
