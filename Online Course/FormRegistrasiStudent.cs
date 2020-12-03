using Database;
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
    public partial class FormRegistrasiStudent : Form
    {
        public FormRegistrasiStudent()
        {
            InitializeComponent();
        }

        private void guna2ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Login.AdminLogin();

                Student student = new Student(
                    "",
                    guna2TextBoxAddNameStudent.Text,
                    guna2TextBoxAddUsernameStudent.Text,
                    guna2TextBoxAddPasswordStudent.Text);

                string id = student.GeneratePrimaryKey();

                student.Id = id;

                student.Insert();

                Login.CloseConnection();

                MessageBox.Show("Berhasil Registrasi", "Info");

                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Regsitrasi, Error : {error.Message}", "Error");
            }
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
