using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Campus.Data.Models
{
    [Table("Identity")]
    public class Identity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Identity()
        {
            People = new HashSet<Person>();
        }

        [Column("identityID")]
        public int IdentityID { get; set; }

        public int personID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? effectiveDate { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string middleName { get; set; }

        [StringLength(50)]
        public string suffix { get; set; }

        [StringLength(50)]
        public string alias { get; set; }

        [StringLength(1)]
        public string gender { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? birthdate { get; set; }

        [StringLength(9)]
        public string ssn { get; set; }

        [StringLength(3)]
        public string raceEthnicity { get; set; }

        [StringLength(4)]
        public string birthCountry { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dateEnteredUS { get; set; }

        [StringLength(4)]
        public string birthVerification { get; set; }

        [StringLength(255)]
        public string comments { get; set; }

        public int districtID { get; set; }

        [StringLength(2)]
        public string hispanicEthnicity { get; set; }

        public Guid? identityGUID { get; set; }

        [StringLength(10)]
        public string lastNamePhonetic { get; set; }

        [StringLength(10)]
        public string firstNamePhonetic { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dateEnteredState { get; set; }

        [StringLength(12)]
        public string birthCertificate { get; set; }

        [StringLength(1)]
        public string raceEthnicityFed { get; set; }

        [StringLength(2)]
        public string raceEthnicityDetermination { get; set; }

        [StringLength(2)]
        public string immigrant { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dateEnteredUSSchool { get; set; }

        [StringLength(2)]
        public string birthStateNoSIF { get; set; }

        [StringLength(30)]
        public string birthCity { get; set; }

        [StringLength(30)]
        public string birthCounty { get; set; }

        [StringLength(4)]
        public string birthVerificationBIE { get; set; }

        public int? modifiedByID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? modifiedDate { get; set; }

        [StringLength(2)]
        public string refugee { get; set; }

        [StringLength(5)]
        public string homePrimaryLanguage { get; set; }

        [StringLength(2)]
        public string stateHispanicEthnicity { get; set; }

        [StringLength(10)]
        public string birthState { get; set; }

        [StringLength(5)]
        public string homePrimaryLanguageBIE { get; set; }

        [StringLength(5)]
        public string homeSecondaryLanguageBIE { get; set; }

        [StringLength(5)]
        public string languageAlt { get; set; }

        [StringLength(5)]
        public string languageAlt2 { get; set; }

        public bool foreignLanguageProficiency { get; set; }

        public bool literacyLanguage { get; set; }

        [StringLength(50)]
        public string legalFirstName { get; set; }

        [StringLength(50)]
        public string legalLastName { get; set; }

        [StringLength(50)]
        public string legalMiddleName { get; set; }

        [StringLength(50)]
        public string legalSuffix { get; set; }

        [StringLength(1)]
        public string legalGender { get; set; }

        [StringLength(2)]
        public string usCitizen { get; set; }

        [StringLength(5)]
        public string visaType { get; set; }

        [StringLength(4)]
        public string originCountry { get; set; }

        [StringLength(50)]
        public string hispanicWriteIn { get; set; }

        [StringLength(50)]
        public string asianWriteIn { get; set; }

        [StringLength(50)]
        public string caribbeanWriteIn { get; set; }

        [StringLength(50)]
        public string centralAfricanWriteIn { get; set; }

        [StringLength(50)]
        public string eastAfricanWriteIn { get; set; }

        [StringLength(50)]
        public string latinAmericanWriteIn { get; set; }

        [StringLength(50)]
        public string southAfricanWriteIn { get; set; }

        [StringLength(50)]
        public string westAfricanWriteIn { get; set; }

        [StringLength(50)]
        public string blackWriteIn { get; set; }

        [StringLength(50)]
        public string alaskaNativeWriteIn { get; set; }

        [StringLength(50)]
        public string americanIndianWriteIn { get; set; }

        [StringLength(50)]
        public string pacificIslanderWriteIn { get; set; }

        [StringLength(50)]
        public string easternEuropeanWriteIn { get; set; }

        [StringLength(50)]
        public string middleEasternWriteIn { get; set; }

        [StringLength(50)]
        public string northAfricanWriteIn { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }
}
