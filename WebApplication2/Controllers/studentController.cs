using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class studentController : ApiController
    {
        jagadeeshEntities JagadeeshEntities = new jagadeeshEntities();
        //get student
        public List<student> Getstudents()
        {
            List<student> student = JagadeeshEntities.students.ToList();
            return student;
        }
        
        public student GetstudentsByID(int id)
        {
            student std = JagadeeshEntities.students.Find(id);
            return std;
        }
        public string Poststudents(student Student)
        {
            student std = new student();
            std.id = Student.id;
            std.name = Student.name;
            std.address = Student.address;
            JagadeeshEntities.students.Add(std);
            JagadeeshEntities.SaveChanges();
            return "the employee is created";
        }
        public string Putstudents(student Student)
        {
            student std = JagadeeshEntities.students.Find(Student.id);
            std.id = Student.id;
            std.name = Student.name;
            std.address = Student.address;
            JagadeeshEntities.SaveChanges();
            return "the employee is updated";
        }
        public string DeletestudentsByID(int id)
        {
            student std = JagadeeshEntities.students.Find(id);
            JagadeeshEntities.students.Remove(std);
            JagadeeshEntities.SaveChanges();
            return "the employee is delete";
        }
    }
}





        
    

