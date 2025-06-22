using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementsystem.Models
{
    internal class TimeTables_mo
    {
        public int No {  get; set; }
        public int ID { get; set; }
        public string Date { get; set; }
        public string TimeSlot { get; set; }
        public string SubjectName { get; set; }
        public int SubjectsID { get; set; }
        public string RoomName { get; set; }
        public int RoomID { get; set; }
    }
}
