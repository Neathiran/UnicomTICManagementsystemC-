namespace UnicomTICManagementsystem.View
{
    partial class Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            course_btn = new Button();
            back_btn = new Button();
            student_detail_btn = new Button();
            subjects_btn = new Button();
            rooms_btn = new Button();
            exams_btn = new Button();
            timetable_btn = new Button();
            SuspendLayout();
            // 
            // course_btn
            // 
            course_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            course_btn.Location = new Point(297, 42);
            course_btn.Name = "course_btn";
            course_btn.Size = new Size(155, 31);
            course_btn.TabIndex = 0;
            course_btn.Text = "Course";
            course_btn.UseVisualStyleBackColor = true;
            course_btn.Click += course_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(12, 21);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(47, 28);
            back_btn.TabIndex = 1;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // student_detail_btn
            // 
            student_detail_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student_detail_btn.Location = new Point(297, 114);
            student_detail_btn.Name = "student_detail_btn";
            student_detail_btn.Size = new Size(155, 29);
            student_detail_btn.TabIndex = 2;
            student_detail_btn.Text = "Student Details";
            student_detail_btn.UseVisualStyleBackColor = true;
            student_detail_btn.Click += student_detail_btn_Click;
            // 
            // subjects_btn
            // 
            subjects_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjects_btn.Location = new Point(297, 183);
            subjects_btn.Name = "subjects_btn";
            subjects_btn.Size = new Size(155, 29);
            subjects_btn.TabIndex = 3;
            subjects_btn.Text = "Subjects";
            subjects_btn.UseVisualStyleBackColor = true;
            subjects_btn.Click += subjects_btn_Click;
            // 
            // rooms_btn
            // 
            rooms_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rooms_btn.Location = new Point(297, 248);
            rooms_btn.Name = "rooms_btn";
            rooms_btn.Size = new Size(155, 31);
            rooms_btn.TabIndex = 4;
            rooms_btn.Text = "Rooms";
            rooms_btn.UseVisualStyleBackColor = true;
            rooms_btn.Click += rooms_btn_Click;
            // 
            // exams_btn
            // 
            exams_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exams_btn.Location = new Point(297, 312);
            exams_btn.Name = "exams_btn";
            exams_btn.Size = new Size(155, 26);
            exams_btn.TabIndex = 5;
            exams_btn.Text = "Exams";
            exams_btn.UseVisualStyleBackColor = true;
            exams_btn.Click += exams_btn_Click;
            // 
            // timetable_btn
            // 
            timetable_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timetable_btn.Location = new Point(297, 378);
            timetable_btn.Name = "timetable_btn";
            timetable_btn.Size = new Size(155, 28);
            timetable_btn.TabIndex = 7;
            timetable_btn.Text = "Time Table";
            timetable_btn.UseVisualStyleBackColor = true;
            timetable_btn.Click += timetable_btn_Click;
            // 
            // Student_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timetable_btn);
            Controls.Add(exams_btn);
            Controls.Add(rooms_btn);
            Controls.Add(subjects_btn);
            Controls.Add(student_detail_btn);
            Controls.Add(back_btn);
            Controls.Add(course_btn);
            Name = "Student_Details";
            Text = "Student_Details";
            ResumeLayout(false);
        }

        #endregion

        private Button course_btn;
        private Button back_btn;
        private Button student_detail_btn;
        private Button subjects_btn;
        private Button rooms_btn;
        private Button exams_btn;
        private Button timetable_btn;
    }
}