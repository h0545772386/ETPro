namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientDesc")]
    public partial class ClientDesc
    {
        [Key]
        public int CDId { get; set; }

        public int ClntId { get; set; }

        [StringLength(100)]
        public string TName { get; set; }

        [StringLength(800)]
        public string TValue { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
