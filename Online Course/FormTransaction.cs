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
    public partial class FormTransaction : Form
    {
        NotaJual nota = new NotaJual();
        ArrayList listNota;
        Session session = Session.Instance;
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void AssignData()
        {
            dataGridViewSearch.Rows.Clear();
            foreach (NotaJual nota in listNota)
            {
                dataGridViewSearch.Rows.Add(
                    nota.NoNota,
                    nota.Tanggal,
                    nota.NotaJualDetil.Course.Id,
                    nota.NotaJualDetil.Course.Name,
                    nota.NotaJualDetil.Harga);
            }
        }

        private void FormTransaction_Load_1(object sender, EventArgs e)
        {
            try
            {
                listNota = nota.QueryData(studentId: session.Id);
                if (listNota.Count > 0)
                {
                    AssignData();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Error : {error.Message}", "Warning");
            }

           
        }

        private void guna2TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string criteria;

                    switch (guna2ComboBoxSearch.Text)
                    {
                        default:
                            criteria = "nota_jual.no_nota";
                            break;

                        case "Tanggal":
                            criteria = "tanggal";
                            break;

                        case "Id Course":
                            criteria = "course.id";
                            break;

                        case "Nama Course":
                            criteria = "course.nama";
                            break;

                        case "Harga":
                            criteria = "course.harga";
                            break;
                    }

                    listNota = nota.QueryData(criteria, guna2TextBoxSearch.Text, session.Id);
                    if (listNota.Count > 0)
                    {
                        AssignData();
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Error : {error.Message}", "Warning");
            }
           
            
        }

        private void guna2ButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (listNota.Count > 0)
                {
                    NotaJual.CetakNota(new Font("Courier New", 12), studentId: session.Id, namaFile : "nota_jual.txt");
                    MessageBox.Show("Nota Berhasil Di Cetak");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mencetak, Error : {error.Message}");
            }
           
        }
    }
}
