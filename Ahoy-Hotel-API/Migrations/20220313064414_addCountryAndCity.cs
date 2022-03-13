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
                name: "CityId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cities",
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
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3757), false, "Dubai", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3758) },
                    { 2, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3849), false, "Abu Dhabi", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3850) },
                    { 3, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3884), false, "Sharjah", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3885) },
                    { 4, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3904), false, "Jeddah", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3905) },
                    { 5, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3920), false, "Riyadh", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3921) },
                    { 6, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3942), false, "Dammam", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3942) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3700), false, "United Arab Emirates", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3719) },
                    { 2, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3739), false, "Saudi Arabia", new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3740) }
                });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4856), "https://www.icons.com/wifi", new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4866), "https://www.icons.com/parking", new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IconURL", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4874), "https://www.icons.com/Spa", new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4890), "$2a$11$6ORDD13KHSKViKiHDNPjkuqcWWZkqBiYIjcHfEOBEVPZid5mMWg9O", new DateTime(2022, 3, 13, 10, 44, 13, 455, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4051), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4108), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4209), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4299), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4309), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "CountryId", "CreatedOn", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3967), new DateTime(2022, 3, 13, 10, 44, 13, 702, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CountryId",
                table: "Hotels",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Countries_CountryId",
                table: "Hotels",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Countries_CountryId",
                table: "Hotels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CountryId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Hotels");

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
