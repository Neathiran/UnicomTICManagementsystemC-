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
        public void LoadForm(object formObj)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }

        private void course_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Add_and_veiwcourses());

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //LoadForm(new Add_and_veiwcourses());
            //Menu menu = new Menu();
            //menu.Show();
            //this.Hide();
        }

        private void student_detail_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Add_and_viewstudents());

        }

        private void subjects_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Subjects());

        }

        private void rooms_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Rooms());

        }

        private void exams_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Exams());

        }

        private void timetable_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new TimeTable());

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mark_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Marks());
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
