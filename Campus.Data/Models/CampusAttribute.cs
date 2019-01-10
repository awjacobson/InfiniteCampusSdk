using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Campus.Data.Models
{
    [Table("CampusAttribute")]
    public class CampusAttribute
    {
        public CampusAttribute()
        {
            CustomStudents = new HashSet<CustomStudent>();
        }

        [Column("attributeID")]
        [Key]
        public int AttributeID { get; set; }

        [Column("object")]
        [Required]
        [StringLength(30)]
        public string _object { get; set; }

        [Column("element")]
        [Required]
        [StringLength(30)]
        public string Element { get; set; }

        [Column("name")]
        [StringLength(35)]
        public string Name { get; set; }

        [Column("defaultValue")]
        [StringLength(255)]
        public string DefaultValue { get; set; }

        [Column("dataType")]
        [StringLength(15)]
        public string DataType { get; set; }

        [Column("dated")]
        public bool? Dated { get; set; }

        [Column("seq")]
        public byte? Seq { get; set; }

        [Column("hide")]
        public bool? Hide { get; set; }

        [Column("required")]
        public bool? Required { get; set; }

        [Column("maxSize")]
        public byte? MaxSize { get; set; }

        [Column("custom")]
        public bool Custom { get; set; }

        [Column("lock")]
        public bool? _lock { get; set; }

        [Column("copiesForward")]
        public bool? CopiesForward { get; set; }

        [Column("statusData")]
        public bool? StatusData { get; set; }

        [Column("comments")]
        [StringLength(100)]
        public string Comments { get; set; }

        [Column("hidePortal")]
        public bool? HidePortal { get; set; }

        [Column("stateTable")]
        public bool? StateTable { get; set; }

        [Column("planEnabled")]
        public bool? PlanEnabled { get; set; }

        [Column("coreLock")]
        public bool? CoreLock { get; set; }

        [Column("deprecated")]
        public bool? Deprecated { get; set; }

        [Column("dbObject")]
        [StringLength(50)]
        public string DbObject { get; set; }

        [Column("dbElement")]
        [StringLength(50)]
        public string DbElement { get; set; }

        [StringLength(1000)]
        public string GUIPath { get; set; }

        [Column("nameLock")]
        public bool? NameLock { get; set; }

        [Column("defaultValueLock")]
        public bool? DefaultValueLock { get; set; }

        [Column("hideLock")]
        public bool? HideLock { get; set; }

        [Column("requiredLock")]
        public bool? RequiredLock { get; set; }

        [Column("copiesForwardLock")]
        public bool? CopiesForwardLock { get; set; }

        [Column("commentsLock")]
        public bool? CommentsLock { get; set; }

        [Column("key")]
        [StringLength(50)]
        public string Key { get; set; }

        [Column("keepHistory")]
        public bool? KeepHistory { get; set; }

        [Column("fieldOnly")]
        public bool FieldOnly { get; set; }

        [Column("direction")]
        [StringLength(15)]
        public string Direction { get; set; }

        [Column("horizontalAlignment")]
        [StringLength(15)]
        public string HorizontalAlignment { get; set; }

        [Column("verticalAlignment")]
        [StringLength(15)]
        public string VerticalAlignment { get; set; }

        [Column("module")]
        [Required]
        [StringLength(3)]
        public string Module { get; set; }

        [Column("description")]
        [StringLength(1000)]
        public string Description { get; set; }

        [Column("attributeGUID")]
        public Guid AttributeGUID { get; set; }

        public virtual ICollection<CustomStudent> CustomStudents { get; set; }
    }
}
