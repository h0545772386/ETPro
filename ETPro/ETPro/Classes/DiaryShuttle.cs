namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DiaryShuttle
    {
        [Key]
        public int DryId { get; set; }

        public int OrdId { get; set; }

        public int ShtlYear { get; set; }

        public int ShtlMonth { get; set; }

        public int ShtlDateYYYYMMDD { get; set; }

        [Required]
        [StringLength(100)]
        public string ShtlDay { get; set; }

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

        public int DrvId { get; set; }

        public int VehId { get; set; }

        public decimal DrvFee { get; set; }

        public decimal VehFee { get; set; }

        public decimal OthrCosts { get; set; }

        public decimal NetProfit { get; set; }

        public decimal CommitionFee { get; set; }

        public decimal ClntAddishtionCredit { get; set; }

        public decimal ClntAddishtionCharge { get; set; }

        public decimal DrvAddishtionCredit { get; set; }

        public decimal DrvAddishtionCharge { get; set; }

        public int CommitionToId { get; set; }

        public bool OrdIsActive { get; set; }

        public bool OrdIfExtraHours { get; set; }

        public decimal PerHour { get; set; }

        public int TotWaitMinutes { get; set; }

        public decimal PerWaitHour { get; set; }

        public bool IsChecked { get; set; }

        public bool IsApproved { get; set; }

        public bool IsFinished { get; set; }

        public bool IsFeeChecked { get; set; }

        public bool IsMarkedOk { get; set; }

        public bool IsDoneOk { get; set; }

        public bool IsPayed { get; set; }

        public bool IsReadOnly { get; set; }

        [StringLength(300)]
        public string DryText { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
