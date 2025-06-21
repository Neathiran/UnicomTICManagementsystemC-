using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnicomTICManagementsystem.View
{
    public partial class Exams : Form
    {
        int check = 0;
        SubjectsCountroller subjectsCountroller;
        ExamController examController;
        public Exams()
        {
            InitializeComponent();
            subjectsCountroller = new SubjectsCountroller();
            examController = new ExamController();
            Addcombobox();
            Addview();
        }

        public void Addcombobox()
        {
            List<Subjects_mo> subjects_s = subjectsCountroller.GetSubjects();
            subject_combobox.DataSource = subjects_s;
            subject_combobox.DisplayMember = "SubjectName";
            subject_combobox.ValueMember = "ID";

        }

        public void Addview()
        {
            List<Exams_mo> exam = examController.GetExams();
            exams_view.DataSource = exam;
            exams_view.Columns["ExamID"].Visible = false;
        }

        public void check_inputs()
        {
            if (time_from.Text.Trim() != "" && time_to.Text.Trim() != "" && exam_name.Text.Trim() != "")
            {
                check = 1;

            }
        }

        private string check_time()
        {
            List<Date_Time_mo> date_Time_mo = examController.GetTime(date.Text);

            // Parse input time range
            DateTime timeFrom = DateTime.Parse(time_from.Text);  // e.g. "10:00 AM"
            DateTime timeTo = DateTime.Parse(time_to.Text);      // e.g. "11:00 AM"

            foreach (var slot in date_Time_mo)
            {
                // Expect format like "10:00 AM - 11:00 AM"
                string[] times = slot.Time.Split('-');
                if (times.Length != 2) continue; // Skip malformed

                DateTime existingStart = DateTime.Parse(times[0].Trim());
                DateTime existingEnd = DateTime.Parse(times[1].Trim());

                // Check for overlap
                if (timeFrom < existingEnd && existingStart < timeTo)
                {
                    check = 5;
                    string Time_01 = timeFrom.ToString("HH:mm") + " - " + timeTo.ToString("HH:mm");
                    //MessageBox.Show()
                    return Time_01; // Conflict detected
                }
            }

            return null; // No conflict
        }







        private void button1_Click(object sender, EventArgs e)
        {
            string Time = check_time();
                if (2==2)
                {
                    Exams_mo exams_Mo = new Exams_mo
                    {
                        ExamName = exam_name.Text,
                        SubjectName = exam_name.Text,
                        SubjectsID = Convert.ToInt32(subject_combobox.SelectedValue),
                        Date = date.Text,
                        Time = Time,
                    };
                examController.AddExams(exams_Mo);
                Addview();
                check = 0;
                }
            else
            {
                MessageBox.Show("hii");
            }
            
       
        }
        

        private void back_btn_Click(object sender, EventArgs e)
        {
            Student_Details student = new Student_Details();
            student.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
