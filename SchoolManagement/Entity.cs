using SchoolManagement.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagement
{
    class Entity
    {
        public static CustomList<Student> Students= new CustomList<Student>();
        public static CustomList<Teacher> Teachers = new CustomList<Teacher>();
        public static CustomList<Class> Classes = new CustomList<Class>();
        public static ArrayList Users = new ArrayList();
    }
}
