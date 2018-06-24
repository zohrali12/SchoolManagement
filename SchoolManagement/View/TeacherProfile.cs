using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.View
{
    public partial class TeacherProfile : Form
    {
        public TeacherProfile()
        {
            InitializeComponent();
        }

        private void btn_teacherProfile_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
            this.Close();
        }
    }
}
