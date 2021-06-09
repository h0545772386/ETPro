namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        [Key]
        public int VehId { get; set; }

        [StringLength(100)]
        public string VehCode { get; set; }

        [Required]
        [StringLength(200)]
        public string VehType { get; set; }

        public int NumPsngrs { get; set; }

        public int ManufYear { get; set; }

        [StringLength(200)]
        public string Model { get; set; }

        [StringLength(200)]
        public string Type { get; set; }

        [StringLength(200)]
        public string Color { get; set; }

        [StringLength(100)]
        public string LockCode { get; set; }

        public int DrvId { get; set; }

        public int CurrentKM { get; set; }

        public int NxtTimingAt { get; set; }

        public int NxtTreatmntAt { get; set; }

        public int NxtTreatmnt1At { get; set; }

        public int NxtTreatmnt2At { get; set; }

        public int NxtTreatmnt3At { get; set; }

        public int NxtTestAt { get; set; }

        public int NxtInsuranceAt { get; set; }

        public int ActivatDate { get; set; }

        public int BrakesDate { get; set; }

        public int WinterDate { get; set; }

        public int AdminDate { get; set; }

        public int AdminDate1 { get; set; }

        public int AdminDate2 { get; set; }

        public int AdminDate3 { get; set; }

        public int AdminDate4 { get; set; }

        public int Date1 { get; set; }

        public int Date2 { get; set; }

        public int Date3 { get; set; }

        public bool HasWIFI { get; set; }

        [Required]
        [StringLength(100)]
        public string Worthy { get; set; }

        public int OwnerCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public int CreatedBy { get; set; }

        public long CreatedAt { get; set; }

        public int ChangedBy { get; set; }

        public long ChangedAt { get; set; }
    }
}
