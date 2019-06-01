using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoLab2.Migrations
{
    public partial class Rename_the_Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskImportanceId",
                table: "Taskuri");

            migrationBuilder.AddColumn<int>(
                name: "TaskImportance",
                table: "Taskuri",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskImportance",
                table: "Taskuri");

            migrationBuilder.AddColumn<int>(
                name: "TaskImportanceId",
                table: "Taskuri",
                nullable: false,
                defaultValue: 0);
        }
    }
}
