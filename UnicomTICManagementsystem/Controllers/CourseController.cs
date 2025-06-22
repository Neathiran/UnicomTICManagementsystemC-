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
    internal  class CourseController
    {
        public  List<Courses_mo> GetCourse()
        {
            List<Courses_mo> courses = new List<Courses_mo>();
            string veiwcoursesQuery = @"SELECT * FROM Courses";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwcourse = new SQLiteCommand(veiwcoursesQuery, conn);
                var readers = veiwcourse.ExecuteReader();
                int i = 1;
                while (readers.Read())   
                {
                    Courses_mo course = new Courses_mo();
                    course.No = i;
                    course.Id = readers.GetInt32(0);
                    course.Name = readers.GetString(1);
                    courses.Add(course);
                    i++;
                  
                }

            }
            return courses;
           

        }
        public void UpdateCourses(Courses_mo courses)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Courses SET CourseName = @name WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", courses.Name);
                cmd.Parameters.AddWithValue("@id", courses.Id);
                cmd.ExecuteNonQuery();
            }
        }



        public void Addcourse(Courses_mo courses)
        {

            using (var Dbconn = Dbconfing.GetConnection())
            {
                var cmd = Dbconn.CreateCommand();
                cmd.CommandText = @"SELECT CourseName FROM Courses WHERE CourseName = @name";
                cmd.Parameters.AddWithValue("@name", courses.Name);
                using (var reader = cmd.ExecuteReader())
                {
                    

                        if (!reader.HasRows) 
                    {
                        reader.Close();

                        string AddscourseQuery = "INSERT INTO Courses(CourseNAME) VALUES (@name)";
                        SQLiteCommand SQLite = new SQLiteCommand(AddscourseQuery, Dbconn);

                        SQLite.Parameters.AddWithValue("@name", courses.Name);
                        SQLite.ExecuteNonQuery();


                    }
                    else
                    {
                        MessageBox.Show("COURSE NAME ALREADY EXISTS ");
                    }
                }
            }
        }  
        public void Deletecourse(string courses)
        {
            
                using (var conn = Dbconfing.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Courses WHERE CourseName = @coursename";
                    cmd.Parameters.AddWithValue("@coursename", courses);
                    cmd.ExecuteNonQuery();
                }
            }
        
     }
}
