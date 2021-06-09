using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ETPro
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ClientCommu> ClientCommus { get; set; }
        public virtual DbSet<ClientDesc> ClientDescs { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClntOrder> ClntOrders { get; set; }
        public virtual DbSet<DiaryColor> DiaryColors { get; set; }
        public virtual DbSet<DiaryShuttle> DiaryShuttles { get; set; }
        public virtual DbSet<Doc> Docs { get; set; }
        public virtual DbSet<DriverCommu> DriverCommus { get; set; }
        public virtual DbSet<DriverDesc> DriverDescs { get; set; }
        public virtual DbSet<DriverLinc> DriverLincs { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<EventCateg> EventCategs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<PackageCommu> PackageCommus { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<UserCommu> UserCommus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vacation> Vacations { get; set; }
        public virtual DbSet<VehDesc> VehDescs { get; set; }
        public virtual DbSet<VehicleCommu> VehicleCommus { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehLinc> VehLincs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.TotalCost)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.DrvFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.VehFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.OthrCosts)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.NetProfit)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ClntOrder>()
                .Property(e => e.CommitionFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.TotalCost)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.DrvFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.VehFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.OthrCosts)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.NetProfit)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.CommitionFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.ClntAddishtionCredit)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.ClntAddishtionCharge)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.DrvAddishtionCredit)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.DrvAddishtionCharge)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.PerHour)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DiaryShuttle>()
                .Property(e => e.PerWaitHour)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Driver>()
                .Property(e => e.PerHour)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Driver>()
                .Property(e => e.PerWaitHour)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgWidth)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgHeight)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgWeight)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.PkgValue)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.ShippingPrice)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.ShippingDrvFee)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Package>()
                .Property(e => e.ShippingVehFee)
                .HasPrecision(12, 2);
        }
    }
}
