namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        [Key]
        public int QuestionID { get; set; }

        [Column("Test name")]
        [Required]
        [StringLength(50)]
        public string Test_name { get; set; }

        public string Question { get; set; }

        public string Answers { get; set; }

        [StringLength(200)]
        public string Correct_Answer { get; set; }

        public virtual The_Test The_Test { get; set; }
    }
}
