using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class Game4WordMaster
    {
        public int IdLevelWord { get; set; }
        public int IdGame { get; set; }
        public int? IdLevelMaster { get; set; }
        public string LevelName { get; set; }
        public int? IdWordNo { get; set; }
        public string IdWordDetail { get; set; }
        public string IdWordStatus { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public IEnumerable<SelectListItem> LevelList
        {
            get; set;

        }
    }
}
