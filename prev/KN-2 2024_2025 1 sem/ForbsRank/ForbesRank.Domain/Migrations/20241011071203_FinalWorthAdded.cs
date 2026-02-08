using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForbesRank.Domain.Migrations
{
    /// <inheritdoc />
    public partial class FinalWorthAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FinalWorth",
                table: "Persons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalWorth",
                table: "Persons");
        }
    }
}
