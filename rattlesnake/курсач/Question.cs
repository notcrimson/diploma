namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        public int QuestionID { get; set; }

        [Column("Test name")]
        [Required]
        [StringLength(50)]
        public string Test_name { get; set; }

        [Column("Question")]
        public string Question1 { get; set; }

        public string Answers { get; set; }

        public virtual The_Test The_Test { get; set; }
    }
}
