namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(15)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(30)]
        public string DISPLAYNAME { get; set; }

        [Required]
        [StringLength(30)]
        public string TYPE { get; set; }
    }
}
