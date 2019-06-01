using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoLab2.Migrations
{
    public partial class AddedEnum_Status_TaskImp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taskuri_Statuses_StatusId",
                table: "Taskuri");

            migrationBuilder.DropForeignKey(
                name: "FK_Taskuri_TasksImportance_TaskImportanceId",
                table: "Taskuri");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TasksImportance");

            migrationBuilder.DropIndex(
                name: "IX_Taskuri_StatusId",
                table: "Taskuri");

            migrationBuilder.DropIndex(
                name: "IX_Taskuri_TaskImportanceId",
                table: "Taskuri");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Taskuri");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedAt",
                table: "Taskuri",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Taskuri",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Taskuri");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedAt",
                table: "Taskuri",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Taskuri",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasksImportance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksImportance", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Taskuri_StatusId",
                table: "Taskuri",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Taskuri_TaskImportanceId",
                table: "Taskuri",
                column: "TaskImportanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Taskuri_Statuses_StatusId",
                table: "Taskuri",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taskuri_TasksImportance_TaskImportanceId",
                table: "Taskuri",
                column: "TaskImportanceId",
                principalTable: "TasksImportance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
