using Microsoft.VisualBasic.Devices;
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
    // tuch
    public partial class Subjects : Form
    {
        SubjectsCountroller subjectsCountroller_;
        public Subjects()
        {
            InitializeComponent();
            subjectsCountroller_ = new SubjectsCountroller();
            addtocombobox();
            Addtoview();
        }
        private int search_by_Subject()
        {

            List<Subjects_mo> subjects_mo = subjectsCountroller_.GetSubjects();
            List<Subjects_mo> search_subject = new List<Subjects_mo>();
            int i = 0;
            foreach (var subject_ in subjects_mo)
            {
                if (subject_.SubjectName.ToLower() == subject.Text.ToLower().Trim())
                {
                    search_subject.Add(subject_);
                    i++;

                }
            }

            if (i > 0)
            {
                subject_view.DataSource = search_subject;
                return 1;
            }
            else
            {
                MessageBox.Show("Data Not Found ");
                return -1;
            }


        }
        private void search_by_course()
        {

            List<Subjects_mo> subjects_mo = subjectsCountroller_.GetSubjects();
            List<Subjects_mo> search_course = new List<Subjects_mo>();
            int j = 0;
            foreach (var subject_ in subjects_mo)
            {
                if (subject_.CourseName == courses_combobox.Text)
                {
                    search_course.Add(subject_);
                    j++;

                }
            }
            if (j > 0)
            {
                subject_view.DataSource = search_course;

            }
            else
            {
                MessageBox.Show("Data Not Found ");

            }
        }


        public void addtocombobox()
        {
            CourseController courseController = new CourseController();
            List<Courses_mo> courses = courseController.GetCourse();
            courses_combobox.DataSource = courses;
            courses_combobox.DisplayMember = "Name";
            courses_combobox.ValueMember = "Id";
        }

        public void Addtoview()
        {
            List<Subjects_mo> subjects_Mos = subjectsCountroller_.GetSubjects();
            subject_view.DataSource = subjects_Mos;
            subject_view.Columns["CourseId"].Visible = false;
            subject_view.Columns["ID"].Visible = false;
            subject.Clear();




        }

        private void courses_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            if (subject.Text.Trim() != "")
            {
                Subjects_mo subjects_ = new Subjects_mo
                {
                    CourseName = courses_combobox.Text.Trim(),
                    CourseId = Convert.ToInt32(courses_combobox.SelectedValue),
                    SubjectName = subject.Text.Trim()
                };
                subjectsCountroller_.AddSubject(subjects_);
                Addtoview();
            }


        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Student_Details student_Details = new Student_Details();
            student_Details.Show();
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_by_Subject();
        }

        private void search_course_btn_Click(object sender, EventArgs e)
        {
            search_by_course();
        }

        private void subject_TextChanged(object sender, EventArgs e)
        {

        }

        private void subject_MouseClick(object sender, MouseEventArgs e)
        {
            Addtoview();
        }

        private void delete_subject_btn_Click(object sender, EventArgs e)
        {
            int num = search_by_Subject();
            if (num > 0)
            {
                if (subject.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        subjectsCountroller_.DeleteSubject(subject.Text);
                        MessageBox.Show("Delete Successfull ");
                        subject.Clear();
                        Addtoview();
                    }
                    else
                    {
                        subject.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Enter the Subject you Want to Delete");
                }
            }
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            if (Role.role != "Admin")
            {
                add_subject_btn.Visible = false;
                delete_subject_btn.Visible=false;

            }
        }
    }
}
