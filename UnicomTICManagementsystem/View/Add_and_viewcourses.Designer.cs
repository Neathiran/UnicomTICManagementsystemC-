namespace UnicomTICManagementsystem.View
{
    partial class Add_and_veiwcourses
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
            veiw_courses = new DataGridView();
            label1 = new Label();
            course_name = new TextBox();
            add_course_name = new Button();
            update_courses_btn = new Button();
            search_course_btn = new Button();
            update_coursename = new TextBox();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)veiw_courses).BeginInit();
            SuspendLayout();
            // 
            // veiw_courses
            // 
            veiw_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veiw_courses.Location = new Point(528, 28);
            veiw_courses.Name = "veiw_courses";
            veiw_courses.Size = new Size(260, 251);
            veiw_courses.TabIndex = 0;
            veiw_courses.CellContentClick += veiw_courses_CellContentClick;
            veiw_courses.SelectionChanged += veiw_courses_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 127);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            label1.Click += label1_Click;
            // 
            // course_name
            // 
            course_name.Location = new Point(185, 129);
            course_name.Name = "course_name";
            course_name.Size = new Size(130, 23);
            course_name.TabIndex = 2;
            course_name.MouseClick += course_name_MouseClick;
            course_name.TextChanged += course_name_TextChanged;
            // 
            // add_course_name
            // 
            add_course_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_course_name.Location = new Point(101, 248);
            add_course_name.Name = "add_course_name";
            add_course_name.Size = new Size(87, 31);
            add_course_name.TabIndex = 3;
            add_course_name.Text = "Add";
            add_course_name.UseVisualStyleBackColor = true;
            add_course_name.Click += add_course_name_Click;
            // 
            // update_courses_btn
            // 
            update_courses_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_courses_btn.Location = new Point(272, 248);
            update_courses_btn.Name = "update_courses_btn";
            update_courses_btn.Size = new Size(87, 31);
            update_courses_btn.TabIndex = 4;
            update_courses_btn.Text = "Update";
            update_courses_btn.UseVisualStyleBackColor = true;
            update_courses_btn.Click += update_courses_btn_Click;
            // 
            // search_course_btn
            // 
            search_course_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_course_btn.Location = new Point(359, 129);
            search_course_btn.Name = "search_course_btn";
            search_course_btn.Size = new Size(64, 24);
            search_course_btn.TabIndex = 6;
            search_course_btn.Text = "Search";
            search_course_btn.UseVisualStyleBackColor = true;
            search_course_btn.Click += search_course_btn_Click;
            // 
            // update_coursename
            // 
            update_coursename.BackColor = SystemColors.InactiveCaption;
            update_coursename.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_coursename.Location = new Point(185, 183);
            update_coursename.Name = "update_coursename";
            update_coursename.Size = new Size(142, 25);
            update_coursename.TabIndex = 8;
            update_coursename.TextChanged += update_coursename_TextChanged;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(22, 28);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(44, 30);
            back_btn.TabIndex = 9;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Add_and_veiwcourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_btn);
            Controls.Add(update_coursename);
            Controls.Add(search_course_btn);
            Controls.Add(update_courses_btn);
            Controls.Add(add_course_name);
            Controls.Add(course_name);
            Controls.Add(label1);
            Controls.Add(veiw_courses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_and_veiwcourses";
            Text = "Add_and_veiwcourses";
            Load += Add_and_veiwcourses_Load;
            ((System.ComponentModel.ISupportInitialize)veiw_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView veiw_courses;
        private Label label1;
        private TextBox course_name;
        private Button add_course_name;
        private Button update_courses_btn;
        private Button search_course_btn;
        private TextBox update_coursename;
        private Button button1;
        private Button back_btn;
    }
}