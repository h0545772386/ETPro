namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClntOrder
    {
        [Key]
        public int OrdId { get; set; }
        public int DrvId { get; set; }
        public int VehId { get; set; }
        public int OrdNum { get; set; }

        [Required]
        [StringLength(100)]
        public string OrdType { get; set; }

        [Required]
        [StringLength(100)]
        public string OrdTime { get; set; }

        [Required]
        [StringLength(100)]
        public string OrdPath { get; set; }

        public int ClntId { get; set; }

        public int DistanceKM { get; set; }

        public int LenghtMinutes { get; set; }

        public int NumPsngrs { get; set; }

        [Required]
        [StringLength(200)]
        public string FromLocation { get; set; }

        [Required]
        [StringLength(200)]
        public string ToLocation { get; set; }

        public int StartHour { get; set; }

        public int AriveHour { get; set; }

        public int FreeAtHour { get; set; }

        public decimal TotalCost { get; set; }

        public decimal DrvFee { get; set; }

        public decimal VehFee { get; set; }

        public decimal OthrCosts { get; set; }

        public decimal NetProfit { get; set; }

        public decimal CommitionFee { get; set; }

        public int CommitionToId { get; set; }

        public bool OrdIsActive { get; set; }

        public bool OrdIfExtraHours { get; set; }

        public bool IsSunday { get; set; }

        public bool IsMonday { get; set; }

        public bool IsTuesday { get; set; }

        public bool IsWednesday { get; set; }

        public bool IsThursday { get; set; }

        public bool IsFriday { get; set; }

        public bool IsSaturday { get; set; }

        [Required]
        [StringLength(100)]
        public string OrdDays { get; set; }

        [Required]
        [StringLength(100)]
        public string OrdDays1111111 { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
