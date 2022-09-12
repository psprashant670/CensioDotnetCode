using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGameAttemptdata
    {
        public int IdAttempt { get; set; }
        public int IdLevel { get; set; }
        public int? AttemptNo { get; set; }
        public int IdGame { get; set; }
        public int GoldCoins { get; set; }
        public int? IdBehavior { get; set; }
        public string Game5Behaviors { get; set; }
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
    }
}
