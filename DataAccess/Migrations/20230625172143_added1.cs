using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class added1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rentals_cars_CarId",
                table: "rentals");

            migrationBuilder.DropIndex(
                name: "IX_rentals_CarId",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "rentals");

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cars_RentalId",
                table: "cars",
                column: "RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_rentals_RentalId",
                table: "cars",
                column: "RentalId",
                principalTable: "rentals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_rentals_RentalId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_RentalId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "rentals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_rentals_CarId",
                table: "rentals",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_rentals_cars_CarId",
                table: "rentals",
                column: "CarId",
                principalTable: "cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
