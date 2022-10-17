using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudyPrograms",
                columns: table => new
                {
                    StudyProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPrograms", x => x.StudyProgramId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    GpaScale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyProgramId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
                        principalColumn: "StudyProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "StudyProgramId", "Name" },
                values: new object[,]
                {
                    { "A", "Computer Programming" },
                    { "B", "Bachelor of Applied Science" },
                    { "C", "Computer Programmer Analyst" },
                    { "D", "IT Innovation and Design" },
                    { "E", "Application and Web Design" },
                    { "F", "Infrastructure Engineer" },
                    { "G", "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "GpaScale", "LastName", "StudyProgramId" },
                values: new object[] { 1, 51, "Bart", 2.7999999999999998, "Satisfactory", "Simpson", "A" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "GpaScale", "LastName", "StudyProgramId" },
                values: new object[] { 2, 49, "Lisa", 4.0, "Excellent", "Simpson", "B" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "FirstName", "GPA", "GpaScale", "LastName", "StudyProgramId" },
                values: new object[] { 3, 46, "Maggie", 3.1000000000000001, "Good", "Simpson", "C" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudyProgramId",
                table: "Students",
                column: "StudyProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudyPrograms");
        }
    }
}
