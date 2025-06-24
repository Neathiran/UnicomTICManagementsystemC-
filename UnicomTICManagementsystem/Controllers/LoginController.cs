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
                        if (reader.Read())  
                        {
                            string storedPassword = reader.GetString(0); 
                            string role = reader.GetString(1);  

                            if (storedPassword == id_Password.Password)  
                            {
                                return role;  
                            }
                            else
                            {
                                
                                return null;
                            }
                        }
                        else
                        {
                           
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}
