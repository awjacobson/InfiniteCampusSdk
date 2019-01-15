using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("SurveyQuestionAnswer")]
    [DebuggerDisplay("AnswerID={AnswerID}, Value={Value}")]
    public class SurveyQuestionAnswer
    {
        [Column("answerID")]
        [Key]
        public int AnswerID { get; set; }

        [Column("surveyID")]
        public int SurveyID { get; set; }

        [Column("pageID")]
        public int PageID { get; set; }

        [Column("questionID")]
        public int QuestionID { get; set; }

        [Column("sequence")]
        public short Sequence { get; set; }

        [Column("value")]
        [Required]
        [StringLength(50)]
        public string Value { get; set; }
    }
}
