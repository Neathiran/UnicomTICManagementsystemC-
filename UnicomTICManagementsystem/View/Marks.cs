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
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
            Add_ExamName_combo();
            Add_Userid_combo();
            Add_View();
        }
        public void Add_ExamName_combo()
        {
           
                ExamController examController = new ExamController();
                List<Exams_mo> exams_mo = examController.GetExams();

                if (exams_mo != null && exams_mo.Count > 0)
                {
                    exam_name_com.DisplayMember = "ExamName";
                    exam_name_com.ValueMember = "ExamID";
                    exam_name_com.DataSource = exams_mo;
                    exam_name_com.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("No exams available.");
                }
       
        }

        public void Add_Userid_combo()
        {
            UserController userController = new UserController();
            List<Users_mo> users_mo = userController.GetUsersByRole("Student");

            useid_combo.DisplayMember = "UserID";
            useid_combo.ValueMember = "No";
            useid_combo.DataSource = users_mo;
            useid_combo.SelectedIndex = -1;
        }

        public void Add_View()
        {
            MarksController marksController = new MarksController();
            List<Marks_mo> marks = marksController.GetMarks();
            mark_view.DataSource = marks;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(mark.Text,out int marks);
            if (marks >= 0 || marks >= 100)
            {

                Marks_mo marks_ = new Marks_mo
                {
                    ExamName = exam_name_com.Text,
                    ExamsID = Convert.ToInt32(exam_name_com.SelectedValue),
                    Mark = marks,
                    UserID = useid_combo.Text,

                };
                MarksController marksController = new MarksController();
                marksController.AddMarks(marks_);
                Add_View();
                mark.Clear();
            }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void useid_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mark_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
