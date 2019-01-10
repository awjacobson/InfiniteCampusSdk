using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Data.Models
{
    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            CustomStudents = new HashSet<CustomStudent>();
            Identities = new HashSet<Identity>();
        }

        public int personID { get; set; }

        public int? currentIdentityID { get; set; }

        [StringLength(15)]
        public string stateID { get; set; }

        [StringLength(15)]
        public string studentNumber { get; set; }

        [StringLength(15)]
        public string staffNumber { get; set; }

        public Guid personGUID { get; set; }

        [StringLength(64)]
        public string legacyKey { get; set; }

        [StringLength(15)]
        public string otherID { get; set; }

        [StringLength(20)]
        public string staffStateID { get; set; }

        [StringLength(20)]
        public string geographicStaffStateID { get; set; }

        public int modifiedByID { get; set; }

        [StringLength(20)]
        public string comments { get; set; }

        [StringLength(25)]
        public string additionalID { get; set; }

        [StringLength(20)]
        public string edFiID { get; set; }

        public virtual Contact Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomStudent> CustomStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Identity> Identities { get; set; }

        public virtual Identity Identity { get; set; }
    }
}
