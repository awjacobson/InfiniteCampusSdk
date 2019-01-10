using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Campus.Data.Models
{
    [Table("SurveyQuestionResponse")]
    public class SurveyQuestionResponse
    {
        [Column("questionResponseID")]
        [Key]
        public int QuestionResponseID { get; set; }

        [Column("surveyID")]
        public int SurveyID { get; set; }

        [Column("pageID")]
        public int PageID { get; set; }

        [Column("questionID")]
        public int QuestionID { get; set; }

        [Column("responseID")]
        public int ResponseID { get; set; }

        [Column("response")]
        [Required]
        [StringLength(50)]
        public string Response { get; set; }

        [Column("textResponse")]
        [StringLength(2000)]
        public string TextResponse { get; set; }

        public virtual SurveyResponse SurveyResponse { get; set; }
    }
}
