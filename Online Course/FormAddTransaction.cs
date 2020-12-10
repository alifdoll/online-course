using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Online_Course
{
    public partial class FormAddTransaction : Form
    {
        Session session = Session.Instance;
        NotaJual nota = new NotaJual();
       
        List<Course> availableCourse = new List<Course>();
        ArrayList listCourse = new ArrayList();
        
        int courseIdx;
        string noNota;
        public FormAddTransaction()
        {
            InitializeComponent();
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            availableCourse = nota.AvailableCourse(session.Id);
            if (availableCourse.Count > 0)
            {
                guna2DateTimePicker1.Value = DateTime.Now;
                guna2TextBoxNota.Text = nota.GenerateNoNota(session.Id);
                guna2ComboBoxCourse.DataSource = availableCourse;
                guna2ComboBoxCourse.DisplayMember = "Name";

                guna2TextBoxHarga.Text = availableCourse[guna2ComboBoxCourse.SelectedIndex].Price.ToString();
            }
            else
            {
                ClearFocus();
                MessageBox.Show("No Available Course", "Information");
            }
        }

        private void guna2ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxCourse.SelectedIndex != -1)
            {
                guna2TextBoxHarga.Text = availableCourse[guna2ComboBoxCourse.SelectedIndex].Price.ToString();
            }
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string no_nota = guna2TextBoxNota.Text;
                Student student = new Student(session.Id, session.Name);
                NotaJual notaJual = new NotaJual(
                   guna2TextBoxNota.Text,
                   guna2DateTimePicker1.Value,
                   student);

                for (int i = 0; i < dataGridViewSearch.Rows.Count - 1; i++)
                {
                    Course course = new Course();
                    string id = dataGridViewSearch.Rows[i].Cells[2].Value.ToString();

                    listCourse = course.QueryData("course.id", id);

                    double harga = double.Parse(dataGridViewSearch.Rows[i].Cells[4].Value.ToString());
                   
                    notaJual.TambahDetil((Course)listCourse[0], harga);

                }

                notaJual.Insert();
                MessageBox.Show("Berhasil Membeli", "Info");
                courseIdx = guna2ComboBoxCourse.SelectedIndex;
                availableCourse.RemoveAt(courseIdx);

                /*
                DialogResult printYes = MessageBox.Show("Cetak Nota ?", "Info", MessageBoxButtons.YesNo);
                if(printYes == DialogResult.Yes)
                {
                    NotaJual.CetakNota(new Font("Courier New", 12), "nota_jual.no_nota", no_nota, Session.Instance.Id, "nota_current.txt");
                }
                else
                {
                     
                }
                */
                FormAddTransaction_Load(guna2ButtonSave, e);
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
            guna2TextBoxNota.Text = "";
            guna2TextBoxHarga.Text = "0";
            guna2TextBoxNota.Text = "";

        }

        private void guna2ButtonAdd_Click_1(object sender, EventArgs e)
        {
            Course course = (Course)guna2ComboBoxCourse.SelectedItem;

            dataGridViewSearch.Rows.Add(
                guna2TextBoxNota.Text,
                guna2DateTimePicker1.Value,
                course.Id,
                course.Name,
                course.Price);
        }

        private void guna2ButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota(new Font("Courier New", 12), criteria: "nota_jual.no_nota",value1: noNota, studentId: session.Id, namaFile: "nota_jual_recent.txt");
                MessageBox.Show("Nota Berhasil Dicetak", "Info");
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mencetak Nota, Error : {error.Message}", "Warning");
            }
        }
    }
}
