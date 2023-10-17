namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEUTRI")]
    public partial class DIEUTRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIEUTRI()
        {
            CTHDs = new HashSet<CTHD>();
            LAMSANs = new HashSet<LAMSAN>();
        }

        [Key]
        [StringLength(12)]
        public string MADIEUTRI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENDIEUTRI { get; set; }

        [StringLength(12)]
        public string DVT { get; set; }

        public double DONGIA { get; set; }

        [Required]
        [StringLength(12)]
        public string MACHANDOAN { get; set; }

        public virtual CHANDOAN CHANDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAMSAN> LAMSANs { get; set; }
    }
}
