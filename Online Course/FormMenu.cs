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
using MySql.Data.MySqlClient;

namespace Online_Course
{
    public partial class FormMenu : Form
    {
        ArrayList list = new ArrayList();
        Session session = Session.Instance;
        Session sesi = Session.Instance;
        public FormMenu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelCourse.Visible = false;
            panelInstructor.Visible = false;
            panelStudent.Visible = false;
            panelTopic.Visible = false;
        }

        private void HideMenu()
        {
            if(panelCourse.Visible == true)
                panelCourse.Visible = false;
            if (panelInstructor.Visible == true)
                panelInstructor.Visible = false;
            if(panelStudent.Visible == true)
                panelStudent.Visible = false;
            if(panelTopic.Visible == true)
                panelTopic.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region button
        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            ShowMenu(panelTranscation);
            openChildForm(new FormTransaction());
            //code...

        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            ShowMenu(panelCourse);
            openChildForm(new FormCourse());
            //code...


        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddCourse());
            //code...
            HideMenu();
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditCourse());
            //code...
            HideMenu();
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRemoveCourse());
            //code...
            HideMenu();
        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {
            ShowMenu(panelTopic);
            openChildForm(new FormTopic());
        }

        private void buttonAddTopic_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddTopic());
            //code...
            HideMenu();
        }

        private void buttonEditTopic_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditTopic());
            //code...
            HideMenu();
        }

        private void buttonRemoveTopic_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRemoveTopic());
            //code...
            HideMenu();
        }

        private void buttonInstructor_Click(object sender, EventArgs e)
        {
            ShowMenu(panelInstructor);
            openChildForm(new FormInstructor());
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddInstructor());
            //code...
            HideMenu();
        }

        private void buttonEditInstructor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditInstructor());
            //code...
            HideMenu();
        }

        private void buttonRemoveInstructor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRemoveInstructor());
            //code...
            HideMenu();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            ShowMenu(panelStudent);
            openChildForm(new FormStudent());
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddStudent());
            //code...
            HideMenu();
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditStudent());
            //code...
            HideMenu();
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRemoveStudent());
            //code...
            HideMenu();
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddTransaction());
            //code...
            HideMenu();
        }
        #endregion


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            
          

            IsMdiContainer = true;
            Enabled = false;

            FormLogin form = new FormLogin();
            form.Owner = this;
            form.Show();
        }

        private void FormMenu_EnabledChanged(object sender, EventArgs e)
        {
            if (session.User == "Student")
            {
                buttonCourse.Enabled = false;
                buttonInstructor.Enabled = false;
                buttonTopic.Enabled = false;
                buttonRemoveStudent.Enabled = false;
                buttonEditStudent.Enabled = false;
                labelLogin.Text = $"{session.Name.Substring(0,11)}";
                labelSebagai.Text = $"{session.User}";
            }
            else if(session.User == "Instructor")
            {
                buttonCourse.Enabled = true;
                buttonInstructor.Enabled = true;
                buttonRemoveInstructor.Enabled = false;
                buttonStudent.Enabled = false;
                labelLogin.Text = $"{session.Name.Substring(0, 5)}";
                labelSebagai.Text = $"{session.User}";
            }
            else
            {
                labelLogin.Text = $"{session.Name}";
                labelSebagai.Text = $"{session.User}";
            }
        }
    }
}
