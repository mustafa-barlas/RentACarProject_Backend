using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "UnitsİnPrice",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "UnitsİnStock",
                table: "cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Property",
                table: "brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "rentals",
                columns: table => new
                {
                    RentalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RentalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadlineTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentals", x => x.RentalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rentals");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "Property",
                table: "brands");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitsİnPrice",
                table: "cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<short>(
                name: "UnitsİnStock",
                table: "cars",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
