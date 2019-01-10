using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("Contact")]
    [DebuggerDisplay("PersonID={PersonID}")]
    public partial class Contact
    {
        [Column("personID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }

        [Column("homePhone")]
        [StringLength(25)]
        public string HomePhone { get; set; }

        [Column("workPhone")]
        [StringLength(25)]
        public string WorkPhone { get; set; }

        [Column("cellPhone")]
        [StringLength(25)]
        public string CellPhone { get; set; }

        [Column("pager")]
        [StringLength(25)]
        public string Pager { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("comments")]
        [StringLength(500)]
        public string Comments { get; set; }

        [Column("homePhonePrivate")]
        public bool? HomePhonePrivate { get; set; }

        [Column("workPhonePrivate")]
        public bool? WorkPhonePrivate { get; set; }

        [Column("cellPhonePrivate")]
        public bool? CellPhonePrivate { get; set; }

        [Column("pagerPrivate")]
        public bool? PagerPrivate { get; set; }

        [Column("emailPrivate")]
        public bool? EmailPrivate { get; set; }

        [Column("homePhoneMessenger")]
        public int? HomePhoneMessenger { get; set; }

        [Column("workPhoneMessenger")]
        public int? WorkPhoneMessenger { get; set; }

        [Column("cellPhoneMessenger")]
        public int? CellPhoneMessenger { get; set; }

        [Column("emailMessenger")]
        public int? EmailMessenger { get; set; }

        [Column("inboxMessenger")]
        public int? InboxMessenger { get; set; }

        [Column("communicationLanguage")]
        [StringLength(5)]
        public string CommunicationLanguage { get; set; }

        [Column("modifiedByID")]
        public int? ModifiedByID { get; set; }

        [Column("modifiedDate", TypeName = "smalldatetime")]
        public DateTime? ModifiedDate { get; set; }

        [Column("cellPhoneTxtMsg")]
        public bool CellPhoneTxtMsg { get; set; }

        [Column("secondaryEmail")]
        [StringLength(100)]
        public string SecondaryEmail { get; set; }

        [Column("homeTextMessenger")]
        public int? HomeTextMessenger { get; set; }

        [Column("workTextMessenger")]
        public int? WorkTextMessenger { get; set; }

        [Column("CellTextMessenger")]
        public int? cellTextMessenger { get; set; }

        [Column("secondaryEmailMessenger")]
        public int? SecondaryEmailMessenger { get; set; }

        [Column("secondaryEmailPrivate")]
        public bool? SecondaryEmailPrivate { get; set; }

        public virtual Person Person { get; set; }
    }
}
