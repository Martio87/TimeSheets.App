using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimeSheets.App.Data
{
    internal class TimeSheetDbContext : DbContext
    {
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=timesheets.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defining primary keys
            modelBuilder.Entity<Staff>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Clients>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Location>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<TimeSheet>()
                .HasKey(ts => ts.Id);

            // Defining relationships
            modelBuilder.Entity<TimeSheet>()
                .HasOne(ts => ts.Staff)
                .WithMany(staff => staff.TimeSheets)
                .HasForeignKey(ts => ts.StaffId);

            modelBuilder.Entity<TimeSheet>()
                .HasOne(ts => ts.Clients)
                .WithMany(client => client.TimeSheets)
                .HasForeignKey(ts => ts.ClientId);

            modelBuilder.Entity<TimeSheet>()
                .HasOne(timesheet => timesheet.Location)
                .WithMany(location => location.TimeSheets)
                .HasForeignKey(timesheet => timesheet.LocationId);


            // Defining constraints
            modelBuilder.Entity<Staff>()
                .HasIndex(staff => staff.Email)
                .IsUnique();

            modelBuilder.Entity<Clients>()
                .HasIndex(client => client.ContactEmail)
                .IsUnique();

            modelBuilder.Entity<Location>()
                .HasIndex(location => location.Name)
                .IsUnique();

            modelBuilder.Entity<TimeSheet>()
                .HasIndex(timesheet => timesheet.MinutesWorked)
                .IsUnique();

            SeedTestData(modelBuilder);
        }

        private void SeedTestData(ModelBuilder modelBuilder)
        {
            // Seed test data for Staff
            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, FirstName = "Stephen", Surname = "Strange", Email = "Doctor.Strange@Avengers.com" },
                new Staff { Id = 2, FirstName = "Tony", Surname = "Stark", Email = "Iron.Man@Avengers.com" },
                new Staff { Id = 3, FirstName = "Steve", Surname = "Rodgers", Email = "Captain.America@Avengers.com" },
                new Staff { Id = 4, FirstName = "Bruce", Surname = "Banner", Email = "The.Hulk@Avengers.com" },
                new Staff { Id = 5, FirstName = "Peter", Surname = "Parker", Email = "Spider.Man@Avengers.com" },
                new Staff { Id = 6, FirstName = "Sam", Surname = "Wilson", Email = "The.Falcon@Avengers.com" },
                new Staff { Id = 7, FirstName = "Natasha", Surname = "Romanoff", Email = "Black.Widow@Avengers.com" },
                new Staff { Id = 8, FirstName = "T'", Surname = "Challa", Email = "Black.Panther@Avengers.com" },
                new Staff { Id = 9, FirstName = "Thor", Surname = "Odison", Email = "Thor@Avengers.com" },
                new Staff { Id = 10, FirstName = "Carol", Surname = "Denvers", Email = "Captain.Marvel@Avengers.com" }
            );

            // Seed test data for Clients
            modelBuilder.Entity<Clients>().HasData(
                new Clients { Id = 1, CompanyName = "AVENGERS", BillingAddress = "Sanctum, NEW YORK", ContactTelephone = "1",  ContactName="Stephen",  ContactEmail = "Doctor.Strange@Avengers.com" },
                new Clients { Id = 2, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "2",  ContactName="Tony", ContactEmail = "Iron.Man@Avengers.com" },
                new Clients { Id = 3, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "3",  ContactName="Steve", ContactEmail = "Captain.America@Avengers.com" },
                new Clients { Id = 4, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "4",  ContactName="Bruce", ContactEmail = "The.Hulk@Avengers.com" },
                new Clients { Id = 5, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "5",  ContactName="Peter", ContactEmail = "Spider.Man@Avengers.com" },
                new Clients { Id = 6, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "6",  ContactName="Sam", ContactEmail = "The.Falcon@Avengers.com" },
                new Clients { Id = 7, CompanyName = "AVENGERS", BillingAddress = "AVENGERS TOWER", ContactTelephone = "7",  ContactName="Natasha", ContactEmail = "Black.Widow@Avengers.com" },
                new Clients { Id = 8, CompanyName = "AVENGERS", BillingAddress = "WAKANDA", ContactTelephone = "8",  ContactName="T'Challa", ContactEmail = "Black.Panther@Avengers.com" },
                new Clients { Id = 9, CompanyName = "AVENGERS", BillingAddress = "ASGARD", ContactTelephone = "9",  ContactName="Thor", ContactEmail = "Thor@Avengers.com" },
                new Clients { Id = 10, CompanyName = "AVENGERS", BillingAddress = "Boston", ContactTelephone = "10",  ContactName="Carol", ContactEmail = "Captain.Marvel@Avengers.com" }
            );

            // Seed test data for Locations
            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "SANCTUM", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 2, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 3, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 4, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 5, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 6, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 7, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" },
                new Location { Id = 8, Name = "KINGS PALACE", Address = "WAKANDA" },
                new Location { Id = 9, Name = "KINGS PALACE", Address = "ASGARD" },
                new Location { Id = 10, Name = "HIGH RISE", Address = "MANHATTAN, NEW YORK" }
            );

            // Seed test data for TimeSheets
            modelBuilder.Entity<TimeSheet>().HasData(
                new TimeSheet { Id = 1, MinutesWorked = 2100, StaffId = 1, ClientId = 1, LocationId = 1 }, //2100 minutes = 40hr week with unpaid hour lunch.
                new TimeSheet { Id = 2, MinutesWorked = 2100, StaffId = 2, ClientId = 2, LocationId = 2 },
                new TimeSheet { Id = 3, MinutesWorked = 2100, StaffId = 3, ClientId = 3, LocationId = 3 },
                new TimeSheet { Id = 4, MinutesWorked = 2100, StaffId = 4, ClientId = 4, LocationId = 4 },
                new TimeSheet { Id = 5, MinutesWorked = 2100, StaffId = 5, ClientId = 5, LocationId = 5 },
                new TimeSheet { Id = 6, MinutesWorked = 2100, StaffId = 6, ClientId = 6, LocationId = 6 },
                new TimeSheet { Id = 7, MinutesWorked = 2100, StaffId = 7, ClientId = 7, LocationId = 7 },
                new TimeSheet { Id = 8, MinutesWorked = 2100, StaffId = 8, ClientId = 8, LocationId = 8 },
                new TimeSheet { Id = 9, MinutesWorked = 2100, StaffId = 9, ClientId = 9, LocationId = 9 },
                new TimeSheet { Id = 10, MinutesWorked = 2100, StaffId = 10, ClientId = 10, LocationId = 10 }
            );
        }

 

    }
}
