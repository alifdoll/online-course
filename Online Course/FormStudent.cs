using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormStudent : Form
    {
        ArrayList list = new ArrayList();
        Student student = new Student();
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            list = student.QueryData();
            if (list.Count > 0) dataGridViewSearch.DataSource = list;
            else dataGridViewSearch.DataSource = null;

        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxSearch.Text == "Id")
            {
                list = student.QueryData("Id", guna2TextBoxSearch.Text);
            }
            else if (guna2ComboBoxSearch.Text == "Nama")
            {
                list = student.QueryData("Nama", guna2TextBoxSearch.Text);
            }
            else
            {
                list = student.QueryData("Username", guna2TextBoxSearch.Text);
            }

            if (list.Count > 0) dataGridViewSearch.DataSource = list;
            else dataGridViewSearch.DataSource = null;
        }
    }
}
