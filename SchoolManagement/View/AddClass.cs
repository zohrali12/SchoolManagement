using SchoolManagement.Controller;
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
    public partial class AddClass : Form
    {
        public static string ClassName;
        public AddClass()
        {
            InitializeComponent();
        }

        private void btn_back_class_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel obj = new AdminPanel();
            obj.ShowDialog();
            this.Close();
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            ClassName = tb_class_name.Text;
            ClassController.Create();
        }
    }
}
