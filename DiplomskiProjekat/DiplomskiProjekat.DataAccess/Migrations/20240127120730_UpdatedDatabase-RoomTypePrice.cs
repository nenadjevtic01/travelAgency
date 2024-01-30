using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class UpdatedDatabaseRoomTypePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationRoom_Room_RoomId",
                table: "ReservationRoom");

            migrationBuilder.DropTable(
                name: "RoomPrice");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "ReservationRoom",
                newName: "RoomTypePriceId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationRoom_RoomId",
                table: "ReservationRoom",
                newName: "IX_ReservationRoom_RoomTypePriceId");

            migrationBuilder.AddColumn<int>(
                name: "AccommodationId",
                table: "ReservationRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ReservationRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RoomTypePrice",
                columns: table => new
                {
                    RoomTypePriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccommodationId = table.Column<int>(type: "int", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypePrice", x => x.RoomTypePriceId);
                    table.ForeignKey(
                        name: "FK_RoomTypePrice_Accommodation_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodation",
                        principalColumn: "AccommodationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomTypePrice_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_AccommodationId",
                table: "ReservationRoom",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypePrice_AccommodationId",
                table: "RoomTypePrice",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypePrice_RoomTypeId",
                table: "RoomTypePrice",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationRoom_Accommodation_AccommodationId",
                table: "ReservationRoom",
                column: "AccommodationId",
                principalTable: "Accommodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationRoom_RoomTypePrice_RoomTypePriceId",
                table: "ReservationRoom",
                column: "RoomTypePriceId",
                principalTable: "RoomTypePrice",
                principalColumn: "RoomTypePriceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationRoom_Accommodation_AccommodationId",
                table: "ReservationRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationRoom_RoomTypePrice_RoomTypePriceId",
                table: "ReservationRoom");

            migrationBuilder.DropTable(
                name: "RoomTypePrice");

            migrationBuilder.DropIndex(
                name: "IX_ReservationRoom_AccommodationId",
                table: "ReservationRoom");

            migrationBuilder.DropColumn(
                name: "AccommodationId",
                table: "ReservationRoom");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ReservationRoom");

            migrationBuilder.RenameColumn(
                name: "RoomTypePriceId",
                table: "ReservationRoom",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationRoom_RoomTypePriceId",
                table: "ReservationRoom",
                newName: "IX_ReservationRoom_RoomId");

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccommodationId = table.Column<int>(type: "int", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    AC = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Balcony = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Accommodation_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodation",
                        principalColumn: "AccommodationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomPrice",
                columns: table => new
                {
                    RoomPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPrice", x => x.RoomPriceId);
                    table.ForeignKey(
                        name: "FK_RoomPrice_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_AccommodationId",
                table: "Room",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPrice_RoomId",
                table: "RoomPrice",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationRoom_Room_RoomId",
                table: "ReservationRoom",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
