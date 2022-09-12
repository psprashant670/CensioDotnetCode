using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public int IdGame { get; set; }
        public string GameName { get; set; }
        public string MapImgUrl { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
        public IEnumerable<SelectListItem> GameList
        {
            get; set;

        }
    }
}
