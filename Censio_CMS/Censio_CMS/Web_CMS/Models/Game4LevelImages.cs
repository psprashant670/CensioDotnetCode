using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class Game4LevelImages
    {
        public int IdLevelImage { get; set; }
        public int? IdLevel { get; set; }
        public string LevelName { get; set; }
        public int IdGame { get; set; }
        public string IdImage { get; set; }

        public IEnumerable<SelectListItem> LevelList
        {
            get; set;

        }
    }
}
