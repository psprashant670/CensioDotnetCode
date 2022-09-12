using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class Game4InstructionsModel
    {
        public int IdInstruction { get; set; }
        public int IdGame { get; set; }
        public int? IdLevel { get; set; }
        public string LevelName { get; set; }
        public int? IdInstructionNo { get; set; }
        public string InstructionDetail { get; set; }
        public string InstructionStatus { get; set; }
        public string InstructionImage { get; set; }
        public DateTime? UpdateDatetime { get; set; }

        public IEnumerable<SelectListItem> LevelList
        {
            get; set;

        }

    }
}
