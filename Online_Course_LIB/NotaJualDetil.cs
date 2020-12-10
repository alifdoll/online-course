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

        public NotaJualDetil()
        {
            Course = new Course();
            Harga = 0;
        }
    }
}
