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
    public partial class FormAddTopic : Form
    {
        Topic topic = new Topic();
        public FormAddTopic()
        {
            InitializeComponent();
        }

        private void FormAddTopic_Load(object sender, EventArgs e)
        {
            string newId = topic.GeneratePrimaryKey();
            guna2TextBoxAddIdTopic.Text = newId;
            guna2TextAddBoxNameTopic.Focus();

        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Topic newTopic = new Topic(guna2TextBoxAddIdTopic.Text, guna2TextAddBoxNameTopic.Text);
                newTopic.Insert();
                MessageBox.Show("Data Berhasil Ditambahkan", "Info");
                guna2TextBoxAddIdTopic.Text = topic.GeneratePrimaryKey();
                guna2ButtonClear_Click(guna2ButtonAdd, e);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Data Gagal Untuk Ditambahkan, Error : {error}", "Error");
            }
            
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextAddBoxNameTopic.Clear();
            guna2TextAddBoxNameTopic.Focus();
        }
    }
}
