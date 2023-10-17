namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKHAMBENH")]
    public partial class PHIEUKHAMBENH
    {
        [Key]
        public int STT { get; set; }

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
        public DateTime? NGAYDENKHAM { get; set; }
    }
}
