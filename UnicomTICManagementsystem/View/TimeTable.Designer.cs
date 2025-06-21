namespace UnicomTICManagementsystem.View
{
    partial class TimeTable
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
            timetable_view = new DataGridView();
            update_btn = new Button();
            delete_btn = new Button();
            back_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            course_combobox = new ComboBox();
            subject_combobox = new ComboBox();
            roomtype_combobox = new ComboBox();
            roomname_combobox = new ComboBox();
            date = new DateTimePicker();
            time_from = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)timetable_view).BeginInit();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(12, 391);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 28);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            // 
            // timetable_view
            // 
            timetable_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timetable_view.Location = new Point(300, 12);
            timetable_view.Name = "timetable_view";
            timetable_view.Size = new Size(488, 310);
            timetable_view.TabIndex = 1;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(113, 391);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(81, 28);
            update_btn.TabIndex = 2;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(219, 387);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(77, 32);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(12, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(40, 26);
            back_btn.TabIndex = 4;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 5;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 6;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 182);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 8;
            label4.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 325);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 9;
            label5.Text = "Room Name ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 275);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 10;
            label6.Text = "Room Type";
            // 
            // course_combobox
            // 
            course_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            course_combobox.FormattingEnabled = true;
            course_combobox.Location = new Point(96, 184);
            course_combobox.Name = "course_combobox";
            course_combobox.Size = new Size(121, 23);
            course_combobox.TabIndex = 11;
            // 
            // subject_combobox
            // 
            subject_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            subject_combobox.FormattingEnabled = true;
            subject_combobox.Location = new Point(96, 232);
            subject_combobox.Name = "subject_combobox";
            subject_combobox.Size = new Size(121, 23);
            subject_combobox.TabIndex = 12;
            // 
            // roomtype_combobox
            // 
            roomtype_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomtype_combobox.FormattingEnabled = true;
            roomtype_combobox.Location = new Point(113, 277);
            roomtype_combobox.Name = "roomtype_combobox";
            roomtype_combobox.Size = new Size(121, 23);
            roomtype_combobox.TabIndex = 13;
            // 
            // roomname_combobox
            // 
            roomname_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomname_combobox.FormattingEnabled = true;
            roomname_combobox.Location = new Point(123, 323);
            roomname_combobox.Name = "roomname_combobox";
            roomname_combobox.Size = new Size(121, 23);
            roomname_combobox.TabIndex = 14;
            // 
            // date
            // 
            date.Location = new Point(62, 85);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 15;
            // 
            // time_from
            // 
            time_from.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_from.ForeColor = SystemColors.WindowFrame;
            time_from.Location = new Point(64, 136);
            time_from.Name = "time_from";
            time_from.Size = new Size(89, 27);
            time_from.TabIndex = 16;
            time_from.Text = "8:00 AM";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(213, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 27);
            textBox2.TabIndex = 17;
            textBox2.Text = "10:00 AM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(173, 144);
            label7.Name = "label7";
            label7.Size = new Size(21, 17);
            label7.TabIndex = 18;
            label7.Text = "to";
            // 
            // TimeTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(time_from);
            Controls.Add(date);
            Controls.Add(roomname_combobox);
            Controls.Add(roomtype_combobox);
            Controls.Add(subject_combobox);
            Controls.Add(course_combobox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(back_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(timetable_view);
            Controls.Add(add_btn);
            Name = "TimeTable";
            Text = "TimeTable";
            ((System.ComponentModel.ISupportInitialize)timetable_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_btn;
        private DataGridView timetable_view;
        private Button update_btn;
        private Button delete_btn;
        private Button back_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox course_combobox;
        private ComboBox subject_combobox;
        private ComboBox roomtype_combobox;
        private ComboBox roomname_combobox;
        private DateTimePicker date;
        private TextBox time_from;
        private TextBox textBox2;
        private Label label7;
    }
}