using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace Database
{
    public class Cetak
    {
        private Font jenisFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;

        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }


        public Cetak(string namaFile, Font jenisFont, float marginKiri, float marginKanan, float marginAtas, float marginBawah)
        {
            JenisFont = jenisFont;
            FileCetak = new StreamReader(namaFile);
            MarginKiri = marginKiri;
            MarginKanan = marginKanan;
            MarginAtas = marginAtas;
            MarginBawah = marginBawah;
        }

        private void CreateFile(object sender, PrintPageEventArgs e)
        {
            int jumlahBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah - MarginAtas) / JenisFont.GetHeight(e.Graphics));

            float y = MarginAtas;

            int jumlahBaris = 0;

            string tulisanCetak = FileCetak.ReadLine();

            while (jumlahBaris < jumlahBarisPerHalaman && tulisanCetak != null)
            {
                y = MarginAtas + (jumlahBaris * JenisFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(tulisanCetak, JenisFont, Brushes.Black, MarginKiri, y);

                jumlahBaris++;

                tulisanCetak = FileCetak.ReadLine();
            }

            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void PrintFile(string type)
        {
            PrintDocument print = new PrintDocument();

            if (type == "text")
            {
                print.PrintPage += new PrintPageEventHandler(CreateFile);
            }

            print.Print();

            FileCetak.Close();
        }
    }
}
