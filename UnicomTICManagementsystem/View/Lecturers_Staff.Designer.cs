namespace UnicomTICManagementsystem.View
{
    partial class Lecturers
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
            sub_panel = new Panel();
            salaries_btn = new Button();
            staff_btn = new Button();
            lecturers_btn = new Button();
            main_panel = new Panel();
            button1 = new Button();
            sub_panel.SuspendLayout();
            SuspendLayout();
            // 
            // sub_panel
            // 
            sub_panel.BackColor = SystemColors.ActiveCaption;
            sub_panel.Controls.Add(button1);
            sub_panel.Controls.Add(salaries_btn);
            sub_panel.Controls.Add(staff_btn);
            sub_panel.Controls.Add(lecturers_btn);
            sub_panel.Dock = DockStyle.Left;
            sub_panel.Location = new Point(0, 0);
            sub_panel.Name = "sub_panel";
            sub_panel.Size = new Size(165, 450);
            sub_panel.TabIndex = 0;
            sub_panel.Paint += sub_panel_Paint;
            // 
            // salaries_btn
            // 
            salaries_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salaries_btn.Location = new Point(34, 231);
            salaries_btn.Name = "salaries_btn";
            salaries_btn.Size = new Size(94, 34);
            salaries_btn.TabIndex = 2;
            salaries_btn.Text = "Salaries";
            salaries_btn.UseVisualStyleBackColor = true;
            // 
            // staff_btn
            // 
            staff_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staff_btn.Location = new Point(34, 152);
            staff_btn.Name = "staff_btn";
            staff_btn.Size = new Size(94, 30);
            staff_btn.TabIndex = 1;
            staff_btn.Text = "Staff";
            staff_btn.UseVisualStyleBackColor = true;
            // 
            // lecturers_btn
            // 
            lecturers_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lecturers_btn.Location = new Point(34, 84);
            lecturers_btn.Name = "lecturers_btn";
            lecturers_btn.Size = new Size(94, 30);
            lecturers_btn.TabIndex = 0;
            lecturers_btn.Text = "Lecturers";
            lecturers_btn.UseVisualStyleBackColor = true;
            lecturers_btn.Click += button1_Click;
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(165, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(639, 450);
            main_panel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 3;
            button1.Text = "⬅️";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Lecturers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(main_panel);
            Controls.Add(sub_panel);
            Name = "Lecturers";
            Text = "Lecturers";
            sub_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sub_panel;
        private Panel main_panel;
        private Button salaries_btn;
        private Button staff_btn;
        private Button lecturers_btn;
        private Button button1;
    }
}