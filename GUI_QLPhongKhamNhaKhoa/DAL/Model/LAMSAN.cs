namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LAMSAN")]
    public partial class LAMSAN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MABENHNHAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string MACHANDOAN { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string MADIEUTRI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDENKHAM { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        public virtual CHANDOAN CHANDOAN { get; set; }

        public virtual DIEUTRI DIEUTRI { get; set; }
    }
}
