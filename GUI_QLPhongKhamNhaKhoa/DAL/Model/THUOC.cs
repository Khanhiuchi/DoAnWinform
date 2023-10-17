namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [Key]
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
    }
}
