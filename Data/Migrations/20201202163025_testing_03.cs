using Microsoft.EntityFrameworkCore.Migrations;

namespace Best_Hackathon_Codiseea.Data.Migrations
{
    public partial class testing_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamTasks",
                table: "TeamTasks");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TeamTasks");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "TeamTasks",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamTasks",
                table: "TeamTasks",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamTasks",
                table: "TeamTasks");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "TeamTasks");

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "TeamTasks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamTasks",
                table: "TeamTasks",
                column: "TaskId");
        }
    }
}
