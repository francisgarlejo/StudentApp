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

using System.ComponentModel.DataAnnotations;

namespace Assignment1.Entities
{
    public class StudyProgram
    {
        public string StudyProgramId { get; set; }
        public string Name { get; set; }

    }
}
