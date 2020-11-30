using Database;
using System;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormLogin : Form
    {
        Session session = Session.Instance;
        public FormLogin()
        {
            InitializeComponent();
        }

        public void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2ButtonStudent_Click(object sender, EventArgs e)
        {
            FormLoginStudent formStudent = new FormLoginStudent();
            formStudent.FormClosed += delegate
            {
                if (session.Name != "")
                {
                    Owner.Enabled = true;
                    this.Close();
                }
            };
            formStudent.ShowDialog();
        }

        private void guna2ButtonAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formAdmin = new FormLoginAdmin();
            formAdmin.FormClosed += delegate
            {
                if (session.Name != "")
                {
                    Owner.Enabled = true;
                    this.Close();
                }
            };
            formAdmin.ShowDialog();

        }

        private void guna2ButtonInstructor_Click(object sender, EventArgs e)
        {
            FormLoginInstructor formInstructor = new FormLoginInstructor();
            formInstructor.FormClosed += delegate
            {
                if (session.Name != "")
                {
                    Owner.Enabled = true;
                    this.Close();
                }
            };
            formInstructor.ShowDialog();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
