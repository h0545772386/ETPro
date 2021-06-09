namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventCateg
    {
        [Key]
        public int ECId { get; set; }

        [Required]
        [StringLength(100)]
        public string ObjType { get; set; }

        [Required]
        [StringLength(100)]
        public string MainCateg { get; set; }

        [Required]
        [StringLength(100)]
        public string ScndCateg { get; set; }

        [Required]
        [StringLength(100)]
        public string ThrdCateg { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
