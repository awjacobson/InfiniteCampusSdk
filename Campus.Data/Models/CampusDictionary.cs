using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Campus.Data.Models
{
    [Table("CampusDictionary")]
    [DebuggerDisplay("Code={Code}, Name={Name}")]
    public class CampusDictionary
    {
        [Column("dictionaryID")]
        [Key]
        public int DictionaryID { get; set; }

        [Column("attributeID")]
        public int AttributeID { get; set; }

        [Column("code")]
        [Required]
        [StringLength(15)]
        public string Code { get; set; }

        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("value")]
        [StringLength(20)]
        public string Value { get; set; }

        [Column("seq")]
        public short? Seq { get; set; }

        [Column("standardCode")]
        [StringLength(20)]
        public string StandardCode { get; set; }

        [Column("active")]
        public bool? Active { get; set; }

        [Column("dictionaryGUID")]
        public Guid DictionaryGUID { get; set; }

        [Column("edFiCode")]
        [StringLength(100)]
        public string EdFiCode { get; set; }

        public virtual CampusAttribute CampusAttribute { get; set; }
    }
}
