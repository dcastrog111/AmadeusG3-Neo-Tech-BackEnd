using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmadeusG3_Neo_Tech_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AgregarStockAProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityAmerica",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "CityEurope",
                table: "Answers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityAmerica",
                table: "Answers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityEurope",
                table: "Answers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
