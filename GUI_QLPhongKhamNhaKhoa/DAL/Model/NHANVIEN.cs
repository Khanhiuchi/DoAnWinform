namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(12)]
        public string MANV { get; set; }

        [Required]
        [StringLength(30)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(6)]
        public string GIOITINH { get; set; }

        [Required]
        [StringLength(8)]
        public string CHUCVU { get; set; }

        [Column(TypeName = "date")]
        public DateTime NAMSINH { get; set; }

        [Required]
        [StringLength(20)]
        public string KINHNGHIEM { get; set; }

        [Required]
        [StringLength(50)]
        public string BANGCAP { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
