using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ahoy_Hotel_API.Migrations
{
    public partial class AddNewColumnsToBokking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentificationID",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationType",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 3, 12, 13, 12, 48, 873, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(35), new DateTime(2022, 3, 12, 13, 12, 48, 874, DateTimeKind.Local).AddTicks(37) });

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
                columns: new[] { "CreatedOn", "Description", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(809), "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai�s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.", new DateTime(2022, 3, 12, 13, 12, 49, 91, DateTimeKind.Local).AddTicks(823) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IdentificationType",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7708), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7742), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7757), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7772), "58290ea57011ff102f2", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7824), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "HotelFacilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7831), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7852), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "HotelImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7860), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7791), "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai’s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7869), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7881), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7892), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7900), new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7901) });
        }
    }
}
