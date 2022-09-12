using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class PuzzleGameModel
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

        public string ChallengeName { get; set; }
        public IEnumerable<SelectListItem> ChallengeNameList
        {
            get; set;

        }
    }
}
