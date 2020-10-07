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
    public partial class FormAddInstructor : Form
    {
        ArrayList list = new ArrayList();
        Instructor instructor = new Instructor();
        public FormAddInstructor()
        {
            InitializeComponent();
        }

        private void FormAddInstructor_Load(object sender, EventArgs e)
        {
            string newPkey = instructor.GeneratePrimaryKey();
            guna2TextBoxAddIdInstructor.Text = newPkey;
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor newInst = new Instructor(
                    guna2TextBoxAddIdInstructor.Text,
                    guna2TextBoxAddNameInstructor.Text,
                    guna2TextBoxAddBioInstructor.Text,
                    guna2TextBoxAddUsernameInstructor.Text,
                    guna2TextBoxAddPasswordInstructor.Text);
                newInst.Insert();
                MessageBox.Show("Data Berhasil Ditambahkan", "Info");
                guna2ButtonClear_Click(guna2ButtonAdd, e);
                guna2TextBoxAddIdInstructor.Text = instructor.GeneratePrimaryKey();

            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Menambahkan Data, Error : {error.Message}", "Error");
            }
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            guna2TextBoxAddNameInstructor.Clear();
            guna2TextBoxAddNameInstructor.Focus();
            guna2TextBoxAddBioInstructor.Clear();
            guna2TextBoxAddUsernameInstructor.Clear();
            guna2TextBoxAddPasswordInstructor.Clear();
        }
    }
}
