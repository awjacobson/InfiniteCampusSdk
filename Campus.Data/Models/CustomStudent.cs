using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("CustomStudent")]
    [DebuggerDisplay("CustomID={CustomID}, PersonID={PersonID}")]
    public class CustomStudent
    {
        [Column("customID")]
        [Key]
        public int CustomID { get; set; }

        [Column("personID")]
        [ForeignKey("Person")]
        public int PersonID { get; set; }

        [Column("enrollmentID")]
        public int? EnrollmentID { get; set; }

        [Column("attributeID")]
        [ForeignKey("CampusAttribute")]
        public int AttributeID { get; set; }

        [Column("value")]
        [StringLength(256)]
        public string Value { get; set; }

        [Column("date", TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [Column("customGUID")]
        public Guid CustomGUID { get; set; }

        [Column("districtID")]
        public int? DistrictID { get; set; }

        public virtual CampusAttribute CampusAttribute { get; set; }

        public virtual Person Person { get; set; }
    }
}
