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

namespace Assignment1.Services
{
    public class StudentService
    {
        public string GetGpaScale(double? gpaGrade)
        {
            string gpaScale = string.Empty;

            if (gpaGrade >= 4.0)
            {
                gpaScale = "Excellent";
            }else if (gpaGrade >= 3.5 && gpaGrade <= 3.9)
            {
                gpaScale = "Very Good";
            }
            else if (gpaGrade >= 3.0 && gpaGrade <= 3.4)
            {
                gpaScale = "Good";
            }
            else if (gpaGrade >= 2.5 && gpaGrade <= 2.9)
            {
                gpaScale = "Satisfactory";
            }
            else
            {
                gpaScale = "Unsatisfactory";
            }

            return gpaScale;
        }

        public int GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

    }
}
