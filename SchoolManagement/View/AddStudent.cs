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
    public partial class AddStudent : Form
    {   public static string StudentName;
        public static string StudentSurname;
        public static string StudentLogin;
        public static string StudentPassword;
        public static int StudentAge;
        public AddStudent()
        {
            InitializeComponent();
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel obj = new AdminPanel();
            obj.ShowDialog();
            this.Close();
        }

        private void btn_add_student_Click_1(object sender, EventArgs e)
        {
            StudentName = tb_Student_Name.Text;
            StudentSurname = tb_Student_Surname.Text;
            StudentAge = Convert.ToInt32(tb_Student_Age.Text);
            StudentLogin = tb_student_login.Text;
            StudentPassword = tb_student_password.Text;
            StudentController.Create();
        }
    }
}
