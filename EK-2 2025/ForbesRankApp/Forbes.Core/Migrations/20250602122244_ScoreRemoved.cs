using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forbes.Core.Migrations
{
    /// <inheritdoc />
    public partial class ScoreRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "Categories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
