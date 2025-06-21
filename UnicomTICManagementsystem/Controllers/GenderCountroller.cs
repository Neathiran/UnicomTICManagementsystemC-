using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Data;
using UnicomTICManagementsystem.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace UnicomTICManagementsystem.Controllers
{
    internal class GenderCountroller
    {
        public List<Gender_mo> getgenderdatabase()
        {
            List<Gender_mo> gender_mo = new List<Gender_mo>();
            string veiwcoursesQuery = @"SELECT * FROM Gender_123";
            using (var conn = Dbconfing.GetConnection())
            {

                SQLiteCommand veiwcourse = new SQLiteCommand(veiwcoursesQuery, conn);
                var readers = veiwcourse.ExecuteReader();
                while (readers.Read())
                {
                    Gender_mo gender = new Gender_mo();
                    gender.Id = readers.GetInt32(0);
                    gender.Name = readers.GetString(1);
                    gender_mo.Add(gender);

                }
                return gender_mo;
            }
        }
        
    }
}
