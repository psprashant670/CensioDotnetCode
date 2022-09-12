using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblMainmenu
    {
        public TblMainmenu()
        {
            TblSubmenu = new HashSet<TblSubmenu>();
        }

        public int MainMenuId { get; set; }
        public string MainMenuName { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? Sequence { get; set; }
        public string IdCmsRole { get; set; }

        public virtual ICollection<TblSubmenu> TblSubmenu { get; set; }
    }
}
