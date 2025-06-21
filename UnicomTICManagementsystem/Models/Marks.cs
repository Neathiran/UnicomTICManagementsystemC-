using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementsystem.Models
{
    internal class Marks
    {
        public int MarkId { get; set; } 
        public int Mark {  get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; } 
    }
}
