﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeSheets.App.Data;

#nullable disable

namespace TimeSheets.App.Data.Migrations
{
    [DbContext(typeof(TimeSheetDbContext))]
    [Migration("20231019135625_add_seed_data1")]
    partial class add_seed_data1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("TimeSheets.App.Data.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactTelephone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ContactEmail")
                        .IsUnique();

                    b.HasIndex("LocationId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BillingAddress = "Sanctum, NEW YORK",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Doctor.Strange@Avengers.com",
                            ContactName = "Stephen",
                            ContactTelephone = "1",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 2,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Iron.Man@Avengers.com",
                            ContactName = "Tony",
                            ContactTelephone = "2",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 3,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Captain.America@Avengers.com",
                            ContactName = "Steve",
                            ContactTelephone = "3",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 4,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "The.Hulk@Avengers.com",
                            ContactName = "Bruce",
                            ContactTelephone = "4",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 5,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Spider.Man@Avengers.com",
                            ContactName = "Peter",
                            ContactTelephone = "5",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 6,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "The.Falcon@Avengers.com",
                            ContactName = "Sam",
                            ContactTelephone = "6",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 7,
                            BillingAddress = "AVENGERS TOWER",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Black.Widow@Avengers.com",
                            ContactName = "Natasha",
                            ContactTelephone = "7",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 8,
                            BillingAddress = "WAKANDA",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Black.Panther@Avengers.com",
                            ContactName = "T'Challa",
                            ContactTelephone = "8",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 9,
                            BillingAddress = "ASGARD",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Thor@Avengers.com",
                            ContactName = "Thor",
                            ContactTelephone = "9",
                            LocationId = 0
                        },
                        new
                        {
                            Id = 10,
                            BillingAddress = "Boston",
                            CompanyName = "AVENGERS",
                            ContactEmail = "Captain.Marvel@Avengers.com",
                            ContactName = "Carol",
                            ContactTelephone = "10",
                            LocationId = 0
                        });
                });

            modelBuilder.Entity("TimeSheets.App.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "SANCTUM"
                        },
                        new
                        {
                            Id = 2,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 3,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 4,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 5,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 6,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 7,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        },
                        new
                        {
                            Id = 8,
                            Address = "WAKANDA",
                            LocationId = 0,
                            Name = "KINGS PALACE"
                        },
                        new
                        {
                            Id = 9,
                            Address = "ASGARD",
                            LocationId = 0,
                            Name = "KINGS PALACE"
                        },
                        new
                        {
                            Id = 10,
                            Address = "MANHATTAN, NEW YORK",
                            LocationId = 0,
                            Name = "HIGH RISE"
                        });
                });

            modelBuilder.Entity("TimeSheets.App.Data.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LocationId");

                    b.ToTable("StaffMembers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Doctor.Strange@Avengers.com",
                            FirstName = "Stephen",
                            LocationId = 0,
                            Surname = "Strange"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Iron.Man@Avengers.com",
                            FirstName = "Tony",
                            LocationId = 0,
                            Surname = "Stark"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Captain.America@Avengers.com",
                            FirstName = "Steve",
                            LocationId = 0,
                            Surname = "Rodgers"
                        },
                        new
                        {
                            Id = 4,
                            Email = "The.Hulk@Avengers.com",
                            FirstName = "Bruce",
                            LocationId = 0,
                            Surname = "Banner"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Spider.Man@Avengers.com",
                            FirstName = "Peter",
                            LocationId = 0,
                            Surname = "Parker"
                        },
                        new
                        {
                            Id = 6,
                            Email = "The.Falcon@Avengers.com",
                            FirstName = "Sam",
                            LocationId = 0,
                            Surname = "Wilson"
                        },
                        new
                        {
                            Id = 7,
                            Email = "Black.Widow@Avengers.com",
                            FirstName = "Natasha",
                            LocationId = 0,
                            Surname = "Romanoff"
                        },
                        new
                        {
                            Id = 8,
                            Email = "Black.Panther@Avengers.com",
                            FirstName = "T'",
                            LocationId = 0,
                            Surname = "Challa"
                        },
                        new
                        {
                            Id = 9,
                            Email = "Thor@Avengers.com",
                            FirstName = "Thor",
                            LocationId = 0,
                            Surname = "Odison"
                        },
                        new
                        {
                            Id = 10,
                            Email = "Captain.Marvel@Avengers.com",
                            FirstName = "Carol",
                            LocationId = 0,
                            Surname = "Denvers"
                        });
                });

            modelBuilder.Entity("TimeSheets.App.Data.TimeSheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinutesWorked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MinutesWorked")
                        .IsUnique();

                    b.HasIndex("StaffId");

                    b.ToTable("TimeSheets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            LocationId = 1,
                            MinutesWorked = 2100,
                            StaffId = 1
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            LocationId = 2,
                            MinutesWorked = 2100,
                            StaffId = 2
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 3,
                            LocationId = 3,
                            MinutesWorked = 2100,
                            StaffId = 3
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 4,
                            LocationId = 4,
                            MinutesWorked = 2100,
                            StaffId = 4
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 5,
                            LocationId = 5,
                            MinutesWorked = 2100,
                            StaffId = 5
                        },
                        new
                        {
                            Id = 6,
                            ClientId = 6,
                            LocationId = 6,
                            MinutesWorked = 2100,
                            StaffId = 6
                        },
                        new
                        {
                            Id = 7,
                            ClientId = 7,
                            LocationId = 7,
                            MinutesWorked = 2100,
                            StaffId = 7
                        },
                        new
                        {
                            Id = 8,
                            ClientId = 8,
                            LocationId = 8,
                            MinutesWorked = 2100,
                            StaffId = 8
                        },
                        new
                        {
                            Id = 9,
                            ClientId = 9,
                            LocationId = 9,
                            MinutesWorked = 2100,
                            StaffId = 9
                        },
                        new
                        {
                            Id = 10,
                            ClientId = 10,
                            LocationId = 10,
                            MinutesWorked = 2100,
                            StaffId = 10
                        });
                });

            modelBuilder.Entity("TimeSheets.App.Data.Clients", b =>
                {
                    b.HasOne("TimeSheets.App.Data.Location", "Location")
                        .WithMany("Clients")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TimeSheets.App.Data.Staff", b =>
                {
                    b.HasOne("TimeSheets.App.Data.Location", "Location")
                        .WithMany("StaffMembers")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TimeSheets.App.Data.TimeSheet", b =>
                {
                    b.HasOne("TimeSheets.App.Data.Clients", "Clients")
                        .WithMany("TimeSheets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeSheets.App.Data.Location", "Location")
                        .WithMany("TimeSheets")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeSheets.App.Data.Staff", "Staff")
                        .WithMany("TimeSheets")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Location");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TimeSheets.App.Data.Clients", b =>
                {
                    b.Navigation("TimeSheets");
                });

            modelBuilder.Entity("TimeSheets.App.Data.Location", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("StaffMembers");

                    b.Navigation("TimeSheets");
                });

            modelBuilder.Entity("TimeSheets.App.Data.Staff", b =>
                {
                    b.Navigation("TimeSheets");
                });
#pragma warning restore 612, 618
        }
    }
}
