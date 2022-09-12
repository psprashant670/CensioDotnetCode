using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGameUserAttemptPurchaseLog
    {
        public int GameAttemptPurchaseLog { get; set; }
        public int? IdUser { get; set; }
        public int? IdGame { get; set; }
        public int? IdLevel { get; set; }
        public int? Coins { get; set; }
        public int AttemptNo { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? IdOrganization { get; set; }
    }
}
