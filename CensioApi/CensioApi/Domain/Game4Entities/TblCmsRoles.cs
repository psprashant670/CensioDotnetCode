using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblCmsRoles
    {
        public int IdCmsRole { get; set; }
        public int IdOrganization { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
