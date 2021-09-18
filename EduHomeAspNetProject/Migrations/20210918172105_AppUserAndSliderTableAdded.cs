using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class AppUserAndSliderTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    FooterPhone1 = table.Column<string>(maxLength: 50, nullable: true),
                    FooterPhone2 = table.Column<string>(maxLength: 50, nullable: true),
                    Logo = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    Facebook = table.Column<string>(maxLength: 50, nullable: true),
                    Pinterest = table.Column<string>(maxLength: 50, nullable: true),
                    Vimeo = table.Column<string>(maxLength: 50, nullable: true),
                    Twitter = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Mail = table.Column<string>(maxLength: 50, nullable: true),
                    Website = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
