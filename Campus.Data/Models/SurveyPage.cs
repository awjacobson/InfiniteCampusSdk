using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("SurveyPage")]
    [DebuggerDisplay("PageID={PageID}")]
    public class SurveyPage
    {
        [Column("pageID")]
        [Key]
        public int PageID { get; set; }

        [Column("surveyID")]
        public int SurveyID { get; set; }

        [Column("name")]
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Column("sequence")]
        public short Sequence { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
