using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Transactions;

namespace Database
{
    public class NotaJual : ITransaction
    {
        #region members
        private string noNota;
        private DateTime tanggal;
        private Student student;
        private NotaJualDetil notaJualDetil;
        private List<NotaJualDetil> listNotaDetil;
        #endregion

        #region properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Student Student { get => student; set => student = value; }
        public NotaJualDetil NotaJualDetil { get => notaJualDetil; set => notaJualDetil = value; }
        public List<NotaJualDetil> ListNotaDetil { get => listNotaDetil; private set => listNotaDetil = value; }
        #endregion

        #region constructors
        public NotaJual(string noNota, DateTime tanggal, Student student)
        {
            NoNota = noNota;
            Tanggal = tanggal;
            Student = student;
            NotaJualDetil = new NotaJualDetil();
            ListNotaDetil = new List<NotaJualDetil>();
        }

        public NotaJual()
        {
            NoNota = "";
            Tanggal = DateTime.Now;
            Student = new Student();
            NotaJualDetil = null;
            ListNotaDetil = new List<NotaJualDetil>();
        }
        #endregion

        #region methods 

        public void Insert()
        {

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {

                    string sql = $"INSERT INTO nota_jual(no_nota, tanggal, student_id) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}', '{Student.Id}')";
                    Execute.DML(sql);

                    foreach (NotaJualDetil notaDetil in ListNotaDetil)
                    {
                        string sql_detil = $"INSERT INTO nota_jual_detil(no_nota, id_course, harga) VALUES ('{NoNota}', '{notaDetil.Course.Id}', '{notaDetil.Course.Price}')";
                        Execute.DML(sql_detil);

                        string sql_enroll = $"INSERT INTO enroll(id_student, id_course, start_date) VALUES ('{Student.Id}', '{notaDetil.Course.Id}', '{Tanggal}')";
                        Execute.DML(sql_enroll);
                    }

                    transaction.Complete();

                }
                catch (Exception error)
                {
                    transaction.Dispose();
                    throw new Exception(error.Message);
                }
            }
        }


        public ArrayList QueryData(string studentId, string criteria = "", string value = "")
        {
            string sql;

            if (criteria == "")
            {
                sql =
                    $"SELECT nota_jual.no_nota, nota_jual.tanggal, nota_jual.student_id " +
                    $"FROM nota_jual " +
                    $"INNER JOIN student ON nota_jual.student_id = student.id " +
                    $"WHERE student_id LIKE '%{studentId}%' ";
            }
            else
            {
                sql =
                    $"SELECT nota_jual.no_nota, nota_jual.tanggal, nota_jual.student_id " +
                    $"FROM nota_jual " +
                    $"INNER JOIN student ON nota_jual.student_id = student.id " +
                    $"WHERE student_id LIKE '%{studentId}%' AND {criteria} LIKE '%{value}%' ";
            }

            MySqlDataReader result = Execute.Query(sql);
            ArrayList list = new ArrayList();

            while (result.Read())
            {
                string noNota = result.GetString(0);

                DateTime tanggal = result.GetDateTime(1);

                Student student = new Student();

                ArrayList students = student.QueryData("student.id", result.GetString(2));

                NotaJual notaJual = new NotaJual(noNota, tanggal, (Student)students[0]);

                string sqlDetil = $"SELECT nota_jual_detil.id_course, nota_jual_detil.harga " +
                    $"FROM nota_jual " +
                    $"INNER JOIN nota_jual_detil ON nota_jual.no_nota = nota_jual_detil.no_nota " +
                    $"WHERE nota_jual.no_nota = '{noNota}' ";

                MySqlDataReader resDetil = Execute.Query(sqlDetil);

                while (resDetil.Read() == true)
                {
                    Course course = new Course();

                    double harga = resDetil.GetDouble(1);

                    ArrayList courses = course.QueryData("course.id", resDetil.GetString(0));

                    notaJual.TambahDetil((Course)courses[0], harga);
                }

                list.Add(notaJual);
            }

            result.Close();
            Execute.CloseReader();
            return list;
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

                Course course = new Course(result.GetValue(0).ToString(), result.GetValue(1).ToString(), result.GetString(2), result.GetString(3), result.GetDouble(4), result.GetDateTime(5), topic, instructor);
                listCourse.Add(course);
            }
            result.Close();
            return listCourse;
        }

        public string GenerateNoNota(string id)
        {
            string sql = $"SELECT MAX(RIGHT(nota_jual.no_nota, 3)) FROM nota_jual WHERE nota_jual.student_id LIKE '%{id}%' ";

            MySqlDataReader result = Execute.Query(sql);

            string hasilNota;

            if (result.Read())
            {
                if (result.GetValue(0).ToString() != "")
                {
                    int noUrut = result.GetInt32(0) + 1;
                    hasilNota = DateTime.Now.Year +
                                DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                id.PadLeft(2, '0') +
                                noUrut.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilNota =
                           DateTime.Now.Year +
                           DateTime.Now.Month.ToString().PadLeft(2, '0') +
                           DateTime.Now.Day.ToString().PadLeft(2, '0') +
                           id.PadLeft(2, '0') +
                           "001";
                }
            }
            else
            {
                hasilNota = DateTime.Now.Year +
                            DateTime.Now.Month.ToString().PadLeft(2, '0') +
                            DateTime.Now.Day.ToString().PadLeft(2, '0') +
                            id.PadLeft(2, '0') +
                            "001";
            }
            Execute.CloseReader();
            return hasilNota;
        }

        public void TambahDetil(Course course, double harga)
        {
            NotaJualDetil notaJualDetil = new NotaJualDetil(course, harga);
            ListNotaDetil.Add(notaJualDetil);
        }

        public static void CetakNota(Font font, string criteria = "", string value1 = "", string studentId = "", string namaFile = "")
        {
            NotaJual notaJual = new NotaJual();

            ArrayList listNota = notaJual.QueryData(studentId, criteria, value1);

            StreamWriter file = new StreamWriter(namaFile);


            foreach (NotaJual nota in listNota)
            {
                double grandTotal = 0;

                file.WriteLine("A-TIGA Online Course");
                file.WriteLine("a-tigacourse.com");
                file.WriteLine("");
                file.WriteLine($"Nama Student   : {((NotaJual)listNota[0]).Student.Name}");

                file.WriteLine($"No. Nota   : {nota.NoNota} ");
                file.WriteLine("=".PadRight(60, '='));

                foreach (NotaJualDetil notaDetil in nota.ListNotaDetil)
                {
                    file.Write(notaDetil.Course.Name.PadRight(30, ' '));
                    file.Write(notaDetil.Harga.ToString().PadRight(3, ' '));
                    double subTotal = notaDetil.Harga;
                    file.WriteLine("");
                    grandTotal += subTotal;
                }

                file.WriteLine("=".PadRight(60, '='));
                file.WriteLine($"Total          : {grandTotal:#,##}");
                file.WriteLine("Thank You For Your Purchases");
                file.WriteLine("");
            }


            file.Close();

            Cetak c = new Cetak(namaFile, font, 20, 10, 10, 10);
            c.PrintFile("text");
        }
        #endregion



    }
}
