using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class UpdatedAgencyEntityAddedCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Agency",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Agency");
        }
    }
}
