using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementsystem.View
{
    public partial class Add_and_ViewLecturers : Form
    { int check =0;
        public Add_and_ViewLecturers()
        {
            InitializeComponent();
            gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_combobox.Items.AddRange(new string[] { "Male", "Female" });
            gender_combobox.SelectedIndex = -1;
        }
        private void Check_inputs()
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(phonenumber.Text) &&
                !string.IsNullOrWhiteSpace(course_combobox.Text) && !string.IsNullOrWhiteSpace(gender_combobox.Text) && !string.IsNullOrWhiteSpace(nicnumber.Text))
            {
                check = 2;
            }

            else
            {

                MessageBox.Show("Enter All INPUTS");
            }
        }
        public void addtocombobox()
        {
            CourseController courseController = new CourseController();
            List<Courses_mo> courses = courseController.GetCourse();
            course_combobox.DataSource = courses;
            course_combobox.DisplayMember = "Name";
            course_combobox.ValueMember = "Id";
            course_combobox.SelectedIndex = -1;


        }
        public void Clear()
        {
            name.Clear();
            phonenumber.Clear();
            nicnumber.Clear();
        }

        public void Add_View()
        {
            LecturersCountroller lecturerscountroller = new LecturersCountroller();
            List<Lecturers_mo> lecturers = lecturerscountroller.GetLecturers();
            Lecturers_view.DataSource = lecturers;


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Check_inputs();
            if (check == 2)
            {
                string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
                UserController userController = new UserController();
                Random random = new Random();
                int randomNumber = random.Next(10, 99);
                string Id = userController.CreateUserID(randomNumber.ToString(), nicnumber.Text, "Student");
                Lecturers_mo lecturers_mo = new Lecturers_mo
                {
                    LecturerName = name.Text.Trim(),
                    NICNumber = nicnumber.Text.Trim(),
                    Gender = gender_combobox.Text.Trim(),
                    CourseName = course_combobox.Text.Trim(),
                    CoursesID = Convert.ToInt32(course_combobox.SelectedValue),
                    UserID = Id,
                    Date = formattedDate
                };
                LecturersCountroller lecturersCountroller = new LecturersCountroller();
                int num = lecturersCountroller.AddLecturer(lecturers_mo);
                if (num > 0)
                {
                    userController.AddUsers(lecturers_mo.UserID, "");
                    MessageBox.Show("UserId :" + lecturers_mo.UserID);
                    MessageBox.Show("PassWord 4321");
                    check = 0;
                    Clear();
                }
                else
                {
                    Clear();
                }
            }
        }
    }
}
