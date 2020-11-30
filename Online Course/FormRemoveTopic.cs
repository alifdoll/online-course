using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormRemoveTopic : Form
    {
        Topic topic = new Topic();
        ArrayList list = new ArrayList();
        public FormRemoveTopic()
        {
            InitializeComponent();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {


            if (guna2TextBoxDeleteIdTopic.Text != "")
            {
                DialogResult confirm = MessageBox.Show("Data Topic akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Topic topic = new Topic(guna2TextBoxDeleteIdTopic.Text, guna2TextBoxDeleteNameTopic.Text);
                    string delete = topic.Delete();
                    if (delete == "1")
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        guna2ButtonClear_Click(guna2ButtonAdd, e);
                    }
                    else
                    {
                        MessageBox.Show($"Data Gagal Dihapus, Error : {delete}");
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
            guna2TextBoxDeleteIdTopic.Clear();
            guna2TextBoxDeleteIdTopic.Focus();
            guna2TextBoxDeleteNameTopic.Clear();
        }

        private void guna2TextBoxDeleteIdTopic_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBoxDeleteIdTopic.Text.Length == 2)
            {
                list = topic.QueryData("id", guna2TextBoxDeleteIdTopic.Text);
                if (list.Count > 0)
                {
                    guna2TextBoxDeleteNameTopic.Focus();
                    guna2TextBoxDeleteNameTopic.Text = ((Topic)list[0]).Name;
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Error");
                }
            }
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show($"Data Gagal Dihapus, Error : {error}", "Error");
            }
        }
    }
}
