using Database;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormRemoveCourse : Form
    {
        ArrayList list = new ArrayList();
        ArrayList listTopic = new ArrayList();
        ArrayList listInstr = new ArrayList();

        Course course = new Course();
        Topic topic = new Topic();
        Instructor instructor = new Instructor();
        public FormRemoveCourse()
        {
            InitializeComponent();
        }

        private void guna2TextBoxAddIdCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {

            if (guna2ComboBoxRemoveCourse.SelectedIndex != -1)
            {
                DialogResult confirm = MessageBox.Show("Data Course akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Course delCourse = new Course(id: guna2ComboBoxRemoveCourse.Text);
                    string delete = delCourse.Delete();

                    if (delete == "1")
                    {
                        MessageBox.Show("Data Berhasil Dihapus", "Info");
                        guna2ButtonClear_Click(guna2ButtonDelete, e);
                        FormRemoveCourse_Load(guna2ButtonDelete, e);
                    }
                    else
                    {
                        MessageBox.Show($"Data Gagal Dihapus, Error : {delete}", "Error");
                        guna2ButtonClear_Click(guna2ButtonDelete, e);
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

            guna2TextBoxAddNameCourse.Clear();
            guna2TextBoxAddDescriptionCourse.Clear();
            dateTimePickerRelease.Value = DateTime.Now;
            guna2TextBoxCost.Clear();
            guna2ComboBoxInstr.SelectedIndex = 0;
            guna2ComboBoxTopic.SelectedIndex = 0;
            guna2TextBoxAddLanguageCourse.Clear();
        }

        private void FormRemoveCourse_Load(object sender, EventArgs e)
        {
            list = course.QueryData("course.id", Session.Instance.Id);
            listInstr = instructor.QueryData();
            listTopic = topic.QueryData();

            if (list.Count > 0)
            {
                guna2ComboBoxRemoveCourse.DataSource = list;
                guna2ComboBoxRemoveCourse.DisplayMember = "Id";
                guna2TextBoxAddNameCourse.Text = ((Course)list[0]).Name;
                guna2TextBoxAddDescriptionCourse.Text = ((Course)list[0]).Desc;
                guna2TextBoxAddLanguageCourse.Text = ((Course)list[0]).Lang;
                guna2TextBoxCost.Text = ((Course)list[0]).Price.ToString();
                guna2ComboBoxInstr.DataSource = listInstr;
                dateTimePickerRelease.Value = ((Course)list[0]).Release;
                guna2ComboBoxInstr.DisplayMember = "Name";
                guna2ComboBoxTopic.DataSource = listTopic;
                guna2ComboBoxTopic.DisplayMember = "Name";
                guna2ComboBoxTopic.Text = ((Course)list[0]).Topic.Name;
                guna2ComboBoxInstr.Text = ((Course)list[0]).Instructor.Name;
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan", "Warning");
            }
        }

        private void guna2ComboBoxRemoveCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxRemoveCourse.SelectedIndex != -1)
            {
                int idx = guna2ComboBoxRemoveCourse.SelectedIndex;
                if (list.Count > 0)
                {
                    guna2TextBoxAddNameCourse.Text = ((Course)list[idx]).Name;
                    guna2TextBoxAddDescriptionCourse.Text = ((Course)list[idx]).Desc;
                    guna2TextBoxAddLanguageCourse.Text = ((Course)list[idx]).Lang;
                    guna2TextBoxCost.Text = ((Course)list[idx]).Price.ToString();
                    guna2ComboBoxInstr.DataSource = listInstr;
                    dateTimePickerRelease.Value = ((Course)list[idx]).Release;
                    guna2ComboBoxInstr.DisplayMember = "Name";
                    guna2ComboBoxTopic.DataSource = listTopic;
                    guna2ComboBoxTopic.DisplayMember = "Name";
                    guna2ComboBoxTopic.Text = ((Course)list[idx]).Topic.Name;
                    guna2ComboBoxInstr.Text = ((Course)list[idx]).Instructor.Name;
                }
            }
        }
    }
}
