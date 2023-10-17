namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATLIEUDUNGCUNHAKHOA")]
    public partial class VATLIEUDUNGCUNHAKHOA
    {
        [Key]
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
    }
}
