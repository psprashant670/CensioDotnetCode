using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame5ClickLog
    {
        public int IdClickLog { get; set; }
        public string GameName { get; set; }
        public int? IdUser { get; set; }
        public int? IdLevel { get; set; }
        public int? AttemptNo { get; set; }
        public string InteractableName { get; set; }
        public int? SequenceNo { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
