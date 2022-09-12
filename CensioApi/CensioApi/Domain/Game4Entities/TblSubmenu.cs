using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblSubmenu
    {
        public int SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int? MainMenuId { get; set; }
        public string IdCmsRole { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? Sequence { get; set; }

        public virtual TblMainmenu MainMenu { get; set; }
    }
}
