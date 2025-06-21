using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Forms;

namespace UnicomTICManagementsystem.View
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void course_btn_Click(object sender, EventArgs e)
        {
            Add_and_veiwcourses add_And_Veiwcourses = new Add_and_veiwcourses();
            add_And_Veiwcourses.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void student_detail_btn_Click(object sender, EventArgs e)
        {
            Add_and_veiwstudents student = new Add_and_veiwstudents();
            student.Show();
            this.Hide();
        }

        private void subjects_btn_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();
            this.Hide();
        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }

        private void exams_btn_Click(object sender, EventArgs e)
        {
            Exams exams = new Exams();
            exams.Show();   
            this.Hide();
        }
    }
}
