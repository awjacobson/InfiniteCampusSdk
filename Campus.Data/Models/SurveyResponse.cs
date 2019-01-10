using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("SurveyResponse")]
    [DebuggerDisplay("ResponseID={ResponseID}, SurveyID={SurveyID}, PersonID={PersonID}")]
    public class SurveyResponse
    {
        [Column("responseID")]
        [Key]
        public int ResponseID { get; set; }

        [Column("surveyID")]
        public int SurveyID { get; set; }

        [Column("personID")]
        public int? PersonID { get; set; }

        [Column("responseKey")]
        public int ResponseKey { get; set; }

        [Column("StartTimestamp")]
        public DateTime StartTimestamp { get; set; }

        [Column("EndTimestamp")]
        public DateTime? EndTimestamp { get; set; }

        [Column("Completed")]
        public bool? Completed { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
