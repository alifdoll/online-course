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
    public partial class FormAddStudent : Form
    {
        Student student = new Student();
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            guna2TextBoxAddIdStudent.Text = student.GeneratePrimaryKey();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStu = new Student(
                    guna2TextBoxAddIdStudent.Text,
                    guna2TextBoxAddNameStudent.Text,
                    guna2TextBoxAddUsernameStudent.Text,
                    guna2TextBoxAddPasswordStudent.Text);

                newStu.Insert();
                MessageBox.Show("Berhasil Menambahkan Data", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Menambahkan Data, Error : {error.Message}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxAddNameStudent.Clear();
            guna2TextBoxAddUsernameStudent.Focus();
            guna2TextBoxAddUsernameStudent.Clear();
            guna2TextBoxAddPasswordStudent.Clear();
        }
    }
}
