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
    internal class StaffCountroller
    {
        public List<Staff_mo> GetStaff()
        {
            List<Staff_mo> staffMos = new List<Staff_mo>();
            string viewStaffQuery = @"SELECT * FROM Staffs";  

            using (var conn = Dbconfing.GetConnection())
            {
                using (SQLiteCommand viewStaff = new SQLiteCommand(viewStaffQuery, conn))
                {
                    using (var reader = viewStaff.ExecuteReader())
                    {
                        int i = 1;
                        while (reader.Read())
                        {
                            Staff_mo staff = new Staff_mo
                            {
                                No = i,
                                ID = reader.GetInt32(0),
                                StaffName = reader.GetString(1),
                                Gender = reader.GetString(3),
                                UserID = reader.GetString(5),
                                NICNumber = reader.GetString(4),
                                PhoneNumber = reader.GetString(2),
                                Date = reader.GetString(6)
                            };

                            staffMos.Add(staff);
                            i++;
                        }
                    }
                }
            }

            return staffMos;
        }
        public int AddStaff(Staff_mo staff_mo)
        {
            using (var Dbconn = Dbconfing.GetConnection())
            {
                var cmd = Dbconn.CreateCommand();
                cmd.CommandText = @"SELECT NICNumber FROM Staffs WHERE NICNumber = @nicnumber";
                cmd.Parameters.AddWithValue("@nicnumber", staff_mo.NICNumber);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();

                        string AddStaffQuery = @"INSERT INTO Staffs (StaffName, Gender, UserID, NICNumber, PhoneNumber, Date) 
                                         VALUES (@staffname, @gender, @userid, @nicnumber, @phonenumber, @date)";

                        SQLiteCommand insertCmd = new SQLiteCommand(AddStaffQuery, Dbconn);

                        insertCmd.Parameters.AddWithValue("@staffname", staff_mo.StaffName);
                        insertCmd.Parameters.AddWithValue("@gender", staff_mo.Gender);
                        insertCmd.Parameters.AddWithValue("@userid", staff_mo.UserID);
                        insertCmd.Parameters.AddWithValue("@nicnumber", staff_mo.NICNumber);
                        insertCmd.Parameters.AddWithValue("@phonenumber", staff_mo.PhoneNumber);
                        insertCmd.Parameters.AddWithValue("@date", staff_mo.Date);

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
        public void DeleteStaff(string userid)
        {
            using (var conn = Dbconfing.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Staffs WHERE UserID = @userid";
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateStaff(Staff_mo staff)
        {
            using (var Dbconn = Dbconfing.GetConnection())
            {
                using (var cmd = Dbconn.CreateCommand())
                {
                    cmd.CommandText = @"
            UPDATE Staffs SET
                StaffName = @staffName,
                PhoneNumber = @phoneNumber,
                Gender = @gender,
                NICNumber = @nicNumber,
                UserID = @userID,
                Date = @date
            WHERE ID = @id";

                    cmd.Parameters.AddWithValue("@staffName", staff.StaffName);
                    cmd.Parameters.AddWithValue("@phoneNumber", staff.PhoneNumber);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@nicNumber", staff.NICNumber);
                    cmd.Parameters.AddWithValue("@userID", staff.UserID);
                    cmd.Parameters.AddWithValue("@date", staff.Date);
                    cmd.Parameters.AddWithValue("@id", staff.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
