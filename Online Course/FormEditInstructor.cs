using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormEditInstructor : Form
    {
        ArrayList list = new ArrayList();
        Instructor instructor = new Instructor();
        public FormEditInstructor()
        {
            InitializeComponent();
        }

        private void guna2TextBoxEditIdInstructor_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor newInst = new Instructor(
                    guna2TextBoxEditIdInstructor.Text,
                    guna2TextBoxEditNameInstructor.Text,
                    guna2TextBoxEditBioInstructor.Text,
                    guna2TextBoxEditUsernameInstructor.Text,
                    guna2TextBoxEditPasswordInstructor.Text);

                newInst.Update();

                MessageBox.Show("Data Berhasil Diubah", "Info");
                guna2ButtonClear_Click(guna2ButtonEdit, e);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Data Gagal Diubah, Error : {error.Message}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxEditIdInstructor.Clear();
            guna2TextBoxEditIdInstructor.Focus();
            guna2TextBoxEditNameInstructor.Clear();
            guna2TextBoxEditBioInstructor.Clear();
            guna2TextBoxEditUsernameInstructor.Clear();
            guna2TextBoxEditPasswordInstructor.Clear();
        }

        private void FormEditInstructor_Load(object sender, EventArgs e)
        {
            list = instructor.QueryData("id", Session.Instance.Id);
            if (list.Count > 0)
            {
                guna2TextBoxEditIdInstructor.Text = ((Instructor)list[0]).Id;
                guna2TextBoxEditNameInstructor.Text = ((Instructor)list[0]).Name;
                guna2TextBoxEditBioInstructor.Text = ((Instructor)list[0]).Biography;
                guna2TextBoxEditUsernameInstructor.Text = ((Instructor)list[0]).Username;
                guna2TextBoxEditPasswordInstructor.Text = ((Instructor)list[0]).GetPass();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan", "Error");
            }
        }
    }
}
