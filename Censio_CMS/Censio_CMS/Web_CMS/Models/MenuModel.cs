using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class MenuModel
    {
        public string MainMenuName { get; set; }
        public int MainMenuId { get; set; }
        public string SubMenuName { get; set; }
        public int? SubMenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public int? sequence { get; set; }
        public int? Sequence { get; set; }
        public string MainControllerName { get; set; }
        public string MainActionName { get; set; }
        public string MainRoleId { get; set; }
        public string Status { get; set; }
    }
}
