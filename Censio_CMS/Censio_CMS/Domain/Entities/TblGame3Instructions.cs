using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame3Instructions
    {
        public int IdGameInstructionLog { get; set; }
        public int? IdInstruction { get; set; }
        public int? IdGame { get; set; }
        public int? IdOrganization { get; set; }
        public string FestivalName { get; set; }
        public string InstructionPostion { get; set; }
        public int? InstructionSequence { get; set; }
        public string InstructionText { get; set; }
        public string InstructionImagepath { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
