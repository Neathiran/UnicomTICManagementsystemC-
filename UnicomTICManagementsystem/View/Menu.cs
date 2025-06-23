using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Models;
using UnicomTICManagementsystem.View;

namespace UnicomTICManagementsystem.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            Student_Details students_Details = new Student_Details();
            students_Details.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void staff_btn_Click(object sender, EventArgs e)
        {

        }

        private void Lecturer_btn_Click(object sender, EventArgs e)
        {
            Lecturers lecturers_Details = new Lecturers();
            lecturers_Details.Show();
            this.Hide();
        }
    }
}
