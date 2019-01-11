using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("Identity")]
    [DebuggerDisplay("IdentityID={IdentityID}, PersonID={PersonID}")]
    public class Identity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Identity()
        {
            People = new HashSet<Person>();
        }

        [Column("identityID")]
        public int IdentityID { get; set; }

        [Column("personID")]
        public int PersonID { get; set; }

        [Column("effectiveDate", TypeName = "smalldatetime")]
        public DateTime? EffectiveDate { get; set; }

        [Column("lastName")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("firstName")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("middleName")]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Column("suffix")]
        [StringLength(50)]
        public string Suffix { get; set; }

        [Column("alias")]
        [StringLength(50)]
        public string Alias { get; set; }

        [Column("gender")]
        [StringLength(1)]
        public string Gender { get; set; }

        [Column("birthdate", TypeName = "smalldatetime")]
        public DateTime? Birthdate { get; set; }

        [Column("ssn")]
        [StringLength(9)]
        public string Ssn { get; set; }

        [Column("raceEthnicity")]
        [StringLength(3)]
        public string RaceEthnicity { get; set; }

        [Column("birthCountry")]
        [StringLength(4)]
        public string BirthCountry { get; set; }

        [Column("dateEnteredUS", TypeName = "smalldatetime")]
        public DateTime? DateEnteredUS { get; set; }

        [Column("birthVerification")]
        [StringLength(4)]
        public string BirthVerification { get; set; }

        [Column("comments")]
        [StringLength(255)]
        public string Comments { get; set; }

        [Column("districtID")]
        public int DistrictID { get; set; }

        [Column("hispanicEthnicity")]
        [StringLength(2)]
        public string HispanicEthnicity { get; set; }

        [Column("identityGUID")]
        public Guid? IdentityGUID { get; set; }

        [Column("lastNamePhonetic")]
        [StringLength(10)]
        public string LastNamePhonetic { get; set; }

        [Column("firstNamePhonetic")]
        [StringLength(10)]
        public string FirstNamePhonetic { get; set; }

        [Column("dateEnteredState", TypeName = "smalldatetime")]
        public DateTime? DateEnteredState { get; set; }

        [Column("birthCertificate")]
        [StringLength(12)]
        public string BirthCertificate { get; set; }

        [Column("raceEthnicityFed")]
        [StringLength(1)]
        public string RaceEthnicityFed { get; set; }

        [Column("raceEthnicityDetermination")]
        [StringLength(2)]
        public string RaceEthnicityDetermination { get; set; }

        [Column("immigrant")]
        [StringLength(2)]
        public string Immigrant { get; set; }

        [Column("dateEnteredUSSchool", TypeName = "smalldatetime")]
        public DateTime? dateEnteredUSSchool { get; set; }

        [Column("birthStateNoSIF")]
        [StringLength(2)]
        public string BirthStateNoSIF { get; set; }

        [Column("birthCity")]
        [StringLength(30)]
        public string BirthCity { get; set; }

        [Column("birthCounty")]
        [StringLength(30)]
        public string BirthCounty { get; set; }

        [Column("birthVerificationBIE")]
        [StringLength(4)]
        public string birthVerificationBIE { get; set; }

        [Column("modifiedByID")]
        public int? ModifiedByID { get; set; }

        [Column("modifiedDate", TypeName = "smalldatetime")]
        public DateTime? ModifiedDate { get; set; }

        [Column("refugee")]
        [StringLength(2)]
        public string Refugee { get; set; }

        [Column("homePrimaryLanguage")]
        [StringLength(5)]
        public string HomePrimaryLanguage { get; set; }

        [Column("stateHispanicEthnicity")]
        [StringLength(2)]
        public string StateHispanicEthnicity { get; set; }

        [Column("birthState")]
        [StringLength(10)]
        public string BirthState { get; set; }

        [Column("homePrimaryLanguageBIE")]
        [StringLength(5)]
        public string HomePrimaryLanguageBIE { get; set; }

        [Column("HomeSecondaryLanguageBIE")]
        [StringLength(5)]
        public string HomeSecondaryLanguageBIE { get; set; }

        [Column("languageAlt")]
        [StringLength(5)]
        public string LanguageAlt { get; set; }

        [Column("languageAlt2")]
        [StringLength(5)]
        public string LanguageAlt2 { get; set; }

        [Column("foreignLanguageProficiency")]
        public bool ForeignLanguageProficiency { get; set; }

        [Column("literacyLanguage")]
        public bool LiteracyLanguage { get; set; }

        [Column("legalFirstName")]
        [StringLength(50)]
        public string LegalFirstName { get; set; }

        [Column("legalLastName")]
        [StringLength(50)]
        public string LegalLastName { get; set; }

        [Column("legalMiddleName")]
        [StringLength(50)]
        public string LegalMiddleName { get; set; }

        [Column("LegalSuffix")]
        [StringLength(50)]
        public string legalSuffix { get; set; }

        [Column("legalGender")]
        [StringLength(1)]
        public string LegalGender { get; set; }

        [Column("usCitizen")]
        [StringLength(2)]
        public string UsCitizen { get; set; }

        [Column("visaType")]
        [StringLength(5)]
        public string VisaType { get; set; }

        [Column("originCountry")]
        [StringLength(4)]
        public string OriginCountry { get; set; }

        [Column("hispanicWriteIn")]
        [StringLength(50)]
        public string HispanicWriteIn { get; set; }

        [Column("asianWriteIn")]
        [StringLength(50)]
        public string AsianWriteIn { get; set; }

        [Column("caribbeanWriteIn")]
        [StringLength(50)]
        public string CaribbeanWriteIn { get; set; }

        [Column("centralAfricanWriteIn")]
        [StringLength(50)]
        public string CentralAfricanWriteIn { get; set; }

        [Column("eastAfricanWriteIn")]
        [StringLength(50)]
        public string EastAfricanWriteIn { get; set; }

        [Column("latinAmericanWriteIn")]
        [StringLength(50)]
        public string LatinAmericanWriteIn { get; set; }

        [Column("southAfricanWriteIn")]
        [StringLength(50)]
        public string SouthAfricanWriteIn { get; set; }

        [Column("westAfricanWriteIn")]
        [StringLength(50)]
        public string WestAfricanWriteIn { get; set; }

        [Column("blackWriteIn")]
        [StringLength(50)]
        public string BlackWriteIn { get; set; }

        [Column("alaskaNativeWriteIn")]
        [StringLength(50)]
        public string AlaskaNativeWriteIn { get; set; }

        [Column("americanIndianWriteIn")]
        [StringLength(50)]
        public string AmericanIndianWriteIn { get; set; }

        [Column("americanIndianWriteIn")]
        [StringLength(50)]
        public string pacificIslanderWriteIn { get; set; }

        [Column("easternEuropeanWriteIn")]
        [StringLength(50)]
        public string EasternEuropeanWriteIn { get; set; }

        [Column("middleEasternWriteIn")]
        [StringLength(50)]
        public string MiddleEasternWriteIn { get; set; }

        [Column("northAfricanWriteIn")]
        [StringLength(50)]
        public string NorthAfricanWriteIn { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }
}
