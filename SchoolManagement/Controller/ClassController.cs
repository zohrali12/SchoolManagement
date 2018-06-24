using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Controller
{
    class ClassController
    {
        public static void Create()
        {
            string name = AddClass.ClassName;
            Class newClass = new Class(name);
            Entity.Classes.Add(newClass);
        }

        public static string Show()
        {
            string info = "";
            foreach (var item in Entity.Classes)
            {
                info += item.Name + "\r\n";
            }
            return info;
        }
    }
}
