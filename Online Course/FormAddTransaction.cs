using Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormAddTransaction : Form
    {
        Session session = Session.Instance;
        NotaJual nota = new NotaJual();
        List<Course> listCourse = new List<Course>();
        int courseIdx;
        public FormAddTransaction()
        {
            InitializeComponent();
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            if (listCourse.Count > 0)
            {
                guna2DateTimePicker1.Value = DateTime.Now;
                guna2TextBoxNota.Text = nota.GenerateNoNota(session.Id);
                listCourse = nota.AvailableCourse(session.Id);
                guna2ComboBoxCourse.DataSource = listCourse;
                guna2ComboBoxCourse.DisplayMember = "Name";

                guna2TextBoxHarga.Text = listCourse[guna2ComboBoxCourse.SelectedIndex].Price.ToString();
            }
            else
            {
                MessageBox.Show("No Available Course", "Information");
            }
        }

        private void guna2ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxCourse.SelectedIndex != -1)
            {
                guna2TextBoxHarga.Text = listCourse[guna2ComboBoxCourse.SelectedIndex].Price.ToString();
            }
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {

            try
            {

                Course course = (Course)guna2ComboBoxCourse.SelectedItem;
                Student student = new Student(session.Id, session.Name);

                NotaJual nota = new NotaJual(
                    guna2TextBoxNota.Text,
                    guna2DateTimePicker1.Value,
                    student);

                nota.TambahNotaDetil(course, course.Price);
                nota.Insert();

                dataGridViewSearch.Rows.Add(
                    nota.NoNota,
                    nota.Tanggal,
                    course.Id,
                    course.Name,
                    course.Price);

                courseIdx = guna2ComboBoxCourse.SelectedIndex;

                FormAddTransaction_Load(guna2ButtonAdd, e);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Menyimpan, Error : {error.Message}", "Warning");
            }
        }

        private void ClearFocus()
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            guna2ComboBoxCourse.DataSource = null;
            guna2TextBoxNota.Text = nota.GenerateNoNota(session.Id);
            listCourse.RemoveAt(courseIdx);
            guna2ComboBoxCourse.DataSource = listCourse;
            guna2ComboBoxCourse.DisplayMember = "Name";
            guna2TextBoxHarga.Text = listCourse[guna2ComboBoxCourse.SelectedIndex].Price.ToString();

        }
    }
}
