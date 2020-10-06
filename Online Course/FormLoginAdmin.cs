using Database;
using System;
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
    public partial class FormLoginAdmin : Form
    {
        Session session = Session.Instance;
        public FormLoginAdmin()
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
                if(guna2TextBoxUsername.Text != "")
                {
                    Login.AdminLogin(guna2TextBoxUsername.Text);
                    session.Name = "Admin";
                    MessageBox.Show("Koneksi Berhasil", "Info");

                    
                    FormMenu formMenu = new FormMenu();
                    //formMenu.Owner = this;
                    formMenu.Show();
                    
                }
                else
                {
                    MessageBox.Show("Username Tidak Boleh Kosong", "Info");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Login, Error : {error}", "Error");
            }
           
        }
    }
}
