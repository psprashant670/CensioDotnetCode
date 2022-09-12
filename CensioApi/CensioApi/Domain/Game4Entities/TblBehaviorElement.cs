using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblBehaviorElement
    {
        public int IdBehavior { get; set; }
        public string BehaviorElement { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
