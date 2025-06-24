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
    public partial class Add_and_ViewLecturers_and_staff : Form
    {
        int check = 0;
        int selectedid = -1;
        public Add_and_ViewLecturers_and_staff()
        {
           
            InitializeComponent();
            gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_combobox.Items.AddRange(new string[] { "Male", "Female" });
            gender_combobox.SelectedIndex = -1;

            userid.Visible = false;
            role_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            role_combobox.Items.AddRange(new string[] { "Lecturers", "Staff" });
            Add_View();
            addtocombobox();




        }


        private void Check_inputs()
        {
            if (role_combobox.Text != "Staff")
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
            else
            {
                if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(phonenumber.Text) &&
                    !string.IsNullOrWhiteSpace(gender_combobox.Text) && !string.IsNullOrWhiteSpace(nicnumber.Text))
                {
                    check = 2;
                }

                else
                {

                    MessageBox.Show("Enter All INPUTS");
                }
            }
        }
        public void addtocombobox()
        {
            if (role_combobox.Text != "Staff")
            {
                label4.Visible = true;
                course_combobox.Visible = true;
                CourseController courseController = new CourseController();
                List<Courses_mo> courses = courseController.GetCourse();
                course_combobox.DataSource = courses;
                course_combobox.DisplayMember = "Name";
                course_combobox.ValueMember = "Id";
                course_combobox.SelectedIndex = -1;

            }
            else
            {
                label4.Visible = false;
                course_combobox.Visible = false;
               
            }




        }
        public void Clear()
        {
            name.Clear();
            phonenumber.Clear();
            nicnumber.Clear();
        }

        public void Add_View()
        {
            if (role_combobox.Text == "Lecturers")
            {
                LecturersCountroller lecturerscountroller = new LecturersCountroller();
                List<Lecturers_mo> lecturers = lecturerscountroller.GetLecturers();
                Lecturers_view.DataSource = lecturers;
            }
            else
            {
                StaffCountroller staffCountroller = new StaffCountroller();
                List<Staff_mo> staff_mo = staffCountroller.GetStaff();
                Lecturers_view.DataSource = staff_mo;
            }


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
                if (role_combobox.Text == "Lecturers")
                {
                    string Id = userController.CreateUserID(randomNumber.ToString(), nicnumber.Text, "Lecturers");
                    Lecturers_mo lecturers_mo = new Lecturers_mo
                    {
                        LecturerName = name.Text.Trim(),
                        NICNumber = nicnumber.Text.Trim(),
                        Gender = gender_combobox.Text.Trim(),
                        CourseName = course_combobox.Text.Trim(),
                        PhoneNumber = phonenumber.Text.Trim(),
                        CoursesID = Convert.ToInt32(course_combobox.SelectedValue),
                        UserID = Id,
                        Date = formattedDate
                    };
                    LecturersCountroller lecturersCountroller = new LecturersCountroller();
                    int num = lecturersCountroller.AddLecturer(lecturers_mo);
                    if (num > 0)
                    {
                        userController.AddUsers(lecturers_mo.UserID, "Lecturers");
                        MessageBox.Show("UserId :" + lecturers_mo.UserID);
                        MessageBox.Show("PassWord 4321");
                        check = 0;
                        Clear();
                        Add_View();
                    }
                    else
                    {
                        Clear();
                    }
                }
                else if (role_combobox.Text == "Staff")
                {
                    string Id = userController.CreateUserID(randomNumber.ToString(), nicnumber.Text, "Staff");
                    Staff_mo staff_mo = new Staff_mo
                    {
                        StaffName = name.Text.Trim(),
                        NICNumber = nicnumber.Text.Trim(),
                        Gender = gender_combobox.Text.Trim(),
                        PhoneNumber = phonenumber.Text.Trim(),
                        UserID = Id,
                        Date = formattedDate
                    };
                    StaffCountroller staffCountroller = new StaffCountroller();
                    int num = staffCountroller.AddStaff(staff_mo);
                    if (num > 0)
                    {
                        userController.AddUsers(staff_mo.UserID, "Lecturers");
                        MessageBox.Show("UserId :" + staff_mo.UserID);
                        MessageBox.Show("PassWord 4321");
                        check = 0;
                        Clear();
                        Add_View();
                    }
                    else
                    {
                        Clear();
                    }
                }
            }
        }

        private void role_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_View();
            addtocombobox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Check_inputs();
            if (check == 2)
            {
                if (role_combobox.Text == "Lecturers")
                {

                    Lecturers_mo lecturers_mo = new Lecturers_mo
                    {
                        LecturerName = name.Text.Trim(),
                        NICNumber = nicnumber.Text.Trim(),
                        Gender = gender_combobox.Text.Trim(),
                        CourseName = course_combobox.Text.Trim(),
                        PhoneNumber = phonenumber.Text.Trim(),
                        CoursesID = Convert.ToInt32(course_combobox.SelectedValue),
                    };
                    LecturersCountroller lecturersCountroller = new LecturersCountroller();
                    lecturersCountroller.UpdateLecturer(lecturers_mo);
                    Clear();
                }
                else if (role_combobox.Text == "Staff")
                {


                    Staff_mo staff_mo = new Staff_mo
                    {
                        StaffName = name.Text.Trim(),
                        NICNumber = nicnumber.Text.Trim(),
                        Gender = gender_combobox.Text.Trim(),
                        PhoneNumber = phonenumber.Text.Trim(),

                    };
                    StaffCountroller staffCountroller = new StaffCountroller();
                    staffCountroller.UpdateStaff(staff_mo);
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (role_combobox.Text == "Lecturers")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LecturersCountroller lecturersCountroller = new LecturersCountroller();
                    lecturersCountroller.DeleteLecturer(userid.Text);
                    UserController userController = new UserController();
                    userController.Deleteusers(userid.Text);
                    MessageBox.Show("Delete successful.");
                    Clear();
                    userid.Clear();
                    Add_View();
                }
                else
                {
                    Clear();
                }
            }
            else if (role_combobox.Text == "Staff")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    StaffCountroller staffCountroller = new StaffCountroller();
                    staffCountroller.DeleteStaff(userid.Text);
                    UserController userController = new UserController();
                    userController.Deleteusers(userid.Text);
                    MessageBox.Show("Delete successful.");
                    Clear();
                    userid.Clear();
                    Add_View();
                }
                else
                {
                    Clear();
                }
            }




        }

        private void chamge(object sender, EventArgs e)
        {
            if (Lecturers_view.SelectedRows.Count > 0)
            {
                if (role_combobox.Text == "Lecturers")
                {


                    var lecturers = Lecturers_view.SelectedRows[0].DataBoundItem as Lecturers_mo;
                    if (lecturers != null)
                    {
                        selectedid = lecturers.ID;
                        name.Text = lecturers.LecturerName;
                        nicnumber.Text = lecturers.NICNumber;
                        gender_combobox.Text = lecturers.Gender;
                        course_combobox.Text = lecturers.CourseName;
                        phonenumber.Text = lecturers.PhoneNumber;
                        userid.Text = lecturers.UserID;
                    }
                }
                else if (role_combobox.Text == "Staff")
                {
                    var staff_mo = Lecturers_view.SelectedRows[0].DataBoundItem as Staff_mo;
                    if (staff_mo != null)
                    {
                        selectedid = staff_mo.ID;
                        name.Text = staff_mo.StaffName;
                        nicnumber.Text = staff_mo.NICNumber;
                        gender_combobox.Text = staff_mo.Gender;
                        phonenumber.Text = staff_mo.PhoneNumber;
                        userid.Text= staff_mo.UserID;
                    }
                }
            }

        }
    }
}
