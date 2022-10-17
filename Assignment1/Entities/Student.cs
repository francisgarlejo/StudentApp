/* Assignment 1.sln
 * Assignment 1 - Student App
 * 
 * Revision History:
 *      Francis Gerald Garlejo 
 *      2022.06.10: Created, 
 *      2022.07.10: Revised,
 *      2022.09.10: Finalized
 */


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }

        public int? Age { get; set; }
        
        [Required(ErrorMessage = "Please enter a GPA.")]
        [Range(1.0, 4.0, ErrorMessage = "GPA must be between 1.0 and 4.0.")]
        public double? GPA { get; set; }

        public string? GpaScale { get; set; }

        [Required(ErrorMessage = "Please specify a program.")]
        public string? StudyProgramId { get; set; }

        public StudyProgram? StudyProgram { get; set; }
    }
}
