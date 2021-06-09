namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCommu
    {
        [Key]
        public int UCId { get; set; }

        public int UsrId { get; set; }

        [StringLength(100)]
        public string PersonName { get; set; }

        [StringLength(100)]
        public string CommuType { get; set; }

        [StringLength(200)]
        public string CommuValue { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
