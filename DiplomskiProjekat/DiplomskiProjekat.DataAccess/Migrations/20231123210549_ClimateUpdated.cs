using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiplomskiProjekat.DataAccess.Migrations
{
    public partial class ClimateUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageTemperature",
                table: "Climate");

            migrationBuilder.DropColumn(
                name: "Humidity",
                table: "Climate");

            migrationBuilder.DropColumn(
                name: "SeasonEnd",
                table: "Climate");

            migrationBuilder.DropColumn(
                name: "SeasonStart",
                table: "Climate");

            migrationBuilder.AddColumn<string>(
                name: "ClimateInfo",
                table: "Climate",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClimateInfo",
                table: "Climate");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageTemperature",
                table: "Climate",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Humidity",
                table: "Climate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SeasonEnd",
                table: "Climate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SeasonStart",
                table: "Climate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
