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
    public partial class FormInstructor : Form
    {
        ArrayList list = new ArrayList();
        Instructor instructor = new Instructor();
        public FormInstructor()
        {
            InitializeComponent();
        }

        private void FormInstructor_Load(object sender, EventArgs e)
        {
            list = instructor.QueryData();
            if(list.Count > 0)
            {
                dataGridViewSearch.DataSource = list;
            }
            else
            {
                dataGridViewSearch.DataSource = null;
            }
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(guna2ComboBoxSearch.Text == "Id")
            {
                list = instructor.QueryData("id", guna2TextBoxSearch.Text);
            }
            else if(guna2ComboBoxSearch.Text == "Nama")
            {
                list = instructor.QueryData("nama", guna2TextBoxSearch.Text);
            }
            else
            {
                list = instructor.QueryData("username", guna2TextBoxSearch.Text);
            }

            if (list.Count > 0) dataGridViewSearch.DataSource = list;
            else dataGridViewSearch.DataSource = null;
        }
    }
}
