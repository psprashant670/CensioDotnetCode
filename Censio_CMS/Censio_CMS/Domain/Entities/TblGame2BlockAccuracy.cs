using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame2BlockAccuracy
    {
        public int IdBlock { get; set; }
        public string GameName { get; set; }
        public int? IdUser { get; set; }
        public int? IdLevel { get; set; }
        public int? AttemptNo { get; set; }
        public int? BlockNo { get; set; }
        public decimal? AccuracyLevel { get; set; }
        public int? IsCorrect { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
