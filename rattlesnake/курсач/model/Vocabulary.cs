namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vocabulary")]
    public partial class Vocabulary
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string PU_Name { get; set; }

        [StringLength(50)]
        public string Word { get; set; }

        [StringLength(300)]
        public string Definition { get; set; }

        public byte[] Pronunciation { get; set; }

        public virtual Professional_units Professional_units { get; set; }
    }
}
