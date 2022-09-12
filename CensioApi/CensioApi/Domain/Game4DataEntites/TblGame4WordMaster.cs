using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblGame4WordMaster
    {
        public int IdLevelWord { get; set; }
        public int IdGame { get; set; }
        public int? IdLevelMaster { get; set; }
        public int? IdWordNo { get; set; }
        public string IdWordDetail { get; set; }
        public string IdWordStatus { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
