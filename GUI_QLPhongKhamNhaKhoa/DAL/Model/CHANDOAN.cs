namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHANDOAN")]
    public partial class CHANDOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHANDOAN()
        {
            DIEUTRIs = new HashSet<DIEUTRI>();
            LAMSANs = new HashSet<LAMSAN>();
        }

        [Key]
        [StringLength(12)]
        public string MACHANDOAN { get; set; }

        [Required]
        [StringLength(30)]
        public string TENCHANDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEUTRI> DIEUTRIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAMSAN> LAMSANs { get; set; }
    }
}
