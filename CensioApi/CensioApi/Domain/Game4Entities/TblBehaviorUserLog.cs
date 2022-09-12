using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblBehaviorUserLog
    {
        public int BehaviorUserLog { get; set; }
        public int? IdUser { get; set; }
        public int? IdGame { get; set; }
        public int? IdLevel { get; set; }
        public int? IdBehavior { get; set; }
        public decimal? BehaviorScore { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? IsCompleted { get; set; }
        public int? IdOrganization { get; set; }
    }
}
