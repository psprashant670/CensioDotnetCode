using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame4LevelImages
    {
        public int IdLevelImage { get; set; }
        public int? IdLevel { get; set; }
        public int IdGame { get; set; }
        public int? IdImage { get; set; }
    }
}
