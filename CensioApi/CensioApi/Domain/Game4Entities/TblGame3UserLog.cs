using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGame3UserLog
    {
        public int Game3UserLog { get; set; }
        public int? IdUser { get; set; }
        public int? IdGame { get; set; }
        public int? IdLevel { get; set; }
        public int? IdSubliminalMeasurement1 { get; set; }
        public int? IdSubliminalMeasurement2 { get; set; }
        public int? IdBehavior { get; set; }
        public decimal? BehaviorScore { get; set; }
        public int? SpecialPoints { get; set; }
        public int? Score { get; set; }
        public int? LinesEliminated { get; set; }
        public int? TimetakenToComplete { get; set; }
        public int AttemptNo { get; set; }
        public int? IsCompleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? IdOrganization { get; set; }
    }
}
