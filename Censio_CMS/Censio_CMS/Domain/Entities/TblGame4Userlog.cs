using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame4Userlog
    {
        public int IdUserlog { get; set; }
        public int IdGame { get; set; }
        public int? IdLevelMasterid { get; set; }
        public int? IdUser { get; set; }
        public string WordSelected { get; set; }
        public int? CountofWordsMade { get; set; }
        public int? BonusPoint { get; set; }
        public int? TimeTaken { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
