namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSUNHAPLIEUTHUOC")]
    public partial class LICHSUNHAPLIEUTHUOC
    {
        [Key]
        public int STT { get; set; }

        [StringLength(30)]
        public string LOAINHAPLIEU { get; set; }

        [Required]
        [StringLength(12)]
        public string MATHUOC { get; set; }

        [Required]
        [StringLength(30)]
        public string TENTHUOC { get; set; }

        public int SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        public double DONGIA { get; set; }

        public DateTime? THOIGIAN { get; set; }
    }
}
