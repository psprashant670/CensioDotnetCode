using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class SubliminalMeasurement2Model
    {
        public int IdSubliminalMeasurement2 { get; set; }
        public int? IdGame { get; set; }
        public int IdBehavior { get; set; }
        public string SubliminalMeasurement2Name { get; set; }
        public int BehaviorScore { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
        public string GameName { get; set; }
        public IEnumerable<SelectListItem> GameList
        {
            get; set;

        }
        public string BehaviorElement { get; set; }
        public IEnumerable<SelectListItem> BehaviorElementNameList
        {
            get; set;

        }

        public string GameFeedbackMsg { get; set; }
        public int IdLevel { get; set; }
        public string ChallengeName { get; set; }
        public IEnumerable<SelectListItem> ChallengeNameList
        {
            get; set;

        }
    }
}
