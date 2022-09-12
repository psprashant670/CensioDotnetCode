using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3Festivals
    {
        public int IdFestivalLog { get; set; }
        public int? IdFestival { get; set; }
        public int? IdOrganization { get; set; }
        public int? IdGame { get; set; }
        public string GameName { get; set; }
        public int? FestivalSequence { get; set; }
        public string FestivalName { get; set; }
        public string FestivalImagepath { get; set; }
        public string RawMaterial { get; set; }
        public int? RawMaterialExactqty { get; set; }
        public int? RawMaterialMinQtyPast { get; set; }
        public int? RawMaterialMinQtyFuture { get; set; }
        public string ScoreAbsoluteCalculated { get; set; }
        public decimal? PrimaryMaterialScore { get; set; }
        public decimal? SecondaryMaterialScorePositive { get; set; }
        public decimal? SecondaryMaterialScoreNegative { get; set; }
        public string RawMaterialImagepath { get; set; }
        public string MessageMaxQtySuccess { get; set; }
        public string MessageMaxQtyFail { get; set; }
        public string MessageMinQtySuccess { get; set; }
        public string MessageMinQtyFail { get; set; }
        public string MessageFestivalSuccess { get; set; }
        public string MessageFestivalFail { get; set; }
        public int? TimeRequiredSeconds { get; set; }
        public string Status { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
