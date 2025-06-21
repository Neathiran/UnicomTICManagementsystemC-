using Microsoft.VisualBasic.ApplicationServices;
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
    internal class LoginController
    {
        public string Check(Id_Password id_Password)
        {
            using (var conn = Dbconfing.GetConnection())
            {

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT UserID, Password, Role FROM Users_123 WHERE UserID = @id";
                cmd.Parameters.AddWithValue("@id", id_Password.Id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        users_mo users = new users_mo();
                        users.Id = reader.GetString(reader.GetOrdinal("UserID"));
                        users.Password = reader.GetString(reader.GetOrdinal("Password"));
                        users.Role = reader.GetString(reader.GetOrdinal("Role"));


                        if (users.Password == id_Password.Password)
                        {
                            string Role = users.Role;
                            return Role;
                        }
                    }
                }
            }


            return null;
        }
    }
}
