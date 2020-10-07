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
    public partial class FormCourse : Form
    {
        ArrayList list = new ArrayList();
        List<Course> courses = new List<Course>();
        Course course = new Course();
        public FormCourse()
        {
            InitializeComponent();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            list = course.QueryData();
            CustomGrid();
            
        }
        
        private void CustomGrid()
        {
            if (list.Count > 0)
            {
                dataGridViewSearch.Rows.Clear();
                foreach (Course courseList in list)
                {
                    dataGridViewSearch.Rows.Add(
                        courseList.Id,
                        courseList.Name,
                        courseList.Desc,
                        courseList.Lang,
                        courseList.Price,
                        courseList.Release,
                        courseList.Topic.Id,
                        courseList.Topic.Name,
                        courseList.Instructor.Id,
                        courseList.Instructor.Name);

                   
                }

            }
            else
            {
                dataGridViewSearch.DataSource = null;
            }
        }

        private void guna2TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            guna2TextBoxSearch.Clear();
            switch (guna2ComboBoxSearch.Text)
            {
                case "Course Id":
                    list = course.QueryData("course.id", guna2TextBoxSearch.Text);
                    break;

                case "Course Name":
                    list = course.QueryData("course.nama", guna2TextBoxSearch.Text);
                    break;

                case "Language":
                    list = course.QueryData("language", guna2TextBoxSearch.Text);
                    break;

                case "Price":
                    list = course.QueryData("harga", guna2TextBoxSearch.Text);
                    break;

                case "Topic Name":
                    list = course.QueryData("topic.nama", guna2TextBoxSearch.Text);
                    break;

                default:
                    list = course.QueryData("instructor.nama", guna2TextBoxSearch.Text);
                    break;
            }

            if (list.Count > 0) CustomGrid();
            else dataGridViewSearch.DataSource = null;
        }
    }
}
