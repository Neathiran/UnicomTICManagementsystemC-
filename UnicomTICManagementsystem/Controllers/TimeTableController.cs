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
    internal class TimeTableController
    {
        public List<Date_Time_mo> GetTime_Date(string RoomName)
        {
            string viewTimebyroomnameQuery = @"SELECT TimeSlot,Date FROM TimeTable WHERE RoomName = @roomname ";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwdatetime = new SQLiteCommand(viewTimebyroomnameQuery, conn);
                veiwdatetime.Parameters.AddWithValue("@roomname", RoomName);
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

        public List<TimeTables_mo> GetTimeTable()
        {
            List<TimeTables_mo> timeTables_mo = new List<TimeTables_mo>();
            string veiwTimeTableQuery = @"SELECT * FROM TimeTable";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwTimeTable = new SQLiteCommand(veiwTimeTableQuery, conn);
                var readers = veiwTimeTable.ExecuteReader();
                int i = 1;
                while (readers.Read())
                {
                    TimeTables_mo timetables_mo = new TimeTables_mo();
                    timetables_mo.No = i;
                    timetables_mo.ID = readers.GetInt32(0);
                    timetables_mo.Date = readers.GetString(1);
                    timetables_mo.TimeSlot = readers.GetString(2);
                    timetables_mo.RoomID = readers.GetInt32(3);
                    timetables_mo.RoomName = readers.GetString(4);
                    timetables_mo.SubjectsID = readers.GetInt32(5);
                    timetables_mo.SubjectName = readers.GetString(6);

                    timeTables_mo.Add(timetables_mo);
                    i++;

                }

            }
            return timeTables_mo;


        }

        public void AddTimeTable(TimeTables_mo timetable)
        {
            using (var conn = Dbconfing.GetConnection())
            {

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                INSERT INTO TimeTable 
                (Date, TimeSlot, RoomsID, RoomName, SubjectsID, SubjectName)
                VALUES 
                (@date, @timeSlot, @roomsID, @roomName, @subjectsID, @subjectName)";

                    cmd.Parameters.AddWithValue("@date", timetable.Date);
                    cmd.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@roomsID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@roomName", timetable.RoomName);
                    cmd.Parameters.AddWithValue("@subjectsID", timetable.SubjectsID);
                    cmd.Parameters.AddWithValue("@subjectName", timetable.SubjectName);

                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
