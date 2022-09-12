using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblGame4LevelInstructions
    {
        public int IdInstruction { get; set; }
        public int IdGame { get; set; }
        public int? IdLevel { get; set; }
        public int? IdInstructionNo { get; set; }
        public string InstructionDetail { get; set; }
        public string InstructionStatus { get; set; }
        public string InstructionImage { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
