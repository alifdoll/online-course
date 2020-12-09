using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormCourse : Form
    {
        ArrayList list = new ArrayList();
        List<Course> courses = new List<Course>();
        Course course = new Course();
        Session session = Session.Instance;
        public FormCourse()
        {
            InitializeComponent();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            if(session.User == "Instructor")
            {
                list = course.QueryData("instructor.id", session.Id);
               
            }
            else if(session.User == "Student")
            {
                list = course.StudentCourse(session.Id);
            }
            else
            {
                list = course.QueryData();
            }

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
            switch (guna2ComboBoxSearch.Text)
            {
                case "Course Id":
                    list = course.InstructorCourse("course.id", guna2TextBoxSearch.Text, session.Id);
                    break;

                case "Course Name":
                    list = course.InstructorCourse("course.nama", guna2TextBoxSearch.Text, session.Id);
                    break;

                case "Language":
                    list = course.InstructorCourse("language", guna2TextBoxSearch.Text, session.Id);
                    break;

                case "Price":
                    list = course.InstructorCourse("harga", guna2TextBoxSearch.Text, session.Id);
                    break;

                case "Topic Name":
                    list = course.InstructorCourse("topic.nama", guna2TextBoxSearch.Text, session.Id);
                    break;

                default:
                    list = course.InstructorCourse("instructor.nama", guna2TextBoxSearch.Text, session.Id);
                    break;
            }

            if (list.Count > 0) CustomGrid();
            else dataGridViewSearch.DataSource = null;
        }
    }
}
