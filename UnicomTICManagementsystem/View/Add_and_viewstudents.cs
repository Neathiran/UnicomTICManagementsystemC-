using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementsystem.View
{
    public partial class Add_and_viewstudents : Form
    {
        int check = 0;
        private StudentController studentController;
        int selectedstudentid = -1;
        public Add_and_viewstudents()
        {
            InitializeComponent();
            studentController = new StudentController();
            addtocombobox();
            addtoveiw();
            ut.Visible = false;
            gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_combobox.Items.AddRange(new string[] { "Male", "Female" });
            gender_combobox.SelectedIndex = -1;



        }

        public void clear()
        {
            name.Clear();
            address.Clear();
            NIC_number.Clear();
            age.Clear();
            addtoveiw();
        }

        private void searchveiw()
        {

            List<Students_mo> students = studentController.GetStudents();
            string ut_number_ = ut_number.Text;
            foreach (var students_ in students)
            {
                if (students_.UserId == ut_number_)
                {
                    List<Students_mo> search = new List<Students_mo>();
                    search.Add(students_);
                    student_veiw.DataSource = search;

                }




            }
        }



        public void addtocombobox()
        {
            CourseController courseController = new CourseController();
            List<Courses_mo> courses = courseController.GetCourse();
            course.DataSource = courses;
            course.DisplayMember = "Name";
            course.ValueMember = "Id";
            course.SelectedIndex = -1;


        }

        public void addtoveiw()
        {
            List<Students_mo> students = studentController.GetStudents();
            student_veiw.DataSource = students;
            student_veiw.Columns["password"].Visible = false;
            student_veiw.Columns["CoursesID"].Visible = false;
            student_veiw.Columns["Id"].Visible = false;

        }

        private void Check_inputs()
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(address.Text) && !string.IsNullOrWhiteSpace(age.Text) &&
                !string.IsNullOrWhiteSpace(NIC_number.Text) && !string.IsNullOrWhiteSpace(course.Text) && !string.IsNullOrWhiteSpace(gender_combobox.Text))
            {
                check = 2;
            }

            else
            {
               
                MessageBox.Show("Enter All INPUTS");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_student_btn_Click(object sender, EventArgs e)
        {
            Check_inputs();
            if (check == 2)
            {
                string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
                UserController userController = new UserController();
                string Id = userController.CreateUserID(age.Text, NIC_number.Text, "Student");
                Students_mo students_Mo = new Students_mo
                {
                    Name = name.Text.Trim(),
                    Address = address.Text.Trim(),
                    Age = int.Parse(age.Text.Trim()),
                    NIC_Number = NIC_number.Text.Trim(),
                    Gender = gender_combobox.Text.Trim(),
                    coursesName = course.Text.Trim(),
                    CoursesID = Convert.ToInt32(course.SelectedValue),
                    UserId = Id,
                    Date = formattedDate
                };

                int num = studentController.AddStudents(students_Mo);
                if (num > 0)
                {
                    userController.AddUsers(students_Mo.UserId,"Student");
                    MessageBox.Show("UserId :" + students_Mo.UserId);
                    MessageBox.Show("PassWord 4321");
                    check = 0;
                    clear();
                }
                else
                {
                    clear();
                }
            }
           



        }
       

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_student_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_student_btn_Click(object sender, EventArgs e)
        {
            UserController userControl = new UserController();
            userControl.Deleteusers(ut_number.Text);
            studentController.Deletestudents(ut_number.Text);
            clear();
            ut_number.Clear();

        }

        private void gender_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Student_Details student_Details = new Student_Details();
            student_Details.Show();
            this.Hide();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void ut_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            searchveiw();
        }

        private void student_veiw_selectionchanged(object sender, EventArgs e)
        {

        }
        private void student_veiw_SelectionChanged(object sender, EventArgs e)
        {
            if (student_veiw.SelectedRows.Count > 0)
            {
                var student = student_veiw.SelectedRows[0].DataBoundItem as Students_mo;
                if (student != null)
                {
                    selectedstudentid = student.Id;
                    ut.Text = student.UserId;
                    name.Text = student.Name;
                    address.Text = student.Address;
                    age.Text = student.Age.ToString();
                    NIC_number.Text = student.NIC_Number;
                    gender_combobox.Text = student.Gender;
                    course.Text = student.coursesName;
                    ut_number.Text = student.UserId;
                }
            }

        }

        private void update_student_btn_Click_1(object sender, EventArgs e)
        {
            if (selectedstudentid >= 0)
            {
                Students_mo students_mo_ = new Students_mo
                {
                    Id = selectedstudentid,
                    UserId = ut.Text.Trim(),
                    Name = name.Text.Trim(),
                    Address = address.Text.Trim(),
                    Age = int.Parse(age.Text.Trim()),
                    NIC_Number = NIC_number.Text.Trim(),
                    Gender = gender_combobox.Text.Trim(),
                    coursesName = course.Text.Trim(),
                    CoursesID = Convert.ToInt32(course.SelectedValue)
                };
                Check_inputs();
                if (check == 2)
                {

                    studentController.UpdateStudent(students_mo_);
                    MessageBox.Show("Update Successfull ");
                    addtoveiw();
                    check = 0;
                }
                else
                {
                    MessageBox.Show("INVALID INPUTS");
                }

            }
        }

        private void Add_and_veiwstudents_Load(object sender, EventArgs e)
        {
            if(Role.role != "Admin")
            {
                add_student_btn.Visible = false;
                update_student_btn.Visible=false;
                delete_student_btn.Visible=false;
            }
        }

        private void ut_number_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
