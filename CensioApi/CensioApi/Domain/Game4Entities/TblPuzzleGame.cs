using System;
using System.Collections.Generic;

namespace Domain.Game4Data
{
    public partial class TblPuzzleGame
    {
        public int IdPuzzle { get; set; }
        public int? IdLevel { get; set; }
        public string RowColumn { get; set; }
        public string Images { get; set; }
        public int AnswerSequence { get; set; }
        public int Coins { get; set; }
        public int? IdOrganization { get; set; }
        public string IsActive { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int? IdCmsUser { get; set; }
    }
}
