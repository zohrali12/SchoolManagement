using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Controller
{
    class StudentController
    {

        public static void Create()
        {
            string Name = AddStudent.StudentName;
            string Surname = AddStudent.StudentSurname;
            int Age = AddStudent.StudentAge;
            string Login = AddStudent.StudentLogin;
            string Password = AddStudent.StudentPassword;

            var newStudent = new Student(Name,Surname,Age,Login,Password);
            Entity.Students.Add(newStudent);

        }
        public static string Show()
        {
            string info = "";
            foreach (var item in Entity.Students)
            {
                info += item.Name + " " + item.Surname + " " + item.Age+"\r\n";
            }
            return info;
        }

    }
}
