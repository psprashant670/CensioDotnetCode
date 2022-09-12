using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class OrganizationModel
    {
        public int IdOrganization { get; set; }
        public string OrganizationName { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string ContactEmail { get; set; }
        public string DefaultEmail { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }

    }
}
