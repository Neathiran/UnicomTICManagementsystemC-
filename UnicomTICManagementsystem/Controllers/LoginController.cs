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
            try
            {
                using (var conn = Dbconfing.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"SELECT Password, Role FROM Users WHERE UserID = @id";
                    cmd.Parameters.AddWithValue("@id", id_Password.Id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // Check if there is a record for the provided UserID
                        {
                            string storedPassword = reader.GetString(0);  // Password from DB
                            string role = reader.GetString(1);  // Role from DB

                            if (storedPassword == id_Password.Password)  // Compare password
                            {
                                return role;  // Return the Role if password matches
                            }
                            else
                            {
                                // Password does not match
                                return null;
                            }
                        }
                        else
                        {
                            // User not found
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions (e.g., DB connection issues)
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}
