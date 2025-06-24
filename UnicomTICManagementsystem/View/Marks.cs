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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnicomTICManagementsystem.View
{
    public partial class Marks : Form
    {
        int selectedmarksId = -1;
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
            mark_view.Columns["ID"].Visible = false;
            mark_view.Columns["ExamsID"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(mark.Text, out int marks);
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

        private void useid_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mark_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void markview_selection_change(object sender, EventArgs e)
        {
            if (mark_view.SelectedRows.Count > 0)
            {
                var row = mark_view.SelectedRows[0];
                Marks_mo marks_mo = row.DataBoundItem as Marks_mo;
                if (marks_mo != null)
                {

                    selectedmarksId = marks_mo.ID;
                    mark.Text = marks_mo.Mark.ToString();
                    exam_name_com.Text = marks_mo.ExamName;
                    useid_combo.Text = marks_mo.UserID;






                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (selectedmarksId > 0)
            {
                int.TryParse(mark.Text, out int marks);
                if (marks >= 0 || marks >= 100)
                {

                    Marks_mo marks_ = new Marks_mo
                    {
                        ID = selectedmarksId,
                        ExamName = exam_name_com.Text,
                        ExamsID = Convert.ToInt32(exam_name_com.SelectedValue),
                        Mark = marks,
                        UserID = useid_combo.Text,

                    };
                    MarksController marksController = new MarksController();
                    marksController.UpdateMarks(marks_);
                    Add_View();
                    mark.Clear();
                    selectedmarksId = -1;
                }
            }
            else
            {
                MessageBox.Show("Select the Row Fist");
            }


        }

        private void delet_btn_Click(object sender, EventArgs e)
        {
            if (selectedmarksId > 0)
            {


                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MarksController marksController = new MarksController();
                    marksController.DeleteMarksById(selectedmarksId);
                    MessageBox.Show("Delete successful.");
                    mark.Clear();
                    Add_View();
                    selectedmarksId = -1;
                }
                else
                {
                    mark.Clear();
                }
            }
            else
            {
                MessageBox.Show("Select the Row Fist");
            }
        }

        private void Marks_Load(object sender, EventArgs e)
        {
            if (Role.role == "Student")
            {
                add_btn.Visible = false;
                update_btn.Visible = false;
                delet_btn.Visible = false;
            }
        }
    }
}
