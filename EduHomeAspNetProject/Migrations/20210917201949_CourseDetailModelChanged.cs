using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class CourseDetailModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasDeleted",
                table: "Courses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CourseDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AboutCourse",
                table: "CourseDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HasDeleted",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CourseDetails",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AboutCourse",
                table: "CourseDetails",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
