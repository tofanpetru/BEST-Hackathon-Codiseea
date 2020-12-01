using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Best_Hackathon_Codiseea.Data.Migrations
{
    public partial class functional_bd_hackathon1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TeamTasks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TeamTasks");
        }
    }
}
