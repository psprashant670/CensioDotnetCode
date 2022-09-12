using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblSubliminalMeasurement1
    {
        public int IdSubliminalMeasurement1 { get; set; }
        public int? IdGame { get; set; }
        public int IdBehavior { get; set; }
        public string SubliminalMeasurementName { get; set; }
        public int BehaviorScore { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
