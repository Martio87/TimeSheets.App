using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeSheets.App.Data.Migrations
{
    public partial class add_seed_data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 1, "Sanctum, NEW YORK", "AVENGERS", "Doctor.Strange@Avengers.com", "Stephen", "1", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 2, "AVENGERS TOWER", "AVENGERS", "Iron.Man@Avengers.com", "Tony", "2", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 3, "AVENGERS TOWER", "AVENGERS", "Captain.America@Avengers.com", "Steve", "3", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 4, "AVENGERS TOWER", "AVENGERS", "The.Hulk@Avengers.com", "Bruce", "4", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 5, "AVENGERS TOWER", "AVENGERS", "Spider.Man@Avengers.com", "Peter", "5", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 6, "AVENGERS TOWER", "AVENGERS", "The.Falcon@Avengers.com", "Sam", "6", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 7, "AVENGERS TOWER", "AVENGERS", "Black.Widow@Avengers.com", "Natasha", "7", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 8, "WAKANDA", "AVENGERS", "Black.Panther@Avengers.com", "T'Challa", "8", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 9, "ASGARD", "AVENGERS", "Thor@Avengers.com", "Thor", "9", 0 });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone", "LocationId" },
                values: new object[] { 10, "Boston", "AVENGERS", "Captain.Marvel@Avengers.com", "Carol", "10", 0 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 1, "MANHATTAN, NEW YORK", 0, "SANCTUM" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 2, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 3, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 4, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 5, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 6, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 7, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 8, "WAKANDA", 0, "KINGS PALACE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 9, "ASGARD", 0, "KINGS PALACE" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "LocationId", "Name" },
                values: new object[] { 10, "MANHATTAN, NEW YORK", 0, "HIGH RISE" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 1, "Doctor.Strange@Avengers.com", "Stephen", 0, "Strange" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 2, "Iron.Man@Avengers.com", "Tony", 0, "Stark" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 3, "Captain.America@Avengers.com", "Steve", 0, "Rodgers" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 4, "The.Hulk@Avengers.com", "Bruce", 0, "Banner" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 5, "Spider.Man@Avengers.com", "Peter", 0, "Parker" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 6, "The.Falcon@Avengers.com", "Sam", 0, "Wilson" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 7, "Black.Widow@Avengers.com", "Natasha", 0, "Romanoff" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 8, "Black.Panther@Avengers.com", "T'", 0, "Challa" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 9, "Thor@Avengers.com", "Thor", 0, "Odison" });

            migrationBuilder.InsertData(
                table: "StaffMembers",
                columns: new[] { "Id", "Email", "FirstName", "LocationId", "Surname" },
                values: new object[] { 10, "Captain.Marvel@Avengers.com", "Carol", 0, "Denvers" });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 1, 1, 1, 2100, 1 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 2, 2, 2, 2100, 2 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 3, 3, 3, 2100, 3 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 4, 4, 4, 2100, 4 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 5, 5, 5, 2100, 5 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 6, 6, 6, 2100, 6 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 7, 7, 7, 2100, 7 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 8, 8, 8, 2100, 8 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 9, 9, 9, 2100, 9 });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 10, 10, 10, 2100, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StaffMembers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
