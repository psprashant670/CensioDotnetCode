using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Censio_CMS.Models
{
    public class QuestionResponsesModel
    {
        public int IdResponse { get; set; }
        public int? IdQuestion { get; set; }
        public string IdQuestionText { get; set; }
        public string QuestionType { get; set; }
        public int? IdResponseGroup { get; set; }
        public int? ReponseOptionNo { get; set; }
        public string ResponseOptionName { get; set; }
        public string ResponseOptionDescription { get; set; }
        public string AdditionInformation { get; set; }
        public string IdResponseImagepath { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
