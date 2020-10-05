using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2ButtonStudent_Click(object sender, EventArgs e)
        {
            FormLoginStudent formStudent = new FormLoginStudent();
            formStudent.Owner = this;
            formStudent.Show();
        }

        private void guna2ButtonAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formAdmin = new FormLoginAdmin();
            formAdmin.Owner = this;
            formAdmin.Show();
        }

        private void guna2ButtonInstructor_Click(object sender, EventArgs e)
        {
            FormLoginInstructor formInstructor = new FormLoginInstructor();
            formInstructor.Owner = this;
            formInstructor.Show();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
