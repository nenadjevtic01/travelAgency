using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class UpdatedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodation_AccommodationsType_AccommodationTypeId",
                table: "Accommodation");

            migrationBuilder.DropForeignKey(
                name: "FK_Accommodation_Destination_DestinationId",
                table: "Accommodation");

            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_AttractionCategory_AttractionCategoryId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_Destination_DestinationId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_AttractionImage_Attraction_AttractionId",
                table: "AttractionImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Climate_Destination_DestinationId",
                table: "Climate");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination");

            migrationBuilder.DropForeignKey(
                name: "FK_DestinationImage_Destination_DestinationId",
                table: "DestinationImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryActivity_Itinerary_ItineraryId",
                table: "ItineraryActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Trip_TripId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Accommodation_AccommodationId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomNumber_Accommodation_AccommodationId",
                table: "RoomNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomNumber_RoomType_RoomTypeId",
                table: "RoomNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_Room_RoomId",
                table: "RoomPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Agency_AgencyId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Destination_DestinationId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Itinerary_ItineraryId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Transport_TransportId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_TripPrice_Trip_TripId",
                table: "TripPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Agency_AgencyId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_Destination_DestinationId",
                table: "UserFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_User_UserId",
                table: "UserFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Trip",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ReservationRoom",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodation_AccommodationsType_AccommodationTypeId",
                table: "Accommodation",
                column: "AccommodationTypeId",
                principalTable: "AccommodationsType",
                principalColumn: "AccommodationTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodation_Destination_DestinationId",
                table: "Accommodation",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_AttractionCategory_AttractionCategoryId",
                table: "Attraction",
                column: "AttractionCategoryId",
                principalTable: "AttractionCategory",
                principalColumn: "AttractionCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_Destination_DestinationId",
                table: "Attraction",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionImage_Attraction_AttractionId",
                table: "AttractionImage",
                column: "AttractionId",
                principalTable: "Attraction",
                principalColumn: "AttractionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Climate_Destination_DestinationId",
                table: "Climate",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country",
                column: "VisaId",
                principalTable: "Visa",
                principalColumn: "VisaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationImage_Destination_DestinationId",
                table: "DestinationImage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryActivity_Itinerary_ItineraryId",
                table: "ItineraryActivity",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Trip_TripId",
                table: "Reservation",
                column: "TripId",
                principalTable: "Trip",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Accommodation_AccommodationId",
                table: "Room",
                column: "AccommodationId",
                principalTable: "Accommodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomNumber_Accommodation_AccommodationId",
                table: "RoomNumber",
                column: "AccommodationId",
                principalTable: "Accommodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomNumber_RoomType_RoomTypeId",
                table: "RoomNumber",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_Room_RoomId",
                table: "RoomPrice",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Agency_AgencyId",
                table: "Trip",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Destination_DestinationId",
                table: "Trip",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Itinerary_ItineraryId",
                table: "Trip",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Transport_TransportId",
                table: "Trip",
                column: "TransportId",
                principalTable: "Transport",
                principalColumn: "TransportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripPrice_Trip_TripId",
                table: "TripPrice",
                column: "TripId",
                principalTable: "Trip",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Agency_AgencyId",
                table: "User",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase",
                column: "UseCaseId",
                principalTable: "UseCase",
                principalColumn: "UseCaseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodation_AccommodationsType_AccommodationTypeId",
                table: "Accommodation");

            migrationBuilder.DropForeignKey(
                name: "FK_Accommodation_Destination_DestinationId",
                table: "Accommodation");

            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_AttractionCategory_AttractionCategoryId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Attraction_Destination_DestinationId",
                table: "Attraction");

            migrationBuilder.DropForeignKey(
                name: "FK_AttractionImage_Attraction_AttractionId",
                table: "AttractionImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Climate_Destination_DestinationId",
                table: "Climate");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination");

            migrationBuilder.DropForeignKey(
                name: "FK_DestinationImage_Destination_DestinationId",
                table: "DestinationImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryActivity_Itinerary_ItineraryId",
                table: "ItineraryActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Trip_TripId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Accommodation_AccommodationId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomNumber_Accommodation_AccommodationId",
                table: "RoomNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomNumber_RoomType_RoomTypeId",
                table: "RoomNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomPrice_Room_RoomId",
                table: "RoomPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Agency_AgencyId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Destination_DestinationId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Itinerary_ItineraryId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Transport_TransportId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_TripPrice_Trip_TripId",
                table: "TripPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Agency_AgencyId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_Destination_DestinationId",
                table: "UserFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavorites_User_UserId",
                table: "UserFavorites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase");

            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "City",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Trip",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ReservationRoom",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodation_AccommodationsType_AccommodationTypeId",
                table: "Accommodation",
                column: "AccommodationTypeId",
                principalTable: "AccommodationsType",
                principalColumn: "AccommodationTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodation_Destination_DestinationId",
                table: "Accommodation",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_AttractionCategory_AttractionCategoryId",
                table: "Attraction",
                column: "AttractionCategoryId",
                principalTable: "AttractionCategory",
                principalColumn: "AttractionCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attraction_Destination_DestinationId",
                table: "Attraction",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionImage_Attraction_AttractionId",
                table: "AttractionImage",
                column: "AttractionId",
                principalTable: "Attraction",
                principalColumn: "AttractionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Climate_Destination_DestinationId",
                table: "Climate",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_Visa_VisaId",
                table: "Country",
                column: "VisaId",
                principalTable: "Visa",
                principalColumn: "VisaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationImage_Destination_DestinationId",
                table: "DestinationImage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryActivity_Itinerary_ItineraryId",
                table: "ItineraryActivity",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Trip_TripId",
                table: "Reservation",
                column: "TripId",
                principalTable: "Trip",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Accommodation_AccommodationId",
                table: "Room",
                column: "AccommodationId",
                principalTable: "Accommodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomNumber_Accommodation_AccommodationId",
                table: "RoomNumber",
                column: "AccommodationId",
                principalTable: "Accommodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomNumber_RoomType_RoomTypeId",
                table: "RoomNumber",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomPrice_Room_RoomId",
                table: "RoomPrice",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Safety_Country_CountryId",
                table: "Safety",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Agency_AgencyId",
                table: "Trip",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "AgencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Destination_DestinationId",
                table: "Trip",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Itinerary_ItineraryId",
                table: "Trip",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Transport_TransportId",
                table: "Trip",
                column: "TransportId",
                principalTable: "Transport",
                principalColumn: "TransportId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripPrice_Trip_TripId",
                table: "TripPrice",
                column: "TripId",
                principalTable: "Trip",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Agency_AgencyId",
                table: "User",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "AgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorites_Destination_DestinationId",
                table: "UserFavorites",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavorites_User_UserId",
                table: "UserFavorites",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCase_UseCase_UseCaseId",
                table: "UserUseCase",
                column: "UseCaseId",
                principalTable: "UseCase",
                principalColumn: "UseCaseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
