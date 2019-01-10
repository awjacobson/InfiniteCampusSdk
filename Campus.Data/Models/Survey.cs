using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Campus.Data.Models
{
    [Table("Survey")]
    public class Survey
    {
        [Column("surveyID")]
        [Key]
        public int SurveyID { get; set; }

        [Column("userID")]
        public int UserID { get; set; }

        [Column("groupID")]
        public int? GroupID { get; set; }

        [Column("name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("anonymous")]
        public bool? Anonymous { get; set; }

        [Column("multiResponse")]
        public bool? MultiResponse { get; set; }

        [Column("startTimestamp")]
        public DateTime StartTimestamp { get; set; }

        [Column("endTimestamp")]
        public DateTime EndTimestamp { get; set; }

        [Column("enabled")]
        public bool? Enabled { get; set; }

        [Column("introduction")]
        public string Introduction { get; set; }

        [Column("conclusion")]
        public string Conclusion { get; set; }
    }
}
