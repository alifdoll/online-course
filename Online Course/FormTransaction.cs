using Database;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Course
{
    public partial class FormTransaction : Form
    {
        NotaJual nota = new NotaJual();
        ArrayList listNota = new ArrayList();
        Session session = Session.Instance;
        string criteria;
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void AssignData(ArrayList lists)
        {
            dataGridViewSearch.Rows.Clear();
            foreach (NotaJual nota in lists)
            {
                foreach(NotaJualDetil notaDetil in nota.ListNotaDetil)
                {
                    dataGridViewSearch.Rows.Add(
                   nota.NoNota,
                   nota.Tanggal,
                   notaDetil.Course.Id,
                   notaDetil.Course.Name,
                   notaDetil.Harga);
                }
               
            }
        }

        private void FormTransaction_Load_1(object sender, EventArgs e)
        {
            
            try
            {
                listNota.Clear();
                listNota = nota.QueryData(session.Id);
                if (listNota.Count > 0)
                {
                    AssignData(listNota);
                }

            }
            catch (Exception error)
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


                    if(guna2TextBoxSearch.Text == "")
                    {
                        AssignData(listNota);
                    }
                    else
                    {
                        ArrayList listSearch = nota.QueryData(session.Id, criteria, guna2TextBoxSearch.Text);
                        AssignData(listSearch);
                    }
                }
            }
            catch (Exception error)
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
                    if(guna2TextBoxSearch.Text == "")
                    {
                        NotaJual.CetakNota(new Font("Courier New", 12), studentId: session.Id, namaFile: "nota_jual.txt");
                        MessageBox.Show("Nota Berhasil Di Cetak");
                    }
                    else
                    {
                        NotaJual.CetakNota(new Font("Courier New", 12), criteria, guna2TextBoxSearch.Text, session.Id, "nota_jual.txt");
                    }
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Mencetak, Error : {error.Message}");
            }

        }
    }
}
