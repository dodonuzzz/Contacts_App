using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Ziyaaaaaaaa.Models;

namespace Ziyaaaaaaaa.Controllers
{
    public class StudentController : Controller
    {
        private IList<Student> studentList = new List<Student>(){
            new Student() { StudentId = 1, StudentName = "Doğukan", Age = 23 } ,
            new Student() { StudentId = 2, StudentName = "Sabiha",  Age = 19 } ,
            new Student() { StudentId = 3, StudentName = "Ege",  Age = 23 } ,
            new Student() { StudentId = 4, StudentName = "İsmail" , Age = 22 } ,
            new Student() { StudentId = 5, StudentName = "Berfin" , Age = 27 } ,
            new Student() { StudentId = 6, StudentName = "Sercan" , Age = 23 } ,
            new Student() { StudentId = 7, StudentName = "Lionel" , Age = 23 }
        };

        public int Id { get; private set; }

        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here
            return View(studentList.OrderBy(s => s.StudentId).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);

        }
        public ActionResult EditById(int id, string name)
        {
            // do something here

            return View();
        }

        [HttpPost]
        public ActionResult EditStudent(Student std)
        {
            var existingStudent = studentList.FirstOrDefault(s => s.StudentId == std.StudentId);
            if (existingStudent != null)
            {
                existingStudent.StudentName = std.StudentName;
                existingStudent.Age = std.Age;
            }

            return RedirectToAction("Index");
        }
        

        [HttpPost]
        public ActionResult EditIsimYas(FormCollection values)
        {
            var name = values["StudentName"];
            var age = values["Age"];
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit_Page([Bind(Include = "StudentId, StudentName, Age")] Student std)
        {
            var name = std.StudentName;

            //write code to update student 

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit_Sayfasi([Bind(Exclude = "")] Student std)
        {
            var name = std.StudentName;

            //write code to update student 

            return RedirectToAction("Index");
        }
    }
    

    
}

