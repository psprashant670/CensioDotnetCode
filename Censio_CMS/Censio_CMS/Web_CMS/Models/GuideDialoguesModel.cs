using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class GuideDialoguesModel
    {
        public int IdGuideDialogues { get; set; }
        public int IdGame { get; set; }
        public int? IdLevel { get; set; }
        public string GuideDialogue { get; set; }
        public string GuideIntroMessage { get; set; }
        public int? TypeDialogue { get; set; }
        public string TypeDialogueName { get; set; }
        public int? Sequence { get; set; }
        public int? IdOrganization { get; set; }
        public string IsActive { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }

        public string GameName { get; set; }
        public IEnumerable<SelectListItem> GameNameList
        {
            get; set;

        }
    }
}
