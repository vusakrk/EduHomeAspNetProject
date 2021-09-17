using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class CourseDetailCertificationDescRowAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificationDesc",
                table: "CourseDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificationDesc",
                table: "CourseDetails");
        }
    }
}
