using Microsoft.EntityFrameworkCore.Migrations;

namespace Best_Hackathon_Codiseea.Data.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskName",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "TeamTasks",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Task",
                table: "Answers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Task",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "TeamTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Answers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "TaskName",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
