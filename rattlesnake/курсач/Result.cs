namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        public int ID { get; set; }

        [Column("Test name")]
        [StringLength(50)]
        public string Test_name { get; set; }

        public string Answers { get; set; }

        public int? StudentID { get; set; }

        public TimeSpan? Time { get; set; }

        [StringLength(50)]
        public string Percentage { get; set; }

        public virtual The_Test The_Test { get; set; }

        public virtual User User { get; set; }
    }
}
