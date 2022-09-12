using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3Levels
    {
        public int IdLevelLog { get; set; }
        public int? IdLevel { get; set; }
        public int? IdOrganization { get; set; }
        public int? IdGame { get; set; }
        public string GameName { get; set; }
        public string LevelName { get; set; }
        public int? LevelSequence { get; set; }
        public int? LevelClearenceAmount { get; set; }
        public string LevelClearenceCurrency { get; set; }
        public string LevelImagepath { get; set; }
        public string MessageLevelSuccess { get; set; }
        public string Status { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
