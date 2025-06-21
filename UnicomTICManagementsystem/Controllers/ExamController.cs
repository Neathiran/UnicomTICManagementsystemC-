using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementsystem.Data;
using UnicomTICManagementsystem.Models;
using static System.Net.Mime.MediaTypeNames;

namespace UnicomTICManagementsystem.Controllers
{
    internal class ExamController
    {
        public List<Date_Time_mo> GetTime(string Date)
        { 
            string viewroomtypeByIdQuery = @"SELECT Time FROM Exams_01 WHERE Date = @date ";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwdatetime = new SQLiteCommand(viewroomtypeByIdQuery, conn);
                veiwdatetime.Parameters.AddWithValue("@date", Date);
                var readers = veiwdatetime.ExecuteReader();
                List<Date_Time_mo> date_Time_mo_ = new List<Date_Time_mo>();
                while (readers.Read())
                {
                    Date_Time_mo date_Time_Mo = new Date_Time_mo();
                    date_Time_Mo.Time = readers.GetString(0);
                    date_Time_Mo.Date = readers.GetString(1);
                    date_Time_mo_.Add(date_Time_Mo);

                }
                return date_Time_mo_;

            }
           
        }
        public List<Exams_mo> GetExams()
        {
            List<Exams_mo> Exams_mo_ = new List<Exams_mo>();
            string veiwroomsQuery = @"SELECT * FROM Exams_01";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwrooms = new SQLiteCommand(veiwroomsQuery, conn);
                var readers = veiwrooms.ExecuteReader();
                int i = 1;
                while (readers.Read())
                {
                    if (readers.GetString(2) != "")
                    {
                        Exams_mo exams_mo = new Exams_mo();
                        exams_mo.NO = i;
                        exams_mo.ExamID = readers.GetInt32(0);
                        exams_mo.Date = readers.GetString(1);
                        exams_mo.Time = readers.GetString(2);
                        exams_mo.ExamName = readers.GetString(3);
                        exams_mo.SubjectsID = readers.GetInt32(4);
                        exams_mo.SubjectName = readers.GetString(5);
                        //exams_mo.RoomName = readers.GetString(6);
                        Exams_mo_.Add(exams_mo);
                        i++;
                    }


                }

            }
            return Exams_mo_;
        }

        public void AddExams(Exams_mo exams_mo)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    string query = @"
    INSERT INTO Exams_01 (Date, Time, ExamName, SubjectsID, SubjectName) 
    VALUES (@date, @time, @examName, @subjectsID, @subjectName)";

                    cmd.Parameters.AddWithValue("@date", exams_mo.Date);
                    cmd.Parameters.AddWithValue("@time", exams_mo.Time);
                    cmd.Parameters.AddWithValue("@examName", exams_mo.ExamName);
                    cmd.Parameters.AddWithValue("@subjectsID", exams_mo.SubjectsID);
                    cmd.Parameters.AddWithValue("@subjectName", exams_mo.SubjectName);

                }
            }
        }

    }
}
