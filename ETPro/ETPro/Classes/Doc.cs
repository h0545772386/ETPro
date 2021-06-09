namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doc
    {
        public int DocId { get; set; }

        [StringLength(100)]
        public string DocName { get; set; }

        [Required]
        [StringLength(100)]
        public string ObjType { get; set; }

        public int ObjId { get; set; }

        [Required]
        [StringLength(100)]
        public string DocCtg { get; set; }

        [StringLength(300)]
        public string DocText { get; set; }

        [Required]
        [StringLength(300)]
        public string DocPath { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
