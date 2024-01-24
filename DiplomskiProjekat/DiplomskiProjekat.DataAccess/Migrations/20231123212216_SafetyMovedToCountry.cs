using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class SafetyMovedToCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Safety_Destination_DestinationId",
                table: "Safety");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "Safety",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Safety_DestinationId",
                table: "Safety",
                newName: "IX_Safety_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Safety",
                newName: "DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_Safety_CountryId",
                table: "Safety",
                newName: "IX_Safety_DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Safety_Destination_DestinationId",
                table: "Safety",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
