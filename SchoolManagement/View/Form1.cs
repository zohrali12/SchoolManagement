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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            

            foreach (var student in Entity.Students)
            {
                if (tb_login.Text == student.Login && tb_password.Text == student.Password)
                {
                        this.Hide();
                        StudentProfile obj = new StudentProfile();
                        obj.lb_student_profil_name.Text = student.Name;
                        obj.lb_student_profil_surname.Text = student.Surname;
                        obj.lb_student_profil_age.Text = student.Age.ToString();
                        obj.ShowDialog();
                        this.Close();
                }
            }
            foreach (var teacher in Entity.Teachers)
            {
                if (tb_login.Text == teacher.Login && tb_password.Text == teacher.Password)
                {
                    this.Hide();
                    TeacherProfile obj = new TeacherProfile();
                    obj.lb_teacher_profil_name.Text = teacher.Name;
                    obj.lb_teacher_profil_surname.Text = teacher.Surname;
                    obj.lb_teacher_profil_age.Text = teacher.Age.ToString();
                    obj.ShowDialog();
                    this.Close();
                }
            }

            if (tb_login.Text == "a" && tb_password.Text == "a")
            {
                this.Hide();
                AdminPanel obj = new AdminPanel();
                obj.ShowDialog();
                this.Close();
            }

            else
            {
                lb_warn.Text = "login or password is incorrect";
                lb_warn.ForeColor = Color.Red;
            }


        }
    }
}
