using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class newChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers");

            migrationBuilder.RenameTable(
                name: "Subscribers",
                newName: "Subscribes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribes",
                table: "Subscribes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribes",
                table: "Subscribes");

            migrationBuilder.RenameTable(
                name: "Subscribes",
                newName: "Subscribers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers",
                column: "Id");
        }
    }
}
