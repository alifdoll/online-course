using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormRemoveInstructor : Form
    {
        ArrayList list = new ArrayList();
        Instructor instructor = new Instructor();

        public FormRemoveInstructor()
        {
            InitializeComponent();
        }

        private void guna2TextBoxDeleteIdInstructor_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBoxDeleteIdInstructor.Text.Length == 2)
            {
                list = instructor.QueryData("id", guna2TextBoxDeleteIdInstructor.Text);
                if (list.Count > 0)
                {
                    guna2TextBoxDeleteNameInstructor.Text = ((Instructor)list[0]).Name;
                    guna2TextBoxDeleteBioInstructor.Text = ((Instructor)list[0]).Biography;
                    guna2TextBoxDeleteUsernameInstructor.Text = ((Instructor)list[0]).Username;
                    guna2TextBoxDeletePasswordInstructor.Text = ((Instructor)list[0]).GetPass();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Error");
                }
            }
        }



        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {

            if (guna2TextBoxDeleteIdInstructor.Text != "")
            {
                DialogResult confirm = MessageBox.Show("Data Instructor akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Instructor del = new Instructor(id: guna2TextBoxDeleteIdInstructor.Text);
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
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Id Tidak Boleh Kosong", "Warning");
            }


        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxDeleteNameInstructor.Clear();
            guna2TextBoxDeleteBioInstructor.Clear();
            guna2TextBoxDeleteUsernameInstructor.Clear();
            guna2TextBoxDeletePasswordInstructor.Clear();
            guna2TextBoxDeleteIdInstructor.Clear();
            guna2TextBoxDeleteIdInstructor.Focus();
        }
    }
}
