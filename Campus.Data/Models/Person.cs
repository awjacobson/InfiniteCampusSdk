using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("Person")]
    [DebuggerDisplay("PersonID={PersonID}, StateID={StateID}")]
    public class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            CustomStudents = new HashSet<CustomStudent>();
            Identities = new HashSet<Identity>();
        }

        [Column("personID")]
        public int PersonID { get; set; }

        [Column("currentIdentityID")]
        public int? CurrentIdentityID { get; set; }

        [Column("stateID")]
        [StringLength(15)]
        public string StateID { get; set; }

        [Column("studentNumber")]
        [StringLength(15)]
        public string StudentNumber { get; set; }

        [Column("staffNumber")]
        [StringLength(15)]
        public string StaffNumber { get; set; }

        [Column("personGUID")]
        public Guid PersonGUID { get; set; }

        [Column("legacyKey")]
        [StringLength(64)]
        public string LegacyKey { get; set; }

        [Column("otherID")]
        [StringLength(15)]
        public string OtherID { get; set; }

        [Column("staffStateID")]
        [StringLength(20)]
        public string StaffStateID { get; set; }

        [Column("geographicStaffStateID")]
        [StringLength(20)]
        public string GeographicStaffStateID { get; set; }

        [Column("modifiedByID")]
        public int ModifiedByID { get; set; }

        [Column("comments")]
        [StringLength(20)]
        public string Comments { get; set; }

        [Column("additionalID")]
        [StringLength(25)]
        public string AdditionalID { get; set; }

        [Column("edFiID")]
        [StringLength(20)]
        public string EdFiID { get; set; }

        public virtual Contact Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomStudent> CustomStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Identity> Identities { get; set; }

        public virtual Identity Identity { get; set; }
    }
}
