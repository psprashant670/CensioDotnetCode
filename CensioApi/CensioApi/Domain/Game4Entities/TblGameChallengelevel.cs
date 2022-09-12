using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGameChallengelevel
    {
        public int IdLevel { get; set; }
        public int IdGame { get; set; }
        public string ChallengeName { get; set; }
        public string NotBackingOutMsg { get; set; }
        public string ChallengeSmallImgUrl { get; set; }
        public string ChallengeBigImgUrl { get; set; }
        public string BigImgText { get; set; }
        public string ChallengeIntroMessage { get; set; }
        public string BottomCompleteMessage { get; set; }
        public string BottomFailMessage { get; set; }
        public string ChallengePieceMapImgUrl { get; set; }
        public string ChallengePieceMapMsg { get; set; }
        public int? AgainPlayCoins { get; set; }
        public int AttemptsAllowed { get; set; }
        public int? AttemptTimer { get; set; }
        public int? ThirdGameScore { get; set; }
        public int? SpecialPoint { get; set; }
        public int? SuperpowerCoinGame3 { get; set; }
        public int? IdOrganization { get; set; }
        public string IsActive { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
