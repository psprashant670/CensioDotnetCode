using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblGame
    {
        public int Id { get; set; }
        public int IdGame { get; set; }
        public string GameName { get; set; }
        public string MapImgUrl { get; set; }
        public int? AccuracyLimit { get; set; }
        public int? IdOrganization { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
