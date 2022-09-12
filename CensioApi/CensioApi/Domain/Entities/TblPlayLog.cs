using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblPlayLog
    {
        public int IdPlayLog { get; set; }
        public string GameName { get; set; }
        public int? IdUser { get; set; }
        public DateTime? PlayDateTime { get; set; }
    }
}
