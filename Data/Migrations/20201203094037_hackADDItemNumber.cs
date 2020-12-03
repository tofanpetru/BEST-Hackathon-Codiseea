using Microsoft.EntityFrameworkCore.Migrations;

namespace Best_Hackathon_Codiseea.Data.Migrations
{
    public partial class hackADDItemNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                table: "TeamTasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemNumber",
                table: "TeamTasks");
        }
    }
}
