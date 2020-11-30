using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormLoginInstructor : Form
    {
        Session session = Session.Instance;
        Instructor instructor = new Instructor();
        public FormLoginInstructor()
        {
            InitializeComponent();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxUsername.Text != "" && guna2TextBoxPassword.Text != "")
                {
                    string user = Login.InstructorLogin(guna2TextBoxUsername.Text, guna2TextBoxPassword.Text);

                    if (user == "0")
                    {
                        MessageBox.Show("Gagal Untuk Login, Username atau Password Salah", "Warning");
                    }
                    else
                    {
                        ArrayList list = instructor.QueryData("username", guna2TextBoxUsername.Text);
                        session.SessionClear();
                        session.Id = ((Instructor)list[0]).Id;
                        session.Name = ((Instructor)list[0]).Name;
                        session.User = "Instructor";

                        MessageBox.Show($"Berhasil Login Sebagai Instructor, Nama Anda adalah {user}", "Login Sukses");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Username dan Password Tidak Boleh Kosong", "Warning");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ada Kesalahan TIdak Bisa Login, Error : {error}", "Error");
            }
        }

        private void FormLoginInstructor_Load(object sender, EventArgs e)
        {
            guna2TextBoxUsername.Text = "gaban";
            guna2TextBoxPassword.Text = "buymoregames";
        }
    }
}
