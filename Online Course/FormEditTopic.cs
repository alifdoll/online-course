using Database;
using System;
using System.Collections;
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
    public partial class FormEditTopic : Form
    {
        Topic topic = new Topic();
        ArrayList list = new ArrayList();
        public FormEditTopic()
        {
            InitializeComponent();
        }

        private void guna2TextBoxEditIdTopic_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBoxEditIdTopic.Text.Length == 2)
            {
                list = topic.QueryData("id", guna2TextBoxEditIdTopic.Text);
                if(list.Count > 0)
                {
                    guna2TextBoxEditNameTopic.Text = ((Topic)list[0]).Name;
                    guna2TextBoxEditNameTopic.Focus();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Error");
                    guna2TextBoxEditIdTopic.Clear();
                    guna2TextBoxEditIdTopic.Focus();
                }
            }
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Topic newTopic = new Topic(guna2TextBoxEditIdTopic.Text, guna2TextBoxEditNameTopic.Text);
                newTopic.Update();
                MessageBox.Show("Data Berhasil Diubah", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Data Gagal Diubah, Error : {error}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxEditIdTopic.Clear();
            guna2TextBoxEditIdTopic.Focus();
            guna2TextBoxEditNameTopic.Clear();
        }
    }
}
