using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class QuestionsModel
    {
        public int IdQuestion { get; set; }
        public int? IdOrganization { get; set; }
        public int? IdGame { get; set; }
        public string QuestionType { get; set; }
        public int? IdQuestionSequence { get; set; }
        public string IdQuestionText { get; set; }
        public string IdQuestionImagepath { get; set; }
        public string RangeStartDescription { get; set; }
        public string RangeEndDescription { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
