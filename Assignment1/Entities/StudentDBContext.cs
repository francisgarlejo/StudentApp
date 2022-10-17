/* Assignment 1.sln
 * Assignment 1 - Student App
 * 
 * Revision History:
 *      Francis Gerald Garlejo 
 *      2022.06.10: Created, 
 *      2022.07.10: Revised,
 *      2022.09.10: Finalized
 */

using Microsoft.EntityFrameworkCore;

namespace Assignment1.Entities
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<StudyProgram> StudyPrograms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudyProgram>().HasData(
                new StudyProgram() { StudyProgramId = "A", Name = "Computer Programming" },
                new StudyProgram() { StudyProgramId = "B", Name = "Bachelor of Applied Science" },
                new StudyProgram() { StudyProgramId = "C", Name = "Computer Programmer Analyst" },
                new StudyProgram() { StudyProgramId = "D", Name = "IT Innovation and Design" },
                new StudyProgram() { StudyProgramId = "E", Name = "Application and Web Design" },
                new StudyProgram() { StudyProgramId = "F", Name = "Infrastructure Engineer" },
                new StudyProgram() { StudyProgramId = "G", Name = "Software Engineer" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    Age = 51,
                    GPA = 2.8,
                    GpaScale = "Satisfactory",
                    StudyProgramId = "A"
                },
                new Student()
                {
                    StudentId = 2,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    Age = 49,
                    GPA = 4.0,
                    GpaScale = "Excellent",
                    StudyProgramId = "B"
                },
                new Student()
                {
                    StudentId = 3,
                    FirstName = "Maggie",
                    LastName = "Simpson",
                    Age = 46,
                    GPA = 3.1,
                    GpaScale = "Good",
                    StudyProgramId = "C"
                }

            );
        }
    }
}
