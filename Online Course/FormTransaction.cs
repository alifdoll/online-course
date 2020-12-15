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

        private void guna2ButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (listNota.Count > 0)
                {

                    NotaJual.CetakNota(new Font("Courier New", 12), studentId: session.Id, namaFile: "nota_jual.txt");
                    MessageBox.Show("Nota Berhasil Di Cetak");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Mencetak, Error : {error.Message}");
            }

        }

        private void AssignData(ArrayList lists)
        {
            dataGridViewSearch.Rows.Clear();
            foreach (NotaJual nota in lists)
            {
                foreach (NotaJualDetil notaDetil in nota.ListNotaDetil)
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

    }
}
