using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormAddCourse : Form
    {
        ArrayList listTopic = new ArrayList();
        ArrayList listInstr = new ArrayList();
        Course course = new Course();
        Topic topic = new Topic();
        Instructor instructor = new Instructor();
        public FormAddCourse()
        {
            InitializeComponent();
        }

        private void FormAddCourse_Load(object sender, EventArgs e)
        {

            listTopic = topic.QueryData();
            listInstr = instructor.QueryData();
            guna2ComboBoxTopic.DataSource = listTopic;
            guna2ComboBoxInstr.DataSource = listInstr;

            guna2ComboBoxTopic.DisplayMember = "Name";
            guna2ComboBoxInstr.DisplayMember = "Name";

            guna2ComboBoxInstr.Text = Session.Instance.Name;
        }

        private void guna2ComboBoxInstr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxInstr.SelectedIndex != -1 && guna2ComboBoxTopic.SelectedIndex != -1)
            {
                Instructor instructor = (Instructor)guna2ComboBoxInstr.SelectedItem;

                string newPkey = course.GeneratePrimaryKey(instructor);
                guna2TextBoxAddIdCourse.Text = newPkey;
                guna2TextBoxAddNameCourse.Focus();
            }
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Topic topic = (Topic)guna2ComboBoxTopic.SelectedItem;
                Instructor instructor = (Instructor)guna2ComboBoxInstr.SelectedItem;
                Course course = new Course(
                    guna2TextBoxAddIdCourse.Text,
                    guna2TextBoxAddNameCourse.Text,
                    guna2TextBoxAddDescriptionCourse.Text,
                    guna2TextBoxAddLanguageCourse.Text,
                    double.Parse(guna2TextBoxCost.Text),
                    dateTimePickerRelease.Value,
                    topic,
                    instructor);

                course.Insert();
                MessageBox.Show("Data Berhasil Ditambahkan", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);

            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Menambahkan Data, Error : {error.Message}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxAddNameCourse.Clear();
            guna2TextBoxAddNameCourse.Focus();
            guna2TextBoxAddDescriptionCourse.Clear();
            guna2TextBoxCost.Clear();
            guna2TextBoxAddDescriptionCourse.Clear();
            dateTimePickerRelease.Value = DateTime.Now;
        }
    }
}
