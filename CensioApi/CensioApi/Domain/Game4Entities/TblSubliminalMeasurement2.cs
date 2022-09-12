using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblSubliminalMeasurement2
    {
        public int IdSubliminalMeasurement2 { get; set; }
        public int? IdGame { get; set; }
        public int? IdLevel { get; set; }
        public int IdBehavior { get; set; }
        public string SubliminalMeasurement2Name { get; set; }
        public int BehaviorScore { get; set; }
        public string GameFeedbackMsg { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
