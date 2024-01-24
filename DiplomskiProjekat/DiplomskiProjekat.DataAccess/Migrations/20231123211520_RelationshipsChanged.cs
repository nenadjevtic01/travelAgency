using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class RelationshipsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Safety_SafetyId",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Destination_SafetyId",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Climate_DestinationId",
                table: "Climate");

            migrationBuilder.DropColumn(
                name: "SafetyId",
                table: "Destination");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Safety",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Safety_DestinationId",
                table: "Safety",
                column: "DestinationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Climate_DestinationId",
                table: "Climate",
                column: "DestinationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Safety_Destination_DestinationId",
                table: "Safety",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Safety_Destination_DestinationId",
                table: "Safety");

            migrationBuilder.DropIndex(
                name: "IX_Safety_DestinationId",
                table: "Safety");

            migrationBuilder.DropIndex(
                name: "IX_Climate_DestinationId",
                table: "Climate");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Safety");

            migrationBuilder.AddColumn<int>(
                name: "SafetyId",
                table: "Destination",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destination_SafetyId",
                table: "Destination",
                column: "SafetyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Climate_DestinationId",
                table: "Climate",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Safety_SafetyId",
                table: "Destination",
                column: "SafetyId",
                principalTable: "Safety",
                principalColumn: "SafetyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
