namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Column(TypeName = "date")]
        public DateTime? THOIGIA { get; set; }

        [Key]
        [StringLength(12)]
        public string MAHOADON { get; set; }

        [Required]
        [StringLength(12)]
        public string MANV { get; set; }

        public int MABENHNHAN { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(30)]
        public string TRANGTHAI { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
