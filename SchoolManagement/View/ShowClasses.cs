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
    public partial class ShowClasses : Form
    {
        public ShowClasses()
        {
            InitializeComponent();
        }

        private void btn_back_class_show_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel obj = new AdminPanel();
            obj.ShowDialog();
            this.Close();
        }
    }
}
