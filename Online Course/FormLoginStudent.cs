using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormLoginStudent : Form
    {
        Session session = Session.Instance;
        Student student = new Student();
        public FormLoginStudent()
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
                    string user = Login.StudentLogin(guna2TextBoxUsername.Text, guna2TextBoxPassword.Text);
                    if (user == "0")
                    {
                        MessageBox.Show("Gagal Untuk Login, Username atau Password Salah", "Warning");
                    }
                    else
                    {
                        ArrayList listStudent = student.QueryData("username", guna2TextBoxUsername.Text);
                        session.SessionClear();
                        session.Id = ((Student)listStudent[0]).Id;
                        session.Name = ((Student)listStudent[0]).Name;
                        session.User = "Student";

                        MessageBox.Show($"Berhasil Login Sebagai Student, Nama Anda adalah {user}", "Login Sukses");
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
                MessageBox.Show($"Ada Kesalahan TIdak Bisa Login, Error : {error.Message}", "Error");
            }
        }

        private void guna2TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2ButtonLogin_Click(guna2TextBoxPassword, e);
            }
        }

        private void FormLoginStudent_Load(object sender, EventArgs e)
        {
            //untuk debug user
            guna2TextBoxUsername.Text = "alifdoll";
            guna2TextBoxPassword.Text = "alif123321";
        }
    }
}
