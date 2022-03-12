using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ahoy_Hotel_API.Migrations
{
    public partial class InitailCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelFacilities_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelFacilities_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelImages_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<int>(type: "int", nullable: false),
                    NoOfGuests = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    PaidAmount = table.Column<double>(type: "float", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "CreatedOn", "IconURL", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7708), "https://www.icons.com/breakfast", false, "Breakfast", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7718) },
                    { 2, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7742), "https://www.icons.com/breakfast", false, "Wifi", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7743) },
                    { 3, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7750), "https://www.icons.com/breakfast", false, "Parking", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7751) },
                    { 4, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7757), "https://www.icons.com/breakfast", false, "Spa", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7758) }
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "CreatedOn", "Email", "FullName", "IsDeleted", "Password", "UpdatedOn" },
                values: new object[] { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7772), "yassineltayeb@live.com", "Guest User", false, "58290ea57011ff102f2", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CreatedOn", "Description", "Email", "IsDeleted", "Location", "Name", "PhoneNumber", "UpdatedOn" },
                values: new object[] { 1, "Sheikh Rashid Road, Wafi Mall, Bur Dubai, Dubai, United Arab Emirates", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7791), "Inspired by the great pyramids of Egypt, Raffles Dubai is a stunning landmark in Dubai’s skyline. This award-winning hotel features an outdoor pool, an extensive spa and free in-room WiFi.", "guests@rafflesdubai.com", false, "https://www.google.com/maps/dir/25.267754,55.3475338/Raffles+Dubai/@25.247935,55.2678204,12z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x3e5f5d4a2139ede3:0x6d83d44701a241ab!2m2!1d55.3203503!2d25.227917", "Raffles Dubai", "05555555", new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.InsertData(
                table: "HotelFacilities",
                columns: new[] { "Id", "CreatedOn", "FacilityId", "HotelId", "IsDeleted", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7808), 1, 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7808) },
                    { 2, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7816), 2, 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7816) },
                    { 3, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7824), 3, 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7824) },
                    { 4, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7831), 4, 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7832) }
                });

            migrationBuilder.InsertData(
                table: "HotelImages",
                columns: new[] { "Id", "CreatedOn", "HotelId", "IsDeleted", "UpdatedOn", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7842), 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7842), "https://www.images.com/image1" },
                    { 2, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7852), 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7853), "https://www.images.com/image2" },
                    { 3, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7860), 1, false, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7861), "https://www.images.com/image3" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedOn", "Description", "GuestId", "HotelId", "IsDeleted", "Rating", "UpdatedOn" },
                values: new object[] { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7869), "The entire experience from check-in to check out. Great staffs, room, decoration, food, facilities. Also, very nice attentions have been offered for our special occasion :)", 1, 1, false, 5, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedOn", "HotelId", "IsDeleted", "NoOfGuests", "Price", "RoomNo", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7881), 1, false, 2, 680.0, 101, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7882) },
                    { 2, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7892), 1, false, 2, 680.0, 102, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7893) },
                    { 3, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7900), 1, false, 2, 680.0, 103, new DateTime(2022, 3, 11, 23, 45, 33, 474, DateTimeKind.Local).AddTicks(7901) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestId",
                table: "Bookings",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelFacilities_FacilityId",
                table: "HotelFacilities",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelFacilities_HotelId",
                table: "HotelFacilities",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelImages_HotelId",
                table: "HotelImages",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GuestId",
                table: "Reviews",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelId",
                table: "Reviews",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "HotelFacilities");

            migrationBuilder.DropTable(
                name: "HotelImages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
