namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Log
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastFormUsed { get; set; }

        [StringLength(50)]
        public string Coordinate { get; set; }

        public virtual Users Users { get; set; }
    }
}
