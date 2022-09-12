using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGuideDialogues
    {
        public int IdGuideDialogues { get; set; }
        public int IdGame { get; set; }
        public string GuideDialogue { get; set; }
        public string GuideIntroMessage { get; set; }
        public int? TypeDialogue { get; set; }
        public string TypeDialogueName { get; set; }
        public int? Sequence { get; set; }
        public int? IdOrganization { get; set; }
        public string IsActive { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
