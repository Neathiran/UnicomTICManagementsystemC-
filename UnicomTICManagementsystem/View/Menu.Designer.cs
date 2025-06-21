namespace UnicomTICManagementsystem.Forms
{
    partial class Menu
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
            students_btn = new Button();
            Lecturer_btn = new Button();
            staff_btn = new Button();
            admin_btn = new Button();
            SuspendLayout();
            // 
            // students_btn
            // 
            students_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            students_btn.Location = new Point(289, 88);
            students_btn.Name = "students_btn";
            students_btn.Size = new Size(162, 31);
            students_btn.TabIndex = 1;
            students_btn.Text = "Students";
            students_btn.UseVisualStyleBackColor = true;
            students_btn.Click += students_btn_Click;
            // 
            // Lecturer_btn
            // 
            Lecturer_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecturer_btn.Location = new Point(289, 164);
            Lecturer_btn.Name = "Lecturer_btn";
            Lecturer_btn.Size = new Size(162, 29);
            Lecturer_btn.TabIndex = 2;
            Lecturer_btn.Text = "Lecturers";
            Lecturer_btn.UseVisualStyleBackColor = true;
            // 
            // staff_btn
            // 
            staff_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staff_btn.Location = new Point(289, 247);
            staff_btn.Name = "staff_btn";
            staff_btn.Size = new Size(162, 28);
            staff_btn.TabIndex = 3;
            staff_btn.Text = "Staffs";
            staff_btn.UseVisualStyleBackColor = true;
            staff_btn.Click += staff_btn_Click;
            // 
            // admin_btn
            // 
            admin_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_btn.Location = new Point(289, 311);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(162, 28);
            admin_btn.TabIndex = 4;
            admin_btn.Text = "Admin";
            admin_btn.UseVisualStyleBackColor = true;
            admin_btn.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(admin_btn);
            Controls.Add(staff_btn);
            Controls.Add(Lecturer_btn);
            Controls.Add(students_btn);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button students_btn;
        private Button Lecturer_btn;
        private Button staff_btn;
        private Button admin_btn;
    }
}