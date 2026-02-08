using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Projects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "TodoItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusDate",
                table: "TodoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_ProjectId",
                table: "TodoItems",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Project_ProjectId",
                table: "TodoItems",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Project_ProjectId",
                table: "TodoItems");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_ProjectId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "StatusDate",
                table: "TodoItems");
        }
    }
}
