using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementsystem.Data;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem.Controllers
{
    internal class StudentController
    {
        public List<Students_mo> GetStudents()
        {
            List<Students_mo> students_Mos = new List<Students_mo>();
            string veiwstudentsQuery = @"SELECT * FROM Students";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwstudents = new SQLiteCommand(veiwstudentsQuery, conn);
                var readers = veiwstudents.ExecuteReader();
                int i = 1;
                while (readers.Read())
                {
                    Students_mo students_ = new Students_mo();
                    students_.No = i;
                    students_.Id = readers.GetInt32(0);
                    students_.Name = readers.GetString(1);
                    students_.Age = readers.GetInt32(2);
                    students_.Gender = readers.GetString(3);
                    students_.Address = readers.GetString(4);
                    students_.coursesName = readers.GetString(5);
                    students_.UserId = readers.GetString(6);
                    students_.NIC_Number = readers.GetString(7);
                    students_.CoursesID = readers.GetInt32(8);
                    students_.Date = readers.GetString(9);
                    students_Mos.Add(students_);
                    i++;

                }

            }
            return students_Mos;


        }

        public int AddStudents(Students_mo students_mo)
        {

            using (var Dbconn = Dbconfing.GetConnection())
            {
                var cmd = Dbconn.CreateCommand();
                cmd.CommandText = @"SELECT NICNumber FROM Students WHERE NICNumber = @nicnumber";
                cmd.Parameters.AddWithValue("@nicnumber", students_mo.NIC_Number);
                using (var reader = cmd.ExecuteReader())
                {


                    if (!reader.HasRows)
                    {
                        reader.Close();

                        string AddsstudentsQuery = "INSERT INTO Students (Name,Age,Gender,Address,CoursesName,UserID,NICNumber,CoursesID,Date) VALUES (@name,@age,@gender,@address,@coursesname,@userid,@nicnumber,@coursesid,@date)";
                        SQLiteCommand SQLite = new SQLiteCommand(AddsstudentsQuery, Dbconn);

                        SQLite.Parameters.AddWithValue("@name", students_mo.Name);
                        SQLite.Parameters.AddWithValue("@age", students_mo.Age);
                        SQLite.Parameters.AddWithValue("@gender", students_mo.Gender);
                        SQLite.Parameters.AddWithValue("@address", students_mo.Address);
                        SQLite.Parameters.AddWithValue("@coursesname", students_mo.coursesName);
                        SQLite.Parameters.AddWithValue("@userid", students_mo.UserId);
                        SQLite.Parameters.AddWithValue("@nicnumber", students_mo.NIC_Number);
                        SQLite.Parameters.AddWithValue("@coursesid", students_mo.CoursesID);
                        SQLite.Parameters.AddWithValue("@date", students_mo.Date);
                        SQLite.ExecuteNonQuery();
                        return 1;

                    }
                    else
                    {
                        MessageBox.Show("NIC Number Already EXISTS ");
                        return 0;
                    }
                }
            }
        }

        public void Deletestudents(string userid)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Students WHERE UserId = @userid";
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }



            public void UpdateStudent(Students_mo student)
            {
            using (var Dbconn = Dbconfing.GetConnection())
            {
                   
                    using (var cmd = Dbconn.CreateCommand())
                    {
                        cmd.CommandText = @"
                UPDATE Students SET
                    Name = @name,
                    Age = @age,
                    Gender = @gender,
                    Address = @address,
                    CoursesName = @coursesName,
                    UserID = @userID,
                    NICNumber = @nicNumber,
                    CoursesID = @coursesID
                WHERE ID = @id";

                        cmd.Parameters.AddWithValue("@name", student.Name);
                        cmd.Parameters.AddWithValue("@age", student.Age);
                        cmd.Parameters.AddWithValue("@gender", student.Gender);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@coursesName", student.coursesName);
                        cmd.Parameters.AddWithValue("@userID", student.UserId);
                        cmd.Parameters.AddWithValue("@nicNumber", student.NIC_Number);
                        cmd.Parameters.AddWithValue("@coursesID", student.CoursesID);
                        cmd.Parameters.AddWithValue("@id", student.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

        public void UpdateCourse(Courses_mo courses_mo)
        {
            using (var Dbconn = Dbconfing.GetConnection())
            {

                using (var cmd = Dbconn.CreateCommand())
                {
                    cmd.CommandText = @"
                UPDATE Students SET
                    CoursesName = @coursesName
                WHERE CoursesID = @coursesID";

                    cmd.Parameters.AddWithValue("@coursesName", courses_mo.Name);
                    cmd.Parameters.AddWithValue("@coursesID", courses_mo.Id);


                    cmd.ExecuteNonQuery();
                }
            }
        }





    }
}
