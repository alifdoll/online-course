using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Database
{
    public class NotaJual : ITransaction
    {
        private string noNota;
        private DateTime tanggal;
        private Student student;
        private NotaJualDetil notaJualDetil;
        private List<NotaJualDetil> listNotaDetil;
        

        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Student Student { get => student; set => student = value; }
        public NotaJualDetil NotaJualDetil { get => notaJualDetil; set => notaJualDetil = value; }
        public List<NotaJualDetil> ListNotaDetil { get => listNotaDetil; set => listNotaDetil = value; }

        public NotaJual(string noNota, DateTime tanggal, Student student)
        {
            NoNota = noNota;
            Tanggal = tanggal;
            Student = student;
            NotaJualDetil = null;
        }

        public NotaJual()
        {
            NoNota = "";
            Tanggal = DateTime.Now;
            Student = new Student();
            NotaJualDetil = null;
        }

        public void Insert()
        {
           
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {

                    string sql = $"INSERT INTO nota_jual(no_nota, tanggal, student_id) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}', '{Student.Id}')";
                    Execute.DML(sql);

                    string sql_detil = $"INSERT INTO nota_jual_detil(no_nota, id_course, harga) VALUES ('{NoNota}', '{NotaJualDetil.Course.Id}', '{NotaJualDetil.Course.Price}')";
                    Execute.DML(sql_detil);

                    string sql_enroll = $"INSERT INTO enroll(id_student, id_course, start_date) VALUES ('{Student.Id}', '{NotaJualDetil.Course.Id}', '{Tanggal}')";
                    Execute.DML(sql_enroll);


                    transaction.Complete();

                }
                catch(Exception error)
                {
                    transaction.Dispose();
                    throw new Exception(error.Message);
                }
            }
        }

        public ArrayList QueryData(string criteria = "", string studentId = "", string value = "")
        {
            string sql;

            if (criteria == "")
            {
                sql =
                    $"SELECT nota_jual.no_nota, nota_jual.tanggal, nota_jual.student_id, student.nama, nota_jual_detil.id_course, course.nama, nota_jual_detil.harga " +
                    $"FROM nota_jual " +
                    $"INNER JOIN nota_jual_detil ON nota_jual.no_nota = nota_jual_detil.no_nota " +
                    $"INNER JOIN course ON nota_jual_detil.id_course = course.id " +
                    $"INNER JOIN student ON nota_jual.student_id = student.id " +
                    $"WHERE nota_jual.student_id LIKE '%{studentId}%' " +
                    $"ORDER BY nota_jual.no_nota ASC ";
            }
            else
            {
                sql = 
                    $"SELECT nota_jual.no_nota, nota_jual.tanggal, nota_jual.student_id, student.nama, nota_jual_detil.id_course, course.nama, nota_jual_detil.harga " +
                   $"FROM nota_jual " +
                   $"INNER JOIN nota_jual_detil ON nota_jual.no_nota = nota_jual_detil.no_nota " +
                   $"INNER JOIN course ON nota_jual_detil.id_course = course.id " +
                   $"INNER JOIN student ON nota_jual.student_id = student.id " +
                   $"WHERE {criteria} LIKE '%{studentId}%' AND student.id LIKE '%{value}%'" +
                   $"ORDER BY nota_jual.no_nota ASC ";
            }

            MySqlDataReader result = Execute.Query(sql);
            ArrayList listNota = new ArrayList();

            while (result.Read())
            {
                string noNota = result.GetString(0);

                DateTime tanggal = result.GetDateTime(1);

                Student student = new Student(result.GetString(2), result.GetString(3));

                NotaJual nota = new NotaJual(noNota, tanggal, student);

                Course course = new Course(result.GetString(4), result.GetString(5)) ;

                nota.TambahNotaDetil(course, result.GetDouble(6));

                listNota.Add(nota);
            }
            return listNota;
            
        }

        public List<Course> AvailableCourse(string studentId)
        {
            string sql = 
                        $"SELECT * " +
                        $"FROM course " +
                        $"WHERE course.id NOT IN (" +
                        $"SELECT course.id " +
                        $"from course " +
                        $"INNER JOIN enroll ON enroll.id_course = course.id " +
                        $"INNER JOIN student ON enroll.id_student = student.id " +
                        $"WHERE student.id LIKE '%{studentId}%')";

            
            MySqlDataReader result = Execute.Query(sql);

            List<Course> listCourse = new List<Course>();

            while (result.Read())
            {
                Topic topic = new Topic();
                Instructor instructor = new Instructor();

                Course course = new Course(result.GetValue(0).ToString(), result.GetValue(1).ToString(), result.GetString(2), result.GetString(3), result.GetDouble(4),result.GetDateTime(5), topic, instructor);
                listCourse.Add(course);
            }
            return listCourse;
        }

        public string GenerateNoNota(string id)
        {
            string sql = $"SELECT MAX(RIGHT(nota_jual.no_nota, 3)) FROM nota_jual WHERE nota_jual.student_id LIKE '%{id}%' ";

            MySqlDataReader result = Execute.Query(sql);

            string hasilNota;

            if (result.Read())
            {
                if(result.GetValue(0).ToString() != "")
                {
                    int noUrut = result.GetInt32(0) + 1;
                    hasilNota = DateTime.Now.Year +
                                DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                noUrut.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilNota = 
                           DateTime.Now.Year +
                           DateTime.Now.Month.ToString().PadLeft(2, '0') +
                           DateTime.Now.Day.ToString().PadLeft(2, '0') +
                           "001";
                }
            }
            else
            {
                hasilNota = DateTime.Now.Year +
                            DateTime.Now.Month.ToString().PadLeft(2, '0') +
                            DateTime.Now.Day.ToString().PadLeft(2, '0') +
                            "001";
            }

            return hasilNota;
        }

        public void TambahNotaDetil(Course course, double harga)
        {
            NotaJualDetil notaJual = new NotaJualDetil(course, harga);
            NotaJualDetil = notaJual;
        }

        public static void CetakNota(Font font, string criteria = "", string value1 = "", string studentId = "", string namaFile = "")
        {
            NotaJual notaJual = new NotaJual();

            ArrayList listNota = notaJual.QueryData(criteria, studentId, value1);

            StreamWriter file = new StreamWriter(namaFile);

            double grandTotal = 0;


            file.WriteLine("A-TIGA Online Course");
            file.WriteLine("a-tigacourse.com");
            file.WriteLine("");
            file.WriteLine("=".PadRight(60, '='));
            file.WriteLine($"Nama Student   : {((NotaJual)listNota[0]).Student.Name}");

            foreach (NotaJual nota in listNota)
            {
                file.Write(nota.NotaJualDetil.Course.Name.PadRight(30,' '));
                file.Write(nota.NotaJualDetil.Harga.ToString().PadRight(3, ' '));
                double subTotal = nota.NotaJualDetil.Harga;
                file.WriteLine("");
                grandTotal += subTotal;
            }

            file.WriteLine("=".PadRight(60, '='));
            file.WriteLine($"Total          : {grandTotal:#,##}");
            file.WriteLine("Thank You For Your Purchases");
            file.WriteLine("");

            file.Close();

            Cetak c = new Cetak(namaFile, font, 20, 10, 10, 10);
            c.PrintFile("text");
        }
        
        
    }
}
