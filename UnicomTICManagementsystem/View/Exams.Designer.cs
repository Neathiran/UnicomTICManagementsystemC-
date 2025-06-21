namespace UnicomTICManagementsystem.View
{
    partial class Exams
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
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            back_btn = new Button();
            exams_view = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            subject_combobox = new ComboBox();
            date = new DateTimePicker();
            exam_name = new TextBox();
            label5 = new Label();
            time_from = new TextBox();
            time_to = new TextBox();
            ((System.ComponentModel.ISupportInitialize)exams_view).BeginInit();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(69, 362);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 33);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += button1_Click;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(189, 362);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(78, 33);
            update_btn.TabIndex = 1;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(310, 362);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(74, 33);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(12, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(50, 29);
            back_btn.TabIndex = 3;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // exams_view
            // 
            exams_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exams_view.Location = new Point(419, 12);
            exams_view.Name = "exams_view";
            exams_view.Size = new Size(369, 272);
            exams_view.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 76);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 5;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 126);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 6;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 189);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 254);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 8;
            label4.Text = "Exam Name";
            // 
            // subject_combobox
            // 
            subject_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            subject_combobox.FormattingEnabled = true;
            subject_combobox.Location = new Point(166, 187);
            subject_combobox.Name = "subject_combobox";
            subject_combobox.Size = new Size(135, 23);
            subject_combobox.TabIndex = 10;
            // 
            // date
            // 
            date.Location = new Point(164, 75);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 12;
            // 
            // exam_name
            // 
            exam_name.Location = new Point(189, 252);
            exam_name.Name = "exam_name";
            exam_name.Size = new Size(134, 23);
            exam_name.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 131);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 16;
            label5.Text = "to";
            // 
            // time_from
            // 
            time_from.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_from.ForeColor = SystemColors.WindowFrame;
            time_from.Location = new Point(158, 126);
            time_from.Name = "time_from";
            time_from.Size = new Size(79, 25);
            time_from.TabIndex = 19;
            time_from.Text = "10:00";
            // 
            // time_to
            // 
            time_to.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_to.ForeColor = SystemColors.WindowFrame;
            time_to.Location = new Point(301, 126);
            time_to.Name = "time_to";
            time_to.Size = new Size(94, 25);
            time_to.TabIndex = 20;
            time_to.Text = "12:00";
            // 
            // Exams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(time_to);
            Controls.Add(time_from);
            Controls.Add(label5);
            Controls.Add(exam_name);
            Controls.Add(date);
            Controls.Add(subject_combobox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exams_view);
            Controls.Add(back_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Name = "Exams";
            Text = "Exams";
            ((System.ComponentModel.ISupportInitialize)exams_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button back_btn;
        private DataGridView exams_view;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox subject_combobox;
        private DateTimePicker date;
        private TextBox exam_name;
        private Label label5;
        private TextBox time_from;
        private TextBox time_to;
    }
}