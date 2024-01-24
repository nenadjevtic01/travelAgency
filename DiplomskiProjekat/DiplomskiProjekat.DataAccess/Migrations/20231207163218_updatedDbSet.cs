using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class updatedDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_Destination_DestinationId",
                table: "UserFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_User_UserId",
                table: "UserFavorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavorites",
                table: "UserFavorites");

            migrationBuilder.RenameTable(
                name: "UserFavorites",
                newName: "UserFavorite");

            migrationBuilder.RenameIndex(
                name: "IX_UserFavorites_UserId",
                table: "UserFavorite",
                newName: "IX_UserFavorite_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFavorites_DestinationId",
                table: "UserFavorite",
                newName: "IX_UserFavorite_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavorite",
                table: "UserFavorite",
                column: "UserFavoritesId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorite_Destination_DestinationId",
                table: "UserFavorite",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorite_User_UserId",
                table: "UserFavorite",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorite_Destination_DestinationId",
                table: "UserFavorite");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorite_User_UserId",
                table: "UserFavorite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavorite",
                table: "UserFavorite");

            migrationBuilder.RenameTable(
                name: "UserFavorite",
                newName: "UserFavorites");

            migrationBuilder.RenameIndex(
                name: "IX_UserFavorite_UserId",
                table: "UserFavorites",
                newName: "IX_UserFavorites_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFavorite_DestinationId",
                table: "UserFavorites",
                newName: "IX_UserFavorites_DestinationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavorites",
                table: "UserFavorites",
                column: "UserFavoritesId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorites_Destination_DestinationId",
                table: "UserFavorites",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorites_User_UserId",
                table: "UserFavorites",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
