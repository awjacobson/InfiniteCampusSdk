using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("SurveyQuestion")]
    [DebuggerDisplay("QuestionID={QuestionID}, Description={Description}")]
    public class SurveyQuestion
    {
        [Column("questionID")]
        [Key]
        public int QuestionID { get; set; }

        [Column("surveyID")]
        public int SurveyID { get; set; }

        [Column("pageID")]
        public int PageID { get; set; }

        [Column("sequence")]
        public short Sequence { get; set; }

        [Column("dataType")]
        [Required]
        [StringLength(50)]
        public string DataType { get; set; }

        [Column("description")]
        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Column("allowsOther")]
        public bool? AllowsOther { get; set; }

        [Column("required")]
        public bool? Required { get; set; }

        [Column("alignment")]
        [StringLength(10)]
        public string Alignment { get; set; }
    }
}
