namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_profile
    {
        [Key]
        public int StudetResult_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Student_login { get; set; }

        [Column("Time entered")]
        public TimeSpan? Time_entered { get; set; }

        [Column("Time exited")]
        public TimeSpan? Time_exited { get; set; }

        public int? Result_ID { get; set; }

        [StringLength(50)]
        public string ResultPercent { get; set; }
    }
}
