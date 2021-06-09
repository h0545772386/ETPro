namespace ETPro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [Key]
        public int ClntId { get; set; }

        [StringLength(100)]
        public string ClntIDN { get; set; }

        [StringLength(100)]
        public string CompCode { get; set; }

        [StringLength(100)]
        public string ClntType { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string AliaseName { get; set; }

        [StringLength(300)]
        public string ClntDesc { get; set; }

        public int Date1 { get; set; }

        public int Date2 { get; set; }

        public int Date3 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(200)]
        public string Address1 { get; set; }

        [StringLength(200)]
        public string Address2 { get; set; }

        [StringLength(200)]
        public string Address3 { get; set; }

        [StringLength(200)]
        public string Address4 { get; set; }

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


        [NotMapped]
        public List<Address> LAdrs { get; set; }
        [NotMapped]
        public List<ClientDesc> LDescs { get; set; }
        [NotMapped]
        public List<ClientCommu> LCommus { get; set; }
        [NotMapped]
        public List<ClntOrder> LClntOrdrs { get; set; }

        public Client()
        {
            LAdrs = new List<Address>();
            LDescs = new List<ClientDesc>();
            LCommus = new List<ClientCommu>();
            LClntOrdrs = new List<ClntOrder>();
        }


    }
}
