using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementsystem.Models
{
    internal class Exams_mo
    {
        public int NO {  get; set; }
        public int ExamID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string RoomName { get; set; }
        public string ExamName { get; set; }
        public int SubjectsID { get; set; }
        public string SubjectName { get; set; }
    }
}
