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
    internal class MarksController
    {
        public List<Marks_mo> GetMarks()
        {
            List<Marks_mo> marks_mos = new List<Marks_mo>();
            string viewMarksQuery = @"SELECT * FROM Marks";
            using (var conn = Dbconfing.GetConnection())
            {
                SQLiteCommand viewMarks = new SQLiteCommand(viewMarksQuery, conn);
                var reader = viewMarks.ExecuteReader();
                int i = 1;
                while (reader.Read())
                {
                    Marks_mo mark = new Marks_mo();
                    mark.No = i;
                    mark.ID = reader.GetInt32(0);
                    mark.Mark = reader.GetInt32(1);
                    mark.UserID = reader.GetString(2);
                    mark.ExamsID = reader.GetInt32(3);
                    mark.ExamName = reader.GetString(4);
                    marks_mos.Add(mark);
                    i++;
                }
            }
            return marks_mos;
        }
        public void AddMarks(Marks_mo mark)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Marks 
            (Mark, UserID, ExamsID, ExamName)
            VALUES 
            (@mark, @userID, @examsID, @examName)";

                    cmd.Parameters.AddWithValue("@mark", mark.Mark);
                    cmd.Parameters.AddWithValue("@userID", mark.UserID);
                    cmd.Parameters.AddWithValue("@examsID", mark.ExamsID);
                    cmd.Parameters.AddWithValue("@examName", mark.ExamName);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateMarks(Marks_mo updatedMark)
        {
            string updateQuery = @"
            UPDATE Marks 
            SET Mark = @Mark, 
            UserID = @UserID, 
            ExamsID = @ExamsID, 
            ExamName = @ExamName 
            WHERE ID = @ID";

            using (var conn = Dbconfing.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Mark", updatedMark.Mark);
                    cmd.Parameters.AddWithValue("@UserID", updatedMark.UserID);
                    cmd.Parameters.AddWithValue("@ExamsID", updatedMark.ExamsID);
                    cmd.Parameters.AddWithValue("@ExamName", updatedMark.ExamName);
                    cmd.Parameters.AddWithValue("@ID", updatedMark.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteMarksById(int ID)
        {
            string deleteQuery = "DELETE FROM Marks WHERE ID = @ID";

            using (var conn = Dbconfing.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
