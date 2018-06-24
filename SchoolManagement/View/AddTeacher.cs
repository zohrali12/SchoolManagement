using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Controller;

namespace SchoolManagement
{
    public partial class AddTeacher : Form
    {
        public static string TeacherName;
        public static string TeacherSurname;
        public static int TeacherAge;
        public static string TeacherLogin;
        public static string TeacherPassword;
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            TeacherName = tb_teacher_name.Text;
            TeacherSurname = tb_teacher_surname.Text;
            TeacherAge = Convert.ToInt32(tb_teacher_age.Text);
            TeacherLogin = tb_teacher_login.Text;
            TeacherPassword = tb_teacher_password.Text;
            TeacherController.Create();
        }

        private void btn_back_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel obj = new AdminPanel();
            obj.ShowDialog();
            this.Close();
        }
    }
}
