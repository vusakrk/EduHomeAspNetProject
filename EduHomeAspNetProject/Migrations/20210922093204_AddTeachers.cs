using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeAspNetProject.Migrations
{
    public partial class AddTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherAbouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession = table.Column<string>(maxLength: 50, nullable: false),
                    About = table.Column<string>(nullable: false),
                    Degree = table.Column<string>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Skype = table.Column<string>(nullable: false),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherAbouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<int>(nullable: false),
                    TeamLeader = table.Column<int>(nullable: false),
                    Development = table.Column<int>(nullable: false),
                    Design = table.Column<int>(nullable: false),
                    Innovation = table.Column<int>(nullable: false),
                    Communication = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherStates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TeachFaculty = table.Column<string>(maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    TeacherAboutId = table.Column<int>(nullable: false),
                    TeacherSkillId = table.Column<int>(nullable: false),
                    TeacherStateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherAbouts_TeacherAboutId",
                        column: x => x.TeacherAboutId,
                        principalTable: "TeacherAbouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherSkills_TeacherSkillId",
                        column: x => x.TeacherSkillId,
                        principalTable: "TeacherSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherStates_TeacherStateId",
                        column: x => x.TeacherStateId,
                        principalTable: "TeacherStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_HobbyId",
                table: "TeacherHobbies",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_TeacherId",
                table: "TeacherHobbies",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherAboutId",
                table: "Teachers",
                column: "TeacherAboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherSkillId",
                table: "Teachers",
                column: "TeacherSkillId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherStateId",
                table: "Teachers",
                column: "TeacherStateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherHobbies");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TeacherAbouts");

            migrationBuilder.DropTable(
                name: "TeacherSkills");

            migrationBuilder.DropTable(
                name: "TeacherStates");
        }
    }
}
