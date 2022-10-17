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
using Assignment1.Models;
using Assignment1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class StudentController : Controller
    {
        private StudentDBContext _studentDBContext;
        StudentService studentService;
        public StudentController(StudentDBContext studentDBContext)
        {
            _studentDBContext = studentDBContext;
        }
        [HttpGet()]
        public IActionResult Edit(int id)
        {
            StudentViewModel studentViewModel = new StudentViewModel()
            {
                StudyProgram = _studentDBContext.StudyPrograms.OrderBy(g => g.Name).ToList(),
                ActiveStudent = _studentDBContext.Students.Find(id)
            };

            return View(studentViewModel);
        }

        [HttpPost()]
        public IActionResult Edit(StudentViewModel studentViewModel)
        {
            studentService = new StudentService();
            string getGpaScale = studentService.GetGpaScale(studentViewModel.ActiveStudent.GPA);
            studentViewModel.ActiveStudent.GpaScale = getGpaScale;

            int age = studentService.GetAge(studentViewModel.DOB);
            studentViewModel.ActiveStudent.Age = age;

            if (ModelState.IsValid)
            {
                _studentDBContext.Students.Update(studentViewModel.ActiveStudent);
                _studentDBContext.SaveChanges();
                return RedirectToAction("List", "Students");
            }
            else
            {
                studentViewModel.StudyProgram = _studentDBContext.StudyPrograms.OrderBy(g => g.Name).ToList();
                return View(studentViewModel);
            }
        }

        [HttpGet()]
        public IActionResult Delete(int id)
        {
            var student = _studentDBContext.Students.Find(id);
            return View(student);
        }

        [HttpPost()]
        public IActionResult Delete(Student student)
        {
            _studentDBContext.Students.Remove(student);
            _studentDBContext.SaveChanges();
            return RedirectToAction("List", "Students");
        }
    }
}
