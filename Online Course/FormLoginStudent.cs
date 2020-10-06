using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Online_Course
{
    public partial class FormLoginStudent : Form
    {
        Session session = Session.Instance;
        public FormLoginStudent()
        {
            InitializeComponent();
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(guna2TextBoxUsername.Text != "" && guna2TextBoxPassword.Text != "")
                {
                    
                }

            }
            catch(Exception error)
            {
                MessageBox.Show($"Ada Kesalahan TIdak Bisa Login, Error : {error}", "Error");
            }
        }
    }
}
