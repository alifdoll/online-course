using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormRemoveStudent : Form
    {
        ArrayList list = new ArrayList();
        Student student = new Student();
        public FormRemoveStudent()
        {
            InitializeComponent();
        }

        private void guna2TextBoxDeleteIdStudent_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBoxDeleteIdStudent.Text.Length <= 2)
            {
                list = student.QueryData("id", guna2TextBoxDeleteIdStudent.Text);
                if (list.Count > 0)
                {
                    guna2TextBoxDeleteNameStudent.Text = ((Student)list[0]).Name;
                    guna2TextBoxDeleteUsernameStudent.Text = ((Student)list[0]).Username;
                    guna2TextBoxDeletePasswordStudent.Text = ((Student)list[0]).GetPass();
                }
            }
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {

            if (guna2TextBoxDeleteIdStudent.Text != "")
            {
                DialogResult confirm = MessageBox.Show("Data Student akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Student del = new Student(guna2TextBoxDeleteIdStudent.Text);

                    string delete = del.Delete();
                    if (delete == "1")
                    {
                        MessageBox.Show("Data Berhasil Dihapus", "Info");
                        guna2ButtonClear_Click(guna2ButtonDelete, e);
                    }
                    else
                    {
                        MessageBox.Show($"Gagal Menghapus Data, Error : {delete}", "Error");
                    }
                }

            }
            else
            {
                MessageBox.Show("Id Tidak Boleh Kosong", "Warning");
            }


        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxDeleteIdStudent.Clear();
            guna2TextBoxDeleteIdStudent.Focus();
            guna2TextBoxDeleteNameStudent.Clear();
            guna2TextBoxDeleteUsernameStudent.Clear();
            guna2TextBoxDeletePasswordStudent.Clear();
        }
    }
}
