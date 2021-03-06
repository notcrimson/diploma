namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Professional units")]
    public partial class Professional_units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professional_units()
        {
            The_Test = new HashSet<The_Test>();
            Vocabulary = new HashSet<Vocabulary>();
        }

        [Key]
        [Column("Name of PU")]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        public byte[] ContentOfPU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<The_Test> The_Test { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vocabulary> Vocabulary { get; set; }
    }
}
