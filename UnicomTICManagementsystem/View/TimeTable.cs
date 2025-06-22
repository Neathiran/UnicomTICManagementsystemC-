using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem.View
{
    public partial class TimeTable : Form
    {
        int check_all = 0;
        TimeTableController timeTableController;
        SubjectsCountroller subjectsCountroller;
        RoomCountroller roomCountroller;
        public TimeTable()
        {
            InitializeComponent();
            Add_Course_combo();
            Add_Subject_combo();
            Add_Roomtype_combo();
            Add_Roomname_combo();
            addtoveiw();
            timeTableController = new TimeTableController();
            subjectsCountroller = new SubjectsCountroller();
            roomCountroller = new RoomCountroller();

        }

        public string check_time_()
        {
            List<Date_Time_mo> date_Time_mo = timeTableController.GetTime_Date(roomname_combobox.Text);


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
                    if (check_all == 2)
                    {
                        if (date.Text == slot.Date)
                        {
                            MessageBox.Show("The Room Time Already Exists");
                            return null;
                        }
                    }
                }
            }
            string Time_01 = timeFrom.ToString("hh:mm tt") + " - " + timeTo.ToString("hh:mm tt");
            return Time_01;
        }

        //public void Add_Course_combo()
        //{
        //    CourseController courseController = new CourseController();
        //    List<Courses_mo> courses_mo = courseController.GetCourse();
        //    course_combobox.DataSource = courses_mo;
        //    course_combobox.DisplayMember = "Name";
        //    course_combobox.ValueMember = "Id";

        //}
        //public void Add_Subject_combo()
        //{
        //    //SubjectsCountroller subjectsCountroller = new SubjectsCountroller();
        //    int CourseId = Convert.ToInt32(course_combobox.SelectedValue);
        //    List<Subjects_mo> subjects_Mos = subjectsCountroller.GetsubjectBYcourse(CourseId);
        //    subject_combobox.DataSource = subjects_Mos;
        //    course_combobox.DisplayMember = "SubjectName";
        //    course_combobox.ValueMember = "ID";
        //}

        public void Add_Course_combo()
        {
            CourseController courseController = new CourseController();
            List<Courses_mo> courses_mo = courseController.GetCourse();

            course_combobox.DisplayMember = "Name";
            course_combobox.ValueMember = "Id";
            course_combobox.DataSource = courses_mo;
            course_combobox.SelectedIndex = -1;
        }

        public void Add_Subject_combo()
        {
            if (check_all == 2)
            {
                int CourseId;
                if (course_combobox.SelectedValue != null && int.TryParse(course_combobox.SelectedValue.ToString(), out CourseId))
                {
                    SubjectsCountroller subjectsCountroller = new SubjectsCountroller();
                    List<Subjects_mo> subjects_Mos = subjectsCountroller.GetsubjectBYcourse(CourseId);

                    subject_combobox.DisplayMember = "SubjectName";
                    subject_combobox.ValueMember = "ID";
                    subject_combobox.DataSource = subjects_Mos;
                    subject_combobox.SelectedIndex = -1;
                }
                else
                {
                    SubjectsCountroller subjectsCountroller = new SubjectsCountroller();
                    List<Subjects_mo> subjects_Mos_ = subjectsCountroller.GetSubjects();
                    subject_combobox.DisplayMember = "SubjectName";
                    subject_combobox.ValueMember = "ID";
                    subject_combobox.DataSource = subjects_Mos_;
                    subject_combobox.SelectedIndex = -1;
                }
            }


        }




        public void Add_Roomtype_combo()
        {
            RoomCountroller roomCountroller = new RoomCountroller();
            List<string> room_type = roomCountroller.GetRoomType();
            roomtype_combobox.DataSource = room_type;
            roomtype_combobox.SelectedIndex = -1;

        }

        public void Add_Roomname_combo()
        {
            if (check_all == 2)
            {
                RoomCountroller roomCountroller = new RoomCountroller();
                List<Rooms_mo> rooms = roomCountroller.GetRoomName(roomtype_combobox.Text);
                roomname_combobox.DataSource = rooms;
                roomname_combobox.DisplayMember = "RoomName";
                roomname_combobox.ValueMember = "ID";
                roomname_combobox.SelectedIndex = -1;
            }
            else
            {
                try
                {
                    RoomCountroller roomCountroller = new RoomCountroller();
                    List<Rooms_mo> rooms_ = roomCountroller.GetRooms();
                    roomname_combobox.DataSource = rooms_;
                    roomname_combobox.DisplayMember = "RoomName";
                    roomname_combobox.ValueMember = "ID";
                    roomname_combobox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        public void addtoveiw()
        {
            TimeTableController timeTableController = new TimeTableController();
            List<TimeTables_mo> timeTables = timeTableController.GetTimeTable();
            timetable_view.DataSource = timeTables;
            timetable_view.Columns["ID"].Visible = false;
            timetable_view.Columns["SubjectsID"].Visible = false;
            timetable_view.Columns["RoomID"].Visible = false;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string Time = check_time_();
            if (Time != null)
            {
                TimeTables_mo timeTables = new TimeTables_mo
                {
                    SubjectName= subject_combobox.Text,
                    SubjectsID = Convert.ToInt32(subject_combobox.SelectedValue),
                    Date = date.Text,
                    TimeSlot = Time,
                    RoomName = roomname_combobox.Text,
                    RoomID = Convert.ToInt32(roomname_combobox.SelectedValue)
                };
                TimeTableController timeTableController = new TimeTableController();
                timeTableController.AddTimeTable(timeTables);
                addtoveiw();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Student_Details student_Details = new Student_Details();
            student_Details.Show();
            this.Hide();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {

        }

        private void course_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_all = 2;
            Add_Subject_combo();
        }

        private void timetable_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void time_from_TextChanged(object sender, EventArgs e)
        {
            check_all = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            check_all = 1;
        }

        private void course_TextChanged(object sender, EventArgs e)
        {
            Add_Subject_combo();
        }

        private void subject_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomtype_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_all = 2;
            Add_Roomname_combo();
        }

        private void roomname_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
