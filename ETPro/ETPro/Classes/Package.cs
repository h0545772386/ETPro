namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Package
    {
        [Key]
        public int PkgId { get; set; }

        [Required]
        [StringLength(200)]
        public string PkgText { get; set; }

        public decimal PkgWidth { get; set; }

        public decimal PkgHeight { get; set; }

        public decimal PkgWeight { get; set; }

        public decimal PkgValue { get; set; }

        public decimal ShippingPrice { get; set; }

        public decimal ShippingDrvFee { get; set; }

        public decimal ShippingVehFee { get; set; }

        public int PickDate_YYYYMMDD { get; set; }

        [Required]
        [StringLength(300)]
        public string PickAdrs { get; set; }

        public int DlvrDate_YYYYMMDD { get; set; }

        [Required]
        [StringLength(300)]
        public string DlvrAdrs { get; set; }

        [StringLength(300)]
        public string PkgOwner { get; set; }

        [StringLength(300)]
        public string PkgSender { get; set; }

        [StringLength(300)]
        public string PkgReceiver { get; set; }

        [StringLength(100)]
        public string PkgTrackCode { get; set; }

        public int DryId { get; set; }

        public bool IsApproved { get; set; }

        public bool IsChecked { get; set; }

        public bool IsPicked { get; set; }

        public bool IsDelivered { get; set; }

        public bool IsFinished { get; set; }

        public bool IsDoneOk { get; set; }

        public bool IsPayed { get; set; }

        public bool IsReadOnly { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
