namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            HOADONs = new HashSet<HOADON>();
            LAMSANs = new HashSet<LAMSAN>();
        }

        [Key]
        public int MABENHNHAN { get; set; }

        [Required]
        [StringLength(30)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(6)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NAMSINH { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(50)]
        public string LYDOKHAM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDAUTIENDENKHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAMSAN> LAMSANs { get; set; }
    }
}
