using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem.View
{
    public partial class Add_and_veiwcourses : Form
    //Delete ellatha ondu kuduha error varanum
    {
        private CourseController coursecontroller;
        int selectedcourseId = -1;
        int Change = 0;
        public Add_and_veiwcourses()
        {
            InitializeComponent();
            coursecontroller = new CourseController();
            update_coursename.Visible = false;
            addveiw();


        }

        public void addveiw()
        {

            List<Courses_mo> courses = coursecontroller.GetCourse();
            int j = 0;
            foreach (var course in courses)
            {
                j++;
            }
            if (j > 0)
            {
                veiw_courses.DataSource = courses;
                veiw_courses.Columns["Id"].Visible = false;
            }
            else
            {
                course_name.Clear();

            }

        }
        private void LoadStudents()
        {
            /////
            List<Courses_mo> courses_Mos = coursecontroller.GetCourse();
            veiw_courses.DataSource = courses_Mos;
            veiw_courses.ClearSelection();
            ClearInputs();
            selectedcourseId = -1;
        }
        private void ClearInputs()
        {
            /////
            course_name.Text = "";

        }

        public void searchveiw()
        {

            List<Courses_mo> courses = coursecontroller.GetCourse();
            string Name = course_name.Text;
            foreach (var course in courses)
            {
                if (course.Name == Name)
                {
                    List<Courses_mo> search = new List<Courses_mo>();
                    search.Add(course);
                    veiw_courses.DataSource = search;

                }




            }
        }

        private void delete_course_btn_Click(object sender, EventArgs e)
        {
            string Name = course_name.Text.Trim();
            if (Name != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    coursecontroller.Deletecourse(Name);
                    SubjectsCountroller subjectsCountroller = new SubjectsCountroller();
                    subjectsCountroller.Delete_Course_subjects(Name);
                    MessageBox.Show("Delete Successfull ");
                    course_name.Clear();
                    addveiw();
                }
                else
                {
                    course_name.Clear();
                }


                //coursecontroller.Deletecourse(courses);
                //MessageBox.Show("Delete Successfull ");
                //course_name.Clear();
                //addveiw();

            }
            else
            {
                MessageBox.Show("ENTER THE COURSENAME");
            }

        }

        private void update_courses_btn_Click(object sender, EventArgs e)
        {
            if (selectedcourseId >= 0)
            {
                update_coursename.Visible = true;
                Courses_mo courses = new Courses_mo { Name = update_coursename.Text.Trim(), Id = selectedcourseId };
                if (courses.Name != "")
                {

                    coursecontroller.UpdateCourses(courses);
                    StudentController studentController = new StudentController();
                    studentController.UpdateCourse(courses);
                    addveiw();
                    update_coursename.Visible = false;
                    update_coursename.Clear();
                    MessageBox.Show("Update Successfull ");
                }
                else
                {
                    MessageBox.Show("Enter The Update Name");
                }

            }

            else
            {
                MessageBox.Show("Select the Raw");
            }


        }

        private void add_course_name_Click(object sender, EventArgs e)
        {
            Courses_mo courses_Mo = new Courses_mo { Name = course_name.Text.Trim() };
            if (courses_Mo.Name != "")
            {

                coursecontroller.Addcourse(courses_Mo);
                MessageBox.Show("Add Successfull ");
                course_name.Clear();
                addveiw();
            }
            else
            {
                MessageBox.Show("ENTER THE COURSENAME");
            }


        }

        private void course_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void veiw_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_course_btn_Click(object sender, EventArgs e)
        {
            searchveiw();
            course_name.Clear();
        }

        private void update_coursename_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void veiw_courses_SelectionChanged(object sender, EventArgs e)
        {
            ////////
            if (veiw_courses.SelectedRows.Count > 0)
            {
                var row = veiw_courses.SelectedRows[0];
                Courses_mo courses_ = row.DataBoundItem as Courses_mo;
                if (courses_ != null)
                {
                    selectedcourseId = courses_.Id;
                    course_name.Text = courses_.Name;

                }
            }
            else
            {
                ClearInputs();
                selectedcourseId = -1;
            }
        }

        private void course_name_MouseClick(object sender, MouseEventArgs e)
        {
            addveiw();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Student_Details student_Details = new Student_Details();
            student_Details.Show();
            this.Hide();
        }

        private void Add_and_veiwcourses_Load(object sender, EventArgs e)
        {

        }
    }
}
