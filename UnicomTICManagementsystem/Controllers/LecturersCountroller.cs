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
    internal class LecturersCountroller
    {
        public List<Lecturers_mo> GetLecturers()
        {
            List<Lecturers_mo> lecturers_Mos = new List<Lecturers_mo>();
            string viewLecturersQuery = @"SELECT * FROM Lecturers";


                using (var conn = Dbconfing.GetConnection()) 
                {

                    using (SQLiteCommand viewLecturers = new SQLiteCommand(viewLecturersQuery, conn))
                    {
                        using (var reader = viewLecturers.ExecuteReader())
                        {
                            int i = 1;  
                            while (reader.Read())
                            {
                              
                                Lecturers_mo lecturer = new Lecturers_mo
                                {
                                    No = i,
                                    ID = reader.GetInt32(0),           
                                    LecturerName = reader.GetString(1), 
                                    CoursesID = reader.GetInt32(2),    
                                    Gender = reader.GetString(3),    
                                    CourseName = reader.GetString(4), 
                                    UserID = reader.GetString(5),     
                                    NICNumber = reader.GetString(6),   
                                    PhoneNumber = reader.GetString(7), 
                                    Date = reader.GetString(8)         
                                };

                                lecturers_Mos.Add(lecturer);
                                i++;  
                            }
                        }
                    }
                }
            

            return lecturers_Mos;  
        }

        public int AddLecturer(Lecturers_mo lecturer_mo)
        {
            using (var Dbconn = Dbconfing.GetConnection())
            {
                var cmd = Dbconn.CreateCommand();
                cmd.CommandText = @"SELECT NICNumber FROM Lecturers WHERE NICNumber = @nicnumber";
                cmd.Parameters.AddWithValue("@nicnumber", lecturer_mo.NICNumber);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();

                        string AddLecturerQuery = @"INSERT INTO Lecturers (LecturerName, CoursesID, Gender, CourseName, UserID, NICNumber, PhoneNumber, Date) 
                                            VALUES (@lecturername, @coursesid, @gender, @coursename, @userid, @nicnumber, @phonenumber, @date)";

                        SQLiteCommand insertCmd = new SQLiteCommand(AddLecturerQuery, Dbconn);

                        insertCmd.Parameters.AddWithValue("@lecturername", lecturer_mo.LecturerName);
                        insertCmd.Parameters.AddWithValue("@coursesid", lecturer_mo.CoursesID);
                        insertCmd.Parameters.AddWithValue("@gender", lecturer_mo.Gender);
                        insertCmd.Parameters.AddWithValue("@coursename", lecturer_mo.CourseName);
                        insertCmd.Parameters.AddWithValue("@userid", lecturer_mo.UserID);
                        insertCmd.Parameters.AddWithValue("@nicnumber", lecturer_mo.NICNumber);
                        insertCmd.Parameters.AddWithValue("@phonenumber", lecturer_mo.PhoneNumber);
                        insertCmd.Parameters.AddWithValue("@date", lecturer_mo.Date);

                        insertCmd.ExecuteNonQuery();

                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("NIC Number Already EXISTS");
                        return 0;
                    }
                }
            }
        }
        public void DeleteLecturer(string userid)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Lecturers WHERE UserID = @userid";
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateLecturer(Lecturers_mo lecturer)
        {
            using (var Dbconn = Dbconfing.GetConnection())
            {
                using (var cmd = Dbconn.CreateCommand())
                {
                    cmd.CommandText = @"
            UPDATE Lecturers SET
                LecturerName = @lecturerName,
                CoursesID = @coursesID,
                Gender = @gender,
                CourseName = @courseName,
                UserID = @userID,
                NICNumber = @nicNumber,
                PhoneNumber = @phoneNumber,
                Date = @date
            WHERE ID = @id";

                    cmd.Parameters.AddWithValue("@lecturerName", lecturer.LecturerName);
                    cmd.Parameters.AddWithValue("@coursesID", lecturer.CoursesID);
                    cmd.Parameters.AddWithValue("@gender", lecturer.Gender);
                    cmd.Parameters.AddWithValue("@courseName", lecturer.CourseName);
                    cmd.Parameters.AddWithValue("@userID", lecturer.UserID);
                    cmd.Parameters.AddWithValue("@nicNumber", lecturer.NICNumber);
                    cmd.Parameters.AddWithValue("@phoneNumber", lecturer.PhoneNumber);
                    cmd.Parameters.AddWithValue("@date", lecturer.Date);
                    cmd.Parameters.AddWithValue("@id", lecturer.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
