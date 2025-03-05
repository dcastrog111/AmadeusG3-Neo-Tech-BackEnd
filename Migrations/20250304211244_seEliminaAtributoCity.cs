using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmadeusG3_Neo_Tech_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class seEliminaAtributoCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityEurope",
                table: "Cities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityEurope",
                table: "Cities",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
