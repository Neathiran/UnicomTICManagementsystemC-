namespace UnicomTICManagementsystem.View
{
    partial class Subjects
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
            subject_view = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            subject = new TextBox();
            courses_combobox = new ComboBox();
            back_btn = new Button();
            add_subject_btn = new Button();
            delete_subject_btn = new Button();
            search_subject_btn = new Button();
            search_course_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)subject_view).BeginInit();
            SuspendLayout();
            // 
            // subject_view
            // 
            subject_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subject_view.Location = new Point(467, 23);
            subject_view.Name = "subject_view";
            subject_view.Size = new Size(310, 252);
            subject_view.TabIndex = 0;
            subject_view.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 137);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "Subject";
            // 
            // subject
            // 
            subject.Location = new Point(152, 137);
            subject.Name = "subject";
            subject.Size = new Size(132, 23);
            subject.TabIndex = 3;
            subject.MouseClick += subject_MouseClick;
            subject.TextChanged += subject_TextChanged;
            // 
            // courses_combobox
            // 
            courses_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            courses_combobox.FormattingEnabled = true;
            courses_combobox.Location = new Point(152, 86);
            courses_combobox.Name = "courses_combobox";
            courses_combobox.Size = new Size(132, 23);
            courses_combobox.TabIndex = 4;
            courses_combobox.SelectedIndexChanged += courses_combobox_SelectedIndexChanged;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(11, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(57, 32);
            back_btn.TabIndex = 5;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // add_subject_btn
            // 
            add_subject_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_subject_btn.Location = new Point(87, 219);
            add_subject_btn.Name = "add_subject_btn";
            add_subject_btn.Size = new Size(68, 32);
            add_subject_btn.TabIndex = 6;
            add_subject_btn.Text = "Add";
            add_subject_btn.UseVisualStyleBackColor = true;
            add_subject_btn.Click += add_subject_btn_Click;
            // 
            // delete_subject_btn
            // 
            delete_subject_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_subject_btn.Location = new Point(209, 221);
            delete_subject_btn.Name = "delete_subject_btn";
            delete_subject_btn.Size = new Size(75, 30);
            delete_subject_btn.TabIndex = 8;
            delete_subject_btn.Text = "Delete";
            delete_subject_btn.UseVisualStyleBackColor = true;
            delete_subject_btn.Click += delete_subject_btn_Click;
            // 
            // search_subject_btn
            // 
            search_subject_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_subject_btn.Location = new Point(313, 137);
            search_subject_btn.Name = "search_subject_btn";
            search_subject_btn.Size = new Size(56, 23);
            search_subject_btn.TabIndex = 9;
            search_subject_btn.Text = "Search";
            search_subject_btn.UseVisualStyleBackColor = true;
            search_subject_btn.Click += search_btn_Click;
            // 
            // search_course_btn
            // 
            search_course_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_course_btn.Location = new Point(313, 85);
            search_course_btn.Name = "search_course_btn";
            search_course_btn.Size = new Size(37, 24);
            search_course_btn.TabIndex = 10;
            search_course_btn.Text = "🔍";
            search_course_btn.UseVisualStyleBackColor = true;
            search_course_btn.Click += search_course_btn_Click;
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(search_course_btn);
            Controls.Add(search_subject_btn);
            Controls.Add(delete_subject_btn);
            Controls.Add(add_subject_btn);
            Controls.Add(back_btn);
            Controls.Add(courses_combobox);
            Controls.Add(subject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(subject_view);
            Name = "Subjects";
            Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)subject_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView subject_view;
        private Label label1;
        private Label label2;
        private TextBox subject;
        private ComboBox courses_combobox;
        private Button back_btn;
        private Button add_subject_btn;
        private Button delete_subject_btn;
        private Button search_subject_btn;
        private Button search_course_btn;
    }
}