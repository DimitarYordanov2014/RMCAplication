using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMCAplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangingConsumable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inStock",
                table: "Consumables");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "inStock",
                table: "Consumables",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
