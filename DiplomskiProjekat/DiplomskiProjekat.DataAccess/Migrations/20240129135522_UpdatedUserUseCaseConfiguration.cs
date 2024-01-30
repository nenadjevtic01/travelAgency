using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class UpdatedUserUseCaseConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCase_User_UserId",
                table: "UserUseCase");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCase_User_UserId",
                table: "UserUseCase",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCase_User_UserId",
                table: "UserUseCase");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCase_User_UserId",
                table: "UserUseCase",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
