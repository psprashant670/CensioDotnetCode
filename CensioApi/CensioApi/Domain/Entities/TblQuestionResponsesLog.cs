using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TblQuestionResponsesLog
    {
        public int IdResponseLog { get; set; }
        public int? IdUser { get; set; }
        public int? IdQuestion { get; set; }
        public int? IdResponse { get; set; }
        public int? IdResponseGroup { get; set; }
        public int? ReponseOptionNo { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
