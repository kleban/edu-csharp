using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StdPerfomance.Core.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StressLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StressLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudyHours = table.Column<int>(type: "int", nullable: false),
                    SleepHours = table.Column<int>(type: "int", nullable: false),
                    SocialMediaHours = table.Column<int>(type: "int", nullable: false),
                    ExamScore = table.Column<int>(type: "int", nullable: false),
                    StressLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentScores_StressLevels_StressLevelId",
                        column: x => x.StressLevelId,
                        principalTable: "StressLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentScores_StressLevelId",
                table: "StudentScores",
                column: "StressLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentScores");

            migrationBuilder.DropTable(
                name: "StressLevels");
        }
    }
}
