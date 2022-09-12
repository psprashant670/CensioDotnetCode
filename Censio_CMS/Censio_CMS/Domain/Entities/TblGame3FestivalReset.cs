using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3FestivalReset
    {
        public int IdFestivalResetLog { get; set; }
        public int? IdGame { get; set; }
        public int? IdFestival { get; set; }
        public string FestivalName { get; set; }
        public string PastFestivalReset { get; set; }
        public string FutureFestivalReset { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
