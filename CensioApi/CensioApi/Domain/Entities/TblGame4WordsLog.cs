using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame4WordsLog
    {
        public int IdWordsMade { get; set; }
        public int IdGame { get; set; }
        public int? IdUserlog { get; set; }
        public int? IdLevel { get; set; }
        public int? IdUser { get; set; }
        public string WordSelected { get; set; }
        public string WordMadeDetail { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
