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
    public partial class FormTopic : Form
    {
        ArrayList list = new ArrayList();
        Topic topic = new Topic();
        public FormTopic()
        {
            InitializeComponent();
        }

        private void FormTopic_Load(object sender, EventArgs e)
        {
            list = topic.QueryData();
            if (list.Count < 0) MessageBox.Show("Data Tidak Ditemukan", "Error");
            else dataGridViewSearch.DataSource = list;
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxSearch.Text == "Id")
            {
                list = topic.QueryData("id", guna2TextBoxSearch.Text);
            }
            else
            {
                list = topic.QueryData("Nama", guna2TextBoxSearch.Text);
            }

            if (list.Count >= 0) dataGridViewSearch.DataSource = list;
            else { dataGridViewSearch.DataSource = null; MessageBox.Show("Data Tidak Ditemukan", "Error"); }
        }
    }
}
