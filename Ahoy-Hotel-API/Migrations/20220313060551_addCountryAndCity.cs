using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ahoy_Hotel_API.Migrations
{
    public partial class addCountryAndCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1866), false, "United Arab Emirates", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1866) },
                    { 2, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1873), false, "Saudi Arabia", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1874) }
                });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1383), new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1441), "https://www.icons.com/wifi", new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1455), "https://www.icons.com/parking", new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1466), "https://www.icons.com/Spa", new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1499), "$2a$11$TPG0voZZrrFJ6kCKJL.1.OK1OcS8v4MCNXo2gnajmjnVXZNqMDCYy", new DateTime(2022, 3, 13, 10, 5, 50, 693, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1555), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1653), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1662), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1668), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1685), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1698), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1851), new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedOn", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1884), false, "Dubai", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1884) },
                    { 2, 1, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1891), false, "Abu Dhabi", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1892) },
                    { 3, 1, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1897), false, "Sharjah", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1898) },
                    { 4, 2, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1903), false, "Jeddah", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1903) },
                    { 5, 2, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1908), false, "Riyadh", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1909) },
                    { 6, 2, new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1921), false, "Dammam", new DateTime(2022, 3, 13, 10, 5, 50, 921, DateTimeKind.Local).AddTicks(1921) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9949), "https://www.icons.com/breakfast", new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9990), "https://www.icons.com/breakfast", new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(35), "https://www.icons.com/breakfast", new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(72), "$2a$11$j1ooCGFULW8WyHDuqTcBJOT8ne18aqKZ9QG/J/gyPhqRJZA/.Hlpq", new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(860), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(870), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(878), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(885), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(901), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(910), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(933), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(809), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(948), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(963), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(972), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(992) });
        }
    }
}
