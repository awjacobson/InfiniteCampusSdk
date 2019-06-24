using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Data.Models
{
    public class Student
    {

        [Column("endYear")]
        public int EndYear { get; set; }

        [Column("districtID")]
        public int DistrictID { get; set; }

        [Column("calendarID")]
        public int CalendarID { get; set; }

        [Column("personID")]
        [ForeignKey("Person")]
        public int PersonID { get; set; }

        [Column("structureID")]
        public int StructureID { get; set; }

        [Column("noShow")]
        public bool? NoShow { get; set; }

        [Column("schoolID")]
        public int SchoolID { get; set; }

        [Column("enrollmentID")]
        public int EnrollmentID { get; set; }

        [Column("schoolOfAccountability")]
        public int? SchoolOfAccountability { get; set; }

        [Column("stateID")]
        [StringLength(15)]
        public string StateID { get; set; }

        [Column("otherID")]
        [StringLength(15)]
        public string OtherID { get; set; }

        [Column("additionalID")]
        [StringLength(25)]
        public string AdditionalID { get; set; }

        [Column("edFiID")]
        [StringLength(20)]
        public string EdFiID { get; set; }

        [Column("studentNumber")]
        [StringLength(15)]
        public string StudentNumber { get; set; }

        [Column("personGUID")]
        public Guid PersonGUID { get; set; }

        [Column("identityID")]
        public int IdentityID { get; set; }

        [Column("effectiveDate", TypeName = "smalldatetime")]
        public DateTime? EffectiveDate { get; set; }

        [Column("lastName")]
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

        [Column("legalFirstName")]
        public string LegalFirstName { get; set; }

        [Column("legalLastName")]
        public string LegalLastName { get; set; }

        [Column("legalMiddleName")]
        public string LegalMiddleName { get; set; }

        [Column("legalSuffix")]
        public string LegalSuffix { get; set; }

        [Column("legalGender")]
        public string LegalGender { get; set; }

        [Column("raceEthnicity")]
        [StringLength(3)]
        public string RaceEthnicity { get; set; }

        [Column("hispanicEthnicity")]
        [StringLength(2)]
        public string HispanicEthnicity { get; set; }

        [Column("raceEthnicityFed")]
        [StringLength(1)]
        public string RaceEthnicityFed { get; set; }

        [Column("raceEthnicityDetermination")]
        [StringLength(2)]
        public string RaceEthnicityDetermination { get; set; }

        [Column("birthCountry")]
        [StringLength(4)]
        public string BirthCountry { get; set; }

        [Column("birthState")]
        public string BirthState { get; set; }

        [Column("birthCity")]
        [StringLength(30)]
        public string BirthCity { get; set; }

        [Column("birthCounty")]
        [StringLength(30)]
        public string BirthCounty { get; set; }

        [Column("homePrimaryLanguage")]
        [StringLength(5)]
        public string HomePrimaryLanguage { get; set; }

        [Column("languageAlt")]
        [StringLength(5)]
        public string LanguageAlt { get; set; }

        [Column("languageAlt2")]
        [StringLength(5)]
        public string LanguageAlt2 { get; set; }

        [Column("grade")]
        [StringLength(4)]
        public string Grade { get; set; }

        [Column("serviceType")]
        [StringLength(1)]
        public string ServiceType { get; set; }

        [Column("startDate")]
        public DateTime StartDate { get; set; }

        [Column("startStatus")]
        [StringLength(1)]
        public string StartStatus { get; set; }

        [Column("endDate")]
        public DateTime? EndDate { get; set; }

        [Column("endStatus")]
        [StringLength(4)]
        public string EndStatus { get; set; }
    }
}
