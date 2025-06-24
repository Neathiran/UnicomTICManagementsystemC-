using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UnicomTICManagementsystem.View
{
    public partial class TimeTable : Form
    {
        int check_all_combo = 0;
        int selectedstudentid = 0;
        int check_all_time = 0;
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

        //public string check_time_()
        //{
        //    if (DateTime.TryParseExact(time_from.Text, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeFrom) &&
        //         DateTime.TryParseExact(time_to.Text, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTo))
        //    {
        //        if (timeFrom < timeTo)
        //        {
        //            List<Date_Time_mo> date_Time_mo = timeTableController.GetTime_Date(roomname_combobox.Text);


        //            foreach (var slot in date_Time_mo)
        //            {
        //                string[] times = slot.Time.Split('-');
        //                if (times.Length != 2) continue;

        //                DateTime existingStart = DateTime.Parse(times[0].Trim());
        //                DateTime existingEnd = DateTime.Parse(times[1].Trim());



        //                if (timeFrom < existingEnd && existingStart < timeTo)
        //                {
        //                    if (check_all_time != 0)
        //                    {
        //                        if (date.Text == slot.Date)
        //                        {
        //                            MessageBox.Show("The Room Time Already Exists");
        //                            check_all_time = 0;
        //                            return null;
        //                        }
        //                        string Time_01 = timeFrom.ToString("hh:mm tt") + " - " + timeTo.ToString("hh:mm tt");
        //                        return Time_01;
        //                    }

        //                }
        //                else
        //                {

        //                }
        //        else 
        //                { 

        //                }

        private string CheckTime()
        {
            string[] formats = { "h:mm tt", "hh:mm tt" };

            if (DateTime.TryParseExact(time_from.Text.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeFrom) &&
                DateTime.TryParseExact(time_to.Text.Trim(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTo))
            {
                if (timeFrom < timeTo)
                {

                    List<Date_Time_mo> examSlots = timeTableController.GetTime_Date(roomname_combobox.Text);

                    foreach (var slot in examSlots)
                    {

                        string[] times = slot.Time.Split('-');
                        if (times.Length != 2)
                            continue;

                        DateTime existingStart = DateTime.Parse(times[0].Trim());
                        DateTime existingEnd = DateTime.Parse(times[1].Trim());


                        if (date.Text == slot.Date &&
                            timeFrom < existingEnd &&
                            existingStart < timeTo)
                        {
                            if (check_all_time != 3)
                            {
                                MessageBox.Show("Time conflict detected with another exam.");
                                return null;
                            }
                        }
                    }

                    return timeFrom.ToString("hh:mm tt") + " - " + timeTo.ToString("hh:mm tt");
                }
                else
                {
                    MessageBox.Show("Start time must be earlier than end time.");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Invalid time format. Please use format like 07:00 AM.");
                return null;
            }
        }

        /// <summary>
        /// ///////////////////////////////
        /// </summary>

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
            if (check_all_combo == 2)
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
            if (check_all_combo == 2)
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
                ///

                RoomCountroller roomCountroller = new RoomCountroller();
                List<Rooms_mo> rooms_ = roomCountroller.GetRooms();
                roomname_combobox.DataSource = rooms_;
                roomname_combobox.DisplayMember = "RoomName";
                roomname_combobox.ValueMember = "ID";
                roomname_combobox.SelectedIndex = -1;

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
            string Time = CheckTime();
            if (Time != null)
            {
                TimeTables_mo timeTables = new TimeTables_mo
                {
                    SubjectName = subject_combobox.Text,
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
            if(Role.role != "Admin")
            {
                add_btn.Visible = false;
                update_btn.Visible = false;
                delete_btn.Visible = false;
            }
        }

        private void course_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_all_combo = 2;
            Add_Subject_combo();
        }

        private void timetable_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void time_from_TextChanged(object sender, EventArgs e)
        {
            check_all_time = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            check_all_time = 1;
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
            check_all_combo = 2;
            Add_Roomname_combo();
        }

        private void roomname_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_SelectionChanged(object sender, EventArgs e)
        {
            if (timetable_view.SelectedRows.Count > 0)
            {
                var timeTables = timetable_view.SelectedRows[0].DataBoundItem as TimeTables_mo;
                if (timeTables != null)
                {
                    string[] times = timeTables.TimeSlot.Split('-');
                    selectedstudentid = timeTables.ID;
                    roomname_combobox.Text = timeTables.RoomName;
                    subject_combobox.Text = timeTables.SubjectName;
                    time_from.Text = times[0];
                    time_to.Text = times[1];
                    date.Text = timeTables.Date;

                }
            }
        }
        private TimeTables_mo selectedTimeTable;

        private void update_btn_Click(object sender, EventArgs e)
        {
            string Time_up = CheckTime();
            if (selectedstudentid > 0)
            {
                TimeTables_mo timeTables = new TimeTables_mo
                {
                    SubjectName = subject_combobox.Text,
                    SubjectsID = Convert.ToInt32(subject_combobox.SelectedValue),
                    Date = date.Text,
                    TimeSlot = Time_up,
                    RoomName = roomname_combobox.Text,
                    RoomID = Convert.ToInt32(roomname_combobox.SelectedValue)
                };
                TimeTableController timeTableController = new TimeTableController();
                timeTableController.UpdateTimeTable(timeTables);
                addtoveiw();
            }
            else
            {
                MessageBox.Show("Select the Row Fist");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedstudentid > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TimeTableController timeTableController = new TimeTableController();
                    timeTableController.DeleteTimeTableByTimeSlot(selectedstudentid);
                    addtoveiw();
                }
            }
            else
            {
                MessageBox.Show("Select the Row Fist");
            }
        }
    }
}
