namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string MAHOADON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string MADIEUTRI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENDIEUTRI { get; set; }

        public int SOLUONG { get; set; }

        public double THANHTIEN { get; set; }

        public virtual DIEUTRI DIEUTRI { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
