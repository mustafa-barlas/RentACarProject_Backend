using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_dtosss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "brands");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "customers",
                newName: "CustomerCity");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "colors",
                newName: "ColorName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "colors",
                newName: "ColorId");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyPrice",
                table: "cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyPrice",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "CustomerCity",
                table: "customers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "ColorName",
                table: "colors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "colors",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "brands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
