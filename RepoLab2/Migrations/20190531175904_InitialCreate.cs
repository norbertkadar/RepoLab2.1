using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoLab2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Statuses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Statuses", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TasksImportance",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TasksImportance", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Taskuri",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Title = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: true),
            //        DateAdded = table.Column<DateTime>(nullable: false),
            //        Deadline = table.Column<DateTime>(nullable: false),
            //        ClosedAt = table.Column<DateTime>(nullable: false),
            //        StatusId = table.Column<int>(nullable: false),
            //        TaskImportanceId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Taskuri", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Taskuri_Statuses_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Statuses",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Taskuri_TasksImportance_TaskImportanceId",
            //            column: x => x.TaskImportanceId,
            //            principalTable: "TasksImportance",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Text = table.Column<string>(nullable: true),
            //        Important = table.Column<bool>(nullable: false),
            //        TaskulId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Comments_Taskuri_TaskulId",
            //            column: x => x.TaskulId,
            //            principalTable: "Taskuri",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_TaskulId",
            //    table: "Comments",
            //    column: "TaskulId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Taskuri_StatusId",
            //    table: "Taskuri",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Taskuri_TaskImportanceId",
            //    table: "Taskuri",
            //    column: "TaskImportanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Taskuri");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TasksImportance");
        }
    }
}
