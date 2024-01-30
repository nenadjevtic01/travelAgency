using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class RemovedUseCaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase");

            migrationBuilder.DropTable(
                name: "UseCase");

            migrationBuilder.DropIndex(
                name: "IX_UserUseCase_UseCaseId",
                table: "UserUseCase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UseCase",
                columns: table => new
                {
                    UseCaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseCaseDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UseCaseName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCase", x => x.UseCaseId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserUseCase_UseCaseId",
                table: "UserUseCase",
                column: "UseCaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase",
                column: "UseCaseId",
                principalTable: "UseCase",
                principalColumn: "UseCaseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
