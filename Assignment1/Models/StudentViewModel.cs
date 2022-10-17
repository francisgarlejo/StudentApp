/* Assignment 1.sln
 * Assignment 1 - Student App
 * 
 * Revision History:
 *      Francis Gerald Garlejo 
 *      2022.06.10: Created, 
 *      2022.07.10: Revised,
 *      2022.09.10: Finalized
 */

using Assignment1.Entities;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class StudentViewModel
    {
        public List<StudyProgram>? StudyProgram { get; set; }

        public Student ActiveStudent { get; set; }

        [Required(ErrorMessage = "Please enter a valid Date of Birth.")]
        public DateTime DOB { get; set; }
    }
}
