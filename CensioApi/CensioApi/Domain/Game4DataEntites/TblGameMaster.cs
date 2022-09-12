using System;
using System.Collections.Generic;

namespace Domain.Game4DataEntites
{
    public partial class TblGameMaster
    {
        public int IdGame { get; set; }
        public string GameName { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
