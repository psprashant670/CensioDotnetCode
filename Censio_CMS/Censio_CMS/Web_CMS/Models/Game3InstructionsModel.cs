using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class Game3InstructionsModel
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

        public IEnumerable<SelectListItem> FestivalList
        {
            get; set;

        }
    }
}
