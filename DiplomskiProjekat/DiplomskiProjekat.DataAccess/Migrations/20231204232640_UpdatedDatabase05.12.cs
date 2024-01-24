using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class UpdatedDatabase0512 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_VisaId",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Documentation",
                table: "Visa");

            migrationBuilder.DropColumn(
                name: "VisaId",
                table: "Country");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Visa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Visa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "Visa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Visa_CountryId",
                table: "Visa",
                column: "CountryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visa_Country_CountryId",
                table: "Visa",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visa_Country_CountryId",
                table: "Visa");

            migrationBuilder.DropIndex(
                name: "IX_Visa_CountryId",
                table: "Visa");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Visa");

            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "Visa");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Visa",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Documentation",
                table: "Visa",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VisaId",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Country_VisaId",
                table: "Country",
                column: "VisaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country",
                column: "VisaId",
                principalTable: "Visa",
                principalColumn: "VisaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
