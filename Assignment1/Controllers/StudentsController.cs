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
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class StudentsController : Controller
    {
        private StudentDBContext _studentDbContext;
        StudentService studentService;

        public StudentsController(StudentDBContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }


        [HttpGet()]
        public IActionResult List()
        {
            var allStudents = _studentDbContext.Students.Include(s => s.StudyProgram).OrderBy(s => s.FirstName).ToList();
            return View(allStudents);
        }

        [HttpGet()]
        public IActionResult Create()
        {
            StudentViewModel studentViewModel = new StudentViewModel()
            {
                StudyProgram = _studentDbContext.StudyPrograms.OrderBy(g => g.Name).ToList(),
                ActiveStudent = new Student()
            };

            return View(studentViewModel);
        }

        [HttpPost()]
        public IActionResult Create(StudentViewModel studentViewModel)
        {
            studentService = new StudentService();
            string getGpaScale = studentService.GetGpaScale(studentViewModel.ActiveStudent.GPA);
            studentViewModel.ActiveStudent.GpaScale = getGpaScale;

            int age = studentService.GetAge(studentViewModel.DOB);
            studentViewModel.ActiveStudent.Age = age;

            if (ModelState.IsValid)
            {
                _studentDbContext.Students.Add(studentViewModel.ActiveStudent);
                _studentDbContext.SaveChanges();
                return RedirectToAction("List", "Students");
            }
            else
            {
                studentViewModel.StudyProgram = _studentDbContext.StudyPrograms.OrderBy(g => g.Name).ToList();
                return View(studentViewModel);
            }
        }
    }
}
