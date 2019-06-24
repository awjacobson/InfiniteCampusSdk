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

        [Column("structureID")]
        public int StructureID { get; set; }

        /// <summary>
        /// Ex. "KA", "KP", "01", "02" "03", "04", etc.
        /// </summary>
        [Column("grade")]
        [StringLength(4)]
        public string Grade { get; set; }

        /// <summary>
        /// "N", "P", "S"
        /// </summary>
        [Column("serviceType")]
        [StringLength(1)]
        public string ServiceType { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("classRankExclude")]
        public bool? ClassRankExclude { get; set; }

        [Column("noShow")]
        public bool? NoShow { get; set; }

        [Column("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// NULL, "E100", "R101", "R102", "R103", etc.
        /// </summary>
        [Column("startStatus")]
        [StringLength(1)]
        public string StartStatus { get; set; }

        [Column("startComments")]
        [StringLength(250)]
        public string StartComments { get; set; }

        [Column("endDate")]
        public DateTime? EndDate { get; set; }

        [Column("endStatus")]
        [StringLength(4)]
        public string EndStatus { get; set; }

        [Column("endComments")]
        [StringLength(250)]
        public string EndComments { get; set; }

        [Column("endAction")]
        public string EndAction { get; set; }

        [Column("nextCalendar")]
        public int? NextCalendar { get; set; }

        [Column("nextGrade")]
        [StringLength(4)]
        public string NextGrade { get; set; }

        [Column("diplomaDate")]
        public DateTime? DiplomaDate { get; set; }

        [Column("diplomaType")]
        [StringLength(3)]
        public string DiplomaType { get; set; }

        [Column("diplomaPeriod")]
        [StringLength(3)]
        public string DiplomaPeriod { get; set; }

        [Column("postGradPlans")]
        [StringLength(3)]
        public string PostGradPlans { get; set; }

        [Column("postGradLocation")]
        [StringLength(2)]
        public string PostGradLocation { get; set; }

        [Column("gradYear")]
        public int? GradYear { get; set; }

        [Column("stateExclude")]
        public bool? StateExclude { get; set; }

        [Column("servingDistrict")]
        [StringLength(12)]
        public string ServingDistrict { get; set; }

        [Column("residentDistrict")]
        [StringLength(12)]
        public string ResidentDistrict { get; set; }

        [Column("residentSchool")]
        [StringLength(10)]
        public string ResidentSchool { get; set; }

        [Column("mealStatus")]
        [StringLength(4)]
        public string MealStatus { get; set; }

        [Column("englishProficiency")]
        [StringLength(4)]
        public string EnglishProficiency { get; set; }

        [Column("englishProficiencyDate")]
        public DateTime? EnglishProficiencyDate { get; set; }

        [Column("lep")]
        [StringLength(50)]
        public string Lep { get; set; }

        [Column("esl")]
        [StringLength(5)]
        public string Esl { get; set; }

        [Column("language")]
        [StringLength(4)]
        public string Language { get; set; }

        [Column("citizenship")]
        [StringLength(4)]
        public string Citizenship { get; set; }

        [Column("title1")]
        [StringLength(2)]
        public string Title1 { get; set; }

        [Column("title3")]
        [StringLength(2)]
        public string Title3 { get; set; }

        [Column("transportation")]
        [StringLength(2)]
        public string Transportation { get; set; }

        [Column("migrant")]
        [StringLength(2)]
        public string Migrant { get; set; }

        [Column("immigrant")]
        [StringLength(3)]
        public string Immigrant { get; set; }

        [Column("homeless")]
        [StringLength(2)]
        public string Homeless { get; set; }

        [Column("homeSchooled")]
        [StringLength(1)]
        public string HomeSchooled { get; set; }

        [Column("homebound")]
        [StringLength(1)]
        public string Homebound { get; set; }

        [Column("giftedTalented")]
        [StringLength(2)]
        public string GiftedTalented { get; set; }

        [Column("nclbChoice")]
        [StringLength(2)]
        public string NclbChoice { get; set; }

        [Column("percentEnrolled")]
        public decimal? PercentEnrolled { get; set; }

        [Column("admOverride")]
        public decimal? AdmOverride { get; set; }

        [Column("adaOverride")]
        public decimal? AdaOverride { get; set; }

        [Column("vocationalCode")]
        [StringLength(2)]
        public string VocationalCode { get; set; }

        [Column("pseo")]
        [StringLength(4)]
        public string Pseo { get; set; }

        [Column("facilityCode")]
        [StringLength(6)]
        public string FacilityCode { get; set; }

        [Column("stateAid")]
        [StringLength(10)]
        public string StateAid { get; set; }

        [Column("stateFundingCode")]
        [StringLength(2)]
        public string StateFundingCode { get; set; }

        [Column("section504")]
        [StringLength(2)]
        public string Section504 { get; set; }

        [Column("specialEdStatus")]
        [StringLength(5)]
        public string SpecialEdStatus { get; set; }

        [Column("specialEdSetting")]
        [StringLength(6)]
        public string SpecialEdSetting { get; set; }

        [Column("disability1")]
        [StringLength(5)]
        public string Disability1 { get; set; }

        [Column("disability2")]
        [StringLength(5)]
        public string Disability2 { get; set; }

        [Column("disability3")]
        [StringLength(5)]
        public string Disability3 { get; set; }

        [Column("disability4")]
        [StringLength(5)]
        public string Disability4 { get; set; }

        [Column("disability5")]
        [StringLength(5)]
        public string Disability5 { get; set; }

        [Column("disability6")]
        [StringLength(5)]
        public string Disability6 { get; set; }

        [Column("disability7")]
        [StringLength(5)]
        public string Disability7 { get; set; }

        [Column("disability8")]
        [StringLength(5)]
        public string Disability8 { get; set; }

        [Column("disability9")]
        [StringLength(5)]
        public string Disability9 { get; set; }

        [Column("disability10")]
        [StringLength(5)]
        public string Disability10 { get; set; }

        [Column("enrollmentGUID")]
        public string EnrollmentGUID { get; set; }

        [Column("privateSchooled")]
        [StringLength(1)]
        public string PrivateSchooled { get; set; }

        [Column("spedExitDate")]
        public DateTime? SpedExitDate { get; set; }

        [Column("spedExitReason")]
        [StringLength(3)]
        public string SpedExitReason { get; set; }

        [Column("childCountStatus")]
        [StringLength(2)]
        public string ChildCountStatus { get; set; }

        [Column("grade9Date")]
        public DateTime? Grade9Date { get; set; }

        [Column("singleParent")]
        [StringLength(1)]
        public string SingleParent { get; set; }

        [Column("displacedHomemaker")]
        [StringLength(1)]
        public string DisplacedHomemaker { get; set; }

        [Column("legacyKey")]
        public int? LegacyKey { get; set; }

        [Column("legacySeq1")]
        public int? LegacySeq1 { get; set; }

        [Column("legacySeq2")]
        public int? LegacySeq2 { get; set; }

        [Column("endYear")]
        public int EndYear { get; set; }

        [Column("districtID")]
        public int DistrictID { get; set; }

        [Column("localStudentNumber")]
        [StringLength(15)]
        public string LocalStudentNumber { get; set; }

        [Column("modifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        [Column("modifiedByID")]
        public int? ModifiedByID { get; set; }

        [Column("dropoutCode")]
        [StringLength(3)]
        public string DropoutCode { get; set; }

        [Column("eip")]
        [StringLength(1)]
        public string Eip { get; set; }

        [Column("adult")]
        public bool? Adult { get; set; }

        [Column("servingCounty")]
        [StringLength(8)]
        public string ServingCounty { get; set; }

        [Column("projectedGraduationDate")]
        public DateTime? ProjectedGraduationDate { get; set; }

        [Column("attendanceGroup")]
        [StringLength(3)]
        public string AttendanceGroup { get; set; }

        [Column("withdrawDate")]
        public DateTime? WithdrawDate { get; set; }

        [Column("rollForwardCode")]
        [StringLength(1)]
        public string RollForwardCode { get; set; }

        [Column("rollForwardEnrollmentID")]
        public int? RollForwardEnrollmentID { get; set; }

        [Column("cohortYear")]
        [StringLength(4)]
        public string CohortYear { get; set; }

        [Column("nextStructureID")]
        public int? NextStructureID { get; set; }

        [Column("schoolEntryDate")]
        public DateTime? SchoolEntryDate { get; set; }

        [Column("districtEntryDate")]
        public DateTime? DistrictEntryDate { get; set; }

        [Column("mvUnaccompaniedYouth")]
        [StringLength(2)]
        public string MvUnaccompaniedYouth { get; set; }

        [Column("externalLMSExclude")]
        public bool? ExternalLMSExclude { get; set; }

        [Column("schoolOfAccountability")]
        public int? SchoolOfAccountability { get; set; }

        [Column("localStartStatusTypeID")]
        public int? LocalStartStatusTypeID { get; set; }

        [Column("localEndStatusTypeID")]
        public int? LocalEndStatusTypeID { get; set; }

        [Column("schoolChoiceProgram")]
        [StringLength(2)]
        public string SchoolChoiceProgram { get; set; }

        public virtual Person Person { get; set; }

        public virtual Calendar Calendar { get; set; }
    }
}
