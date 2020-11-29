using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class NotaJualDetil
    {
        private Course course;
        private double harga;

        public Course Course { get => course; set => course = value; }
        public double Harga { get => harga; set => harga = value; }

        public NotaJualDetil(Course course, double harga)
        {
            Course = course;
            Harga = harga;
        }
    }
}
