using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3RawMaterialLog
    {
        public int IdGame3RawMaterialLog { get; set; }
        public int? IdUser { get; set; }
        public int? LifeNo { get; set; }
        public string FestivalName { get; set; }
        public string RawMaterial { get; set; }
        public string RawMaterialType { get; set; }
        public int? RawMaterialTileNo { get; set; }
        public string RawMaterialSelected { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
