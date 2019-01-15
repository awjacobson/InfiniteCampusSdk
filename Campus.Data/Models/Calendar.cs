using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("Calendar")]
    [DebuggerDisplay("CalendarID={CalendarID}, EndYear={EndYear}")]
    public class Calendar
    {
        [Column("calendarID")]
        [Key]
        public int CalendarID { get; set; }

        [Column("districtID")]
        public int DistrictID { get; set; }

        [Column("schoolID")]
        public int SchoolID { get; set; }

        [Column("endYear")]
        public short EndYear { get; set; }

        [Column("name")]
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
