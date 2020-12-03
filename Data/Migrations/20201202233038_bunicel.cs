using Microsoft.EntityFrameworkCore.Migrations;

namespace Best_Hackathon_Codiseea.Data.Migrations
{
    public partial class bunicel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Attempts",
                table: "TeamTasks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attempts",
                table: "TeamTasks");
        }
    }
}
