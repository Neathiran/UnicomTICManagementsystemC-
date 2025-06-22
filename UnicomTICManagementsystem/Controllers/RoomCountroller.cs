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
    internal class RoomCountroller
    {
        public List<Rooms_mo> GetRooms()
        {
            List<Rooms_mo> rooms_mo = new List<Rooms_mo>();
            string veiwroomsQuery = @"SELECT * FROM Rooms";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwrooms = new SQLiteCommand(veiwroomsQuery, conn);
                var readers = veiwrooms.ExecuteReader();
                int i = 1;
                while (readers.Read())
                {
                    if(readers.GetString(2) != "")
                    {
                        Rooms_mo Rooms_mo_ = new Rooms_mo();
                        Rooms_mo_.No = i;
                        Rooms_mo_.ID = readers.GetInt32(0);
                        Rooms_mo_.RoomType = readers.GetString(1);
                        Rooms_mo_.RoomName = readers.GetString(2);
                        rooms_mo.Add(Rooms_mo_);
                        i++;
                    }
                   

                }

            }
            return rooms_mo;
        }
        public List<string> GetRoomType()
        {
            List<string> _rooms_mo = new List<string>();
            string viewroomtypeByIdQuery = @"SELECT RoomType FROM Rooms WHERE RoomName = @roomname ";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwroomtype = new SQLiteCommand(viewroomtypeByIdQuery, conn);
                veiwroomtype.Parameters.AddWithValue("@roomname", "");
                var readers = veiwroomtype.ExecuteReader();
                while (readers.Read())
                {
                    _rooms_mo.Add(readers.GetString(0));
                
                }

            }
            return _rooms_mo;
        }



        public void AddRooms(Rooms_mo room_mo)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Rooms (RoomType, RoomName) VALUES (@roomtype, @roomname)";
                    cmd.Parameters.AddWithValue("@roomtype", room_mo.RoomType);
                    cmd.Parameters.AddWithValue("@roomname", room_mo.RoomName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddRoomtype(string room_mo)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Rooms (RoomType, RoomName) VALUES (@roomtype, @roomname)";
                    cmd.Parameters.AddWithValue("@roomtype", room_mo);
                    cmd.Parameters.AddWithValue("@roomname", "");
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete_roomname(string roomname)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Rooms WHERE RoomName = @roomname";
                cmd.Parameters.AddWithValue("@roomname", roomname);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete_roomtype(string roomtype)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Rooms WHERE RoomType = @roomtype";
                cmd.Parameters.AddWithValue("@roomtype", roomtype);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Rooms_mo> GetRoomName(string RoomType)
        {
            List<Rooms_mo> _rooms_mo_ = new List<Rooms_mo>();
            string viewroomnameByRoomtypeQuery = @"SELECT ID,RoomName FROM Rooms WHERE RoomType = @roomtype ";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwroomName = new SQLiteCommand(viewroomnameByRoomtypeQuery, conn);
                veiwroomName.Parameters.AddWithValue("@roomtype", RoomType);
                var readers = veiwroomName.ExecuteReader();
                while (readers.Read())
                {
                    if (readers.GetString(1) != "")
                    {
                        Rooms_mo rooms_Mo = new Rooms_mo();
                        rooms_Mo.ID = readers.GetInt32(0);
                        rooms_Mo.RoomName = readers.GetString(1);
                        _rooms_mo_.Add(rooms_Mo);
                    }

                }

            }
            return _rooms_mo_;
        }


    }
}
