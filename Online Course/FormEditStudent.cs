using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormEditStudent : Form
    {
        ArrayList list = new ArrayList();
        Student student = new Student();
        public FormEditStudent()
        {
            InitializeComponent();
        }

        private void guna2TextBoxEditIdStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStu = new Student(
                    Session.Instance.Id,
                    guna2TextBoxEditNameStudent.Text,
                    guna2TextBoxEditUsernameStudent.Text,
                    guna2TextBoxEditPasswordStudent.Text);

                newStu.Update();
                MessageBox.Show("Data Berhasil Diubah", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Mengubah Data, Error : {error}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxEditUsernameStudent.Clear();
            guna2TextBoxEditPasswordStudent.Clear();
            guna2TextBoxEditNameStudent.Clear();
        }

        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            list = student.QueryData("student.id", Session.Instance.Id);
            if (list.Count > 0)
            {
                guna2TextBoxEditNameStudent.Text = ((Student)list[0]).Name;
                guna2TextBoxEditUsernameStudent.Text = ((Student)list[0]).Username;
                guna2TextBoxEditPasswordStudent.Text = ((Student)list[0]).GetPass();
            }
            else
            {
                MessageBox.Show($"Data Tidak Ditemukan", "Error");
            }
        }
    }
}
