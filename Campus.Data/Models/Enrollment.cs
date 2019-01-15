using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("Enrollment")]
    [DebuggerDisplay("EnrollmentID={EnrollmentID}, PersonID={PersonID}")]
    public class Enrollment
    {
        [Column("enrollmentID")]
        [Key]
        public int EnrollmentID { get; set; }

        [Column("personID")]
        [ForeignKey("Person")]
        public int PersonID { get; set; }

        [Column("calendarID")]
        public int CalendarID { get; set; }

        [Column("employmentGUID")]
        public Guid EmploymentGUID { get; set; }

        public virtual Person Person { get; set; }

        public virtual Calendar Calendar { get; set; }
    }
}
