using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class GameAttemptdataModel
    {
        public int IdAttempt { get; set; }
        public int IdLevel { get; set; }
        public int? AttemptNo { get; set; }
        public int IdGame { get; set; }
        public int GoldCoins { get; set; }
        public int? IdBehavior { get; set; }
        public decimal? BehaviorScore { get; set; }
        public int? TimeInSecond { get; set; }
        public int? ChallengeCompletedTime1 { get; set; }
        public int? RewardCoinsTime1 { get; set; }
        public int? ChallengeCompletedTime2 { get; set; }
        public int? RewardCoinsTime2 { get; set; }
        public string FailAttemptMessage { get; set; }
        public string SuccessAttemptMessage { get; set; }
        public int? IdOrganization { get; set; }
        public string IsActive { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }

        public string GameName { get; set; }
        public IEnumerable<SelectListItem> GameList
        {
            get; set;

        }

        public string ChallengeName { get; set; }
        public IEnumerable<SelectListItem> ChallengeNameList
        {
            get; set;

        }

        public string BehaviorElement { get; set; }
        public IEnumerable<SelectListItem> BehaviorElementNameList
        {
            get; set;

        }
        public List<Behavior> BehaviorList { get; set; }
        public string Game5Behaviors { get; set; }
        public int idbehavior { get; set; }

        public class Behavior
        {
            public int idbehavior { get; set; }
        }
    }
}
