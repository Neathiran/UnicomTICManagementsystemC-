using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementsystem.Data;
using UnicomTICManagementsystem.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementsystem.Controllers
{
    internal class UserController
    {
        public string CreateUserID(string Age,string NIC_Number,string role)
        {
            string Name = null;
            List<char> NIC = new List<char>();
            foreach (char NIC_Num in NIC_Number)
            {
                NIC.Add(NIC_Num);
            }
           if (role == "Student")
            {
                Name = "UT";
            }
           else if (role == "Lecturers")
            {
                Name = "LC";
            }
            else
            {
                Name = "ST";
            }
            string ID = Name + NIC[3] + NIC[1] + Age + NIC[2] + NIC[4];
            return ID;
        }
        public void AddUsers(string userid,string role)
        {

            using (var Dbconn = Dbconfing.GetConnection())
            {
                var cmd = Dbconn.CreateCommand();

                        string AddscourseQuery = "INSERT INTO Users(UserID,Password,Role) VALUES (@userid,@password,@role)";
                        SQLiteCommand SQLite = new SQLiteCommand(AddscourseQuery, Dbconn);
                
                        SQLite.Parameters.AddWithValue("@userid", userid);
                        SQLite.Parameters.AddWithValue("@password","4321");
                        SQLite.Parameters.AddWithValue("@role", role);
                        SQLite.ExecuteNonQuery();               
            }
        }

        //public void UpdateUser(users_mo user)
        //{
        //    using (var Dbconn = Dbconfing.GetConnection())
        //    {
        //        using (var cmd = Dbconn.CreateCommand())
        //        {
        //            cmd.CommandText = @"
        //        UPDATE Users_123
        //        SET Password = @password,
        //            Role = @role
        //        WHERE UserID = @userID";

        //            cmd.Parameters.AddWithValue("@password", user.Password);
        //            cmd.Parameters.AddWithValue("@role", user.Role);
        //            cmd.Parameters.AddWithValue("@userID", user.Id);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}





        public void Deleteusers(string userid)
        {

            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Users WHERE UserId = @userid";
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Users_mo> GetUsersByRole(string role)
        {
            string query = @"SELECT * FROM Users WHERE Role = @role";

            List<Users_mo> usersList = new List<Users_mo>();

            using (var conn = Dbconfing.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@role", role);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Users_mo user = new Users_mo
                        {
                            UserID = reader.GetString(0),
                            Password = reader.GetString(1),
                            Role = reader.GetString(2)
                        };
                        usersList.Add(user);
                    }
                }
            }

            return usersList;
        }

    }
}
