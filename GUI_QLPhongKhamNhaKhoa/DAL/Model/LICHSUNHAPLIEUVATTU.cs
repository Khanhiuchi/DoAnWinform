namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSUNHAPLIEUVATTU")]
    public partial class LICHSUNHAPLIEUVATTU
    {
        [Key]
        public int STT { get; set; }

        [StringLength(30)]
        public string LOAINHAPLIEU { get; set; }

        [StringLength(12)]
        public string MADUNGCU { get; set; }

        [Required]
        [StringLength(30)]
        public string TENDUNGCU { get; set; }

        public int SOLUONG { get; set; }

        [Required]
        [StringLength(30)]
        public string DVT { get; set; }

        public double DONGIA { get; set; }

        public DateTime? THOIGIAN { get; set; }
    }
}
