using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementsystem.Data;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem.Controllers
{
    internal class SubjectsCountroller
    {



        public List<Subjects_mo> GetSubjects()
        {
            List<Subjects_mo> subjects_mo = new List<Subjects_mo>();
            string veiwstudentsQuery = @"SELECT * FROM Subjects";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwsubjects = new SQLiteCommand(veiwstudentsQuery, conn);
                var readers = veiwsubjects.ExecuteReader();
                int i = 1;
                while (readers.Read())
                {
                    Subjects_mo Subjects_mo_ = new Subjects_mo();
                    Subjects_mo_.No = i;
                    Subjects_mo_.ID = readers.GetInt32(0);
                    Subjects_mo_.SubjectName = readers.GetString(1);
                    Subjects_mo_.CourseId = readers.GetInt32(2);
                    Subjects_mo_.CourseName = readers.GetString(3);
                    subjects_mo.Add(Subjects_mo_);
                    i++;

                }

            }
            return subjects_mo;
        }

            public void AddSubject(Subjects_mo subject)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Subjects (SubjectName, CoursesID,CoursesName) VALUES (@subjectName, @coursesID,@coursesname)";
                    cmd.Parameters.AddWithValue("@subjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@coursesID", subject.CourseId);
                    cmd.Parameters.AddWithValue("@coursesname", subject.CourseName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubject(string subjectname)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Subjects WHERE SubjectName = @subjectname";
                cmd.Parameters.AddWithValue("@subjectname", subjectname);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Subjects_mo> GetsubjectBYcourse(int ID)
        {
            List<Subjects_mo> subjects_mo = new List<Subjects_mo>();
            string viewSubjectByIdQuery = @"SELECT ID,SubjectName FROM Subjects WHERE CoursesID = @coursesID ";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwsubject = new SQLiteCommand(viewSubjectByIdQuery, conn);
                veiwsubject.Parameters.AddWithValue("@coursesID", ID);
                var readers = veiwsubject.ExecuteReader();
                while (readers.Read())
                {
                    Subjects_mo subjects_Mo = new Subjects_mo();
                    subjects_Mo.ID = readers.GetInt32(0);
                    subjects_Mo.SubjectName = readers.GetString(1);
                    subjects_mo.Add(subjects_Mo);

                }

            }
            return subjects_mo;
        }

        public void Delete_Course_subjects(string CoursesName)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Subjects WHERE CoursesName = @coursesname";
                cmd.Parameters.AddWithValue("@coursesname", CoursesName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
