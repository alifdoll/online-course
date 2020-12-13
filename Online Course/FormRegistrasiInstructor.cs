using Database;
using System;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormRegistrasiInstructor : Form
    {
        public FormRegistrasiInstructor()
        {
            InitializeComponent();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Login.AdminLogin();

                Instructor instructor = new Instructor(
                    "",
                    guna2TextBoxAddNameInstructor.Text,
                    guna2TextBoxAddBioInstructor.Text,
                    guna2TextBoxAddUsernameInstructor.Text,
                    guna2TextBoxAddPasswordInstructor.Text);

                string id = instructor.GeneratePrimaryKey();

                instructor.Id = id;

                instructor.Insert();

                Login.CloseConnection();

                MessageBox.Show("Berhasil Registrasi", "Info");

                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Regsitrasi, Error : {error.Message}", "Error");
            }
        }
    }
}
