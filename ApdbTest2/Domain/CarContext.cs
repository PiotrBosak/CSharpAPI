using ApdbTest2.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ApdbTest2.Domain
{
    public class CarContext : DbContext
    {
        
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public CarContext()
        {
            
        }

        public CarContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(p => p.IdClient);
                entity.Property(p => p.IdClient).ValueGeneratedOnAdd();
                entity.Property(p => p.FirstName).HasMaxLength(50);
                entity.Property(p => p.LastName).HasMaxLength(100);
                entity.Property(p => p.PhoneNumber).HasMaxLength(20);
                entity.Property(p => p.StreetName).HasMaxLength(50);
                entity.Property(p => p.StreetNumber).HasMaxLength(5);
                entity.Property(p => p.Apartment).HasMaxLength(5);
                entity.Property(p => p.DriverLicenseNr).HasMaxLength(20);
                entity.Property(p => p.FirstName).IsRequired();
                entity.Property(p => p.LastName).IsRequired();
                entity.Property(p => p.PhoneNumber).IsRequired();
                entity.Property(p => p.StreetName).IsRequired();
                entity.Property(p => p.StreetNumber).IsRequired();
                entity.Property(p => p.DriverLicenseNr).IsRequired();
                entity.HasMany(p => p.Rents)
                    .WithOne(r => r.Client)
                    .HasForeignKey(r => r.IdClient)
                    .IsRequired();
                entity.ToTable("ClientTest");

            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(p => p.IdCity);
                entity.Property(p => p.IdCity).ValueGeneratedOnAdd();
                entity.Property(p => p.CityName).HasMaxLength(100);
                entity.Property(p => p.CityName).IsRequired();
                entity.HasMany(e => e.Clients)
                    .WithOne(p => p.City)
                    .HasForeignKey(p => p.IdCityDict)
                    .IsRequired();
                entity.ToTable("CityTest");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(p => p.IdCar);
                entity.Property(p => p.IdCar).ValueGeneratedOnAdd();
                entity.Property(p => p.Model).HasMaxLength(100);
                entity.Property(p => p.Model).IsRequired();
                
                entity.HasMany(p => p.Rents)
                    .WithOne(r => r.Car)
                    .HasForeignKey(r => r.IdCar)
                    .IsRequired();
                entity.ToTable("CarTest");
            });


            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(p => p.IdManufacturer);
                entity.Property(p => p.IdManufacturer).ValueGeneratedOnAdd();
                entity.Property(p => p.ManufacturerName).HasMaxLength(100);
                entity.Property(p => p.ManufacturerName).IsRequired();
                entity.HasMany(p => p.Cars)
                    .WithOne(c => c.Manufacturer)
                    .HasForeignKey(c => c.IdManufactureDict)
                    .IsRequired();
                entity.ToTable("ManufacturerTest");
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.HasKey(p => p.IdRent);
                entity.Property(p => p.IdRent).ValueGeneratedOnAdd();
                entity.ToTable("RentTest");

            });


        }
    }
}