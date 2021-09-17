using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class changeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClassDuration",
                table: "CourseFeatures",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ClassDuration",
                table: "CourseFeatures",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
