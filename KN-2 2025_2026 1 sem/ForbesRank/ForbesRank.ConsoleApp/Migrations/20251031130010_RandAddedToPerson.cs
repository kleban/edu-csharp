using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForbesRank.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class RandAddedToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "People");
        }
    }
}
