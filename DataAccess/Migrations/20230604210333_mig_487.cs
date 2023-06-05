using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_487 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyPrice",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "Property",
                table: "brands");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "rentals",
                newName: "DailyPrice");

            migrationBuilder.RenameColumn(
                name: "DeadlineTime",
                table: "rentals",
                newName: "ReturnDate");

            migrationBuilder.RenameColumn(
                name: "CustomerCity",
                table: "customers",
                newName: "CompanyName");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvilable",
                table: "rentals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_CustomerId",
                table: "users",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropColumn(
                name: "IsAvilable",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "rentals",
                newName: "DeadlineTime");

            migrationBuilder.RenameColumn(
                name: "DailyPrice",
                table: "rentals",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "customers",
                newName: "CustomerCity");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyPrice",
                table: "cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
        }
    }
}
