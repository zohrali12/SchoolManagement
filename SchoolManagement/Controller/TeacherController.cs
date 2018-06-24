using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Controller
{
    class TeacherController
    {
        public static void Create()
        {
            string Name = AddTeacher.TeacherName;
            string Surname = AddTeacher.TeacherSurname;
            int Age = AddTeacher.TeacherAge;
            string Login = AddTeacher.TeacherLogin;
            string Password = AddTeacher.TeacherPassword;

            var newTeacher = new Teacher(Name, Surname, Age,Login,Password);
            Entity.Teachers.Add(newTeacher);

        }
        public static string Show()
        {
            string info = "";
            foreach (var item in Entity.Teachers)
            {
                info += item.Name + " " + item.Surname + " " + item.Age + "\r\n";
            }
            return info;
        }
    }
}
