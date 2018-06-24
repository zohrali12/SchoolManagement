using SchoolManagement.Controller;
using SchoolManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

       
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent obj = new AddStudent();
            obj.ShowDialog();
            this.Close();
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
            this.Close();
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeacher obj = new AddTeacher();
            obj.ShowDialog();
            this.Close();
        }

        

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClass obj = new AddClass();
            obj.ShowDialog();
            this.Close();
        }

        private void btn_show_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowStudents obj = new ShowStudents();
            obj.tb_students_list.Text = StudentController.Show(); 
            obj.ShowDialog();
            this.Close();
        }

        private void btn_show_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowTeachers obj = new ShowTeachers();
            obj.tb_teachers_list.Text = TeacherController.Show();
            obj.ShowDialog();
            this.Close();
        }

        private void btn_show_class_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowClasses obj = new ShowClasses();
            obj.tb_classes_list.Text = ClassController.Show();
            obj.ShowDialog();
            this.Close();
        }
    }
}
