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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementsystem.View
{
    public partial class Exams : Form
    {
        int check = 0;
        int selectedcourseId = -1;
        SubjectsCountroller subjectsCountroller;
        ExamController examController;
        public Exams()
        {
            InitializeComponent();
            subjectsCountroller = new SubjectsCountroller();
            examController = new ExamController();
            back_from__search.Visible = false;
            Addcombobox();
            Addview();

        }

        public void searchExamName()
        {

            List<Exams_mo> Exams_mo = examController.GetExams();
            string Name = exam_name.Text;
            foreach (var exam in Exams_mo)
            {
                if (exam.ExamName == Name)
                {
                    List<Exams_mo> search = new List<Exams_mo>();
                    search.Add(exam);
                    exams_view.DataSource = search;

                }




            }
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
            exams_view.Columns["RoomName"].Visible = false;
            exams_view.Columns["SubjectsID"].Visible = false;
        }

        public void check_inputs()
        {
            if (string.IsNullOrWhiteSpace(exam_name.Text))
            {
                MessageBox.Show("Exam name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exam_name.Focus();
                return;
            }
            check = 4;
        }


        private string check_time_()
        {
            List<Date_Time_mo> date_Time_mo = examController.GetTime(date.Text);


            DateTime timeFrom = DateTime.Parse(time_from.Text);
            DateTime timeTo = DateTime.Parse(time_to.Text);

            foreach (var slot in date_Time_mo)
            {
                string[] times = slot.Time.Split('-');
                if (times.Length != 2) continue;

                DateTime existingStart = DateTime.Parse(times[0].Trim());
                DateTime existingEnd = DateTime.Parse(times[1].Trim());



                if (timeFrom < existingEnd && existingStart < timeTo)
                {
                    if (check != 3)
                    {
                        MessageBox.Show("Time conflict detected with another exam.");
                        return null;
                    }
                }
            }
            string Time_01 = timeFrom.ToString("hh:mm tt") + " - " + timeTo.ToString("hh:mm tt");
            return Time_01;
        }







        private void button1_Click(object sender, EventArgs e)
        {
            string Time = check_time_();
            if (Time != null)
            {
                Exams_mo exams_Mo = new Exams_mo
                {
                    ExamName = exam_name.Text,
                    SubjectName = subject_combobox.Text,
                    SubjectsID = Convert.ToInt32(subject_combobox.SelectedValue),
                    Date = date.Text,
                    Time = Time,
                };
                examController.AddExams(exams_Mo);
                Addview();
                exam_name.Clear();
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

        private void time_from_TextChanged(object sender, EventArgs e)
        {
            check = 3;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            check_inputs();
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                examController.DeleteExam(exam_name.Text);
                MessageBox.Show("Delete successful.");
                exam_name.Clear();
                Addview();
            }
            else
            {
                exam_name.Clear();
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            check_inputs();
            searchExamName();
            back_from__search.Visible = true;
        }

        private void Mouse_Click(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_CLick(object sender, MouseEventArgs e)
        {



        }

        private void View_SelectionChanged(object sender, EventArgs e)
        {

            if (exams_view.SelectedRows.Count > 0)
            {
                var row = exams_view.SelectedRows[0];
                Exams_mo exam_mo = row.DataBoundItem as Exams_mo;
                if (exam_mo != null)
                {
                    string[] times = exam_mo.Time.Split('-');
                    selectedcourseId = exam_mo.ExamID;
                    exam_name.Text = exam_mo.ExamName;
                    date.Text = exam_mo.Date;
                    time_from.Text = times[0];
                    time_to.Text = times[1];
                    subject_combobox.Text = exam_mo.SubjectName;





                }
            }
            else
            {
                exam_name.Clear();
                selectedcourseId = -1;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (selectedcourseId > 0)
            {
                string Time = check_time_();
                Exams_mo exams_Mo = new Exams_mo
                {
                    ExamID = selectedcourseId,
                    ExamName = exam_name.Text,
                    SubjectName = subject_combobox.Text,
                    SubjectsID = Convert.ToInt32(subject_combobox.SelectedValue),
                    Date = date.Text,
                    Time = Time,

                };
                examController.UpdateExams(exams_Mo);
                MessageBox.Show("Update Sucessful");
                exam_name.Clear();
                Addview();


            }
            else
            {
                MessageBox.Show("Select the Raw Fist");
            }
        }

        private void time_to_TextChanged(object sender, EventArgs e)
        {
            check = 3;
        }

        private void back_from__search_Click(object sender, EventArgs e)
        {

            Addview();
            back_from__search.Visible = false;
        }
    }
}
