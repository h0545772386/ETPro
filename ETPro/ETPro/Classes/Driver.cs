namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Driver
    {
        [Key]
        public int DrvId { get; set; }

        [StringLength(100)]
        public string DrvIDN { get; set; }

        [StringLength(100)]
        public string CompCode { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string AliaseName { get; set; }

        [StringLength(200)]
        public string DrvDesc { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [StringLength(100)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(100)]
        public string Worthy { get; set; }

        public int OwnerCode { get; set; }

        public decimal PerHour { get; set; }

        public decimal PerWaitHour { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
