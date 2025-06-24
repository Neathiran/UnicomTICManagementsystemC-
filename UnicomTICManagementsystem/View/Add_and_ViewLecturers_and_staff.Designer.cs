namespace UnicomTICManagementsystem.View
{
    partial class Add_and_ViewLecturers_and_staff
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            phonenumber = new TextBox();
            nicnumber = new TextBox();
            course_combobox = new ComboBox();
            add_btn = new Button();
            delete_btn = new Button();
            Lecturers_view = new DataGridView();
            label5 = new Label();
            gender_combobox = new ComboBox();
            label6 = new Label();
            role_combobox = new ComboBox();
            update_btn = new Button();
            userid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Lecturers_view).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 119);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 168);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 224);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "NIC Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 333);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Course";
            label4.Click += label4_Click;
            // 
            // name
            // 
            name.Location = new Point(129, 117);
            name.Name = "name";
            name.Size = new Size(115, 23);
            name.TabIndex = 4;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(153, 168);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(113, 23);
            phonenumber.TabIndex = 5;
            // 
            // nicnumber
            // 
            nicnumber.Location = new Point(143, 222);
            nicnumber.Name = "nicnumber";
            nicnumber.Size = new Size(117, 23);
            nicnumber.TabIndex = 6;
            // 
            // course_combobox
            // 
            course_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            course_combobox.FormattingEnabled = true;
            course_combobox.Location = new Point(123, 333);
            course_combobox.Name = "course_combobox";
            course_combobox.Size = new Size(121, 23);
            course_combobox.TabIndex = 7;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(10, 375);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(78, 33);
            add_btn.TabIndex = 8;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(232, 375);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(77, 30);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // Lecturers_view
            // 
            Lecturers_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lecturers_view.Location = new Point(311, 37);
            Lecturers_view.Name = "Lecturers_view";
            Lecturers_view.Size = new Size(460, 271);
            Lecturers_view.TabIndex = 11;
            Lecturers_view.SelectionChanged += chamge;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 281);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // gender_combobox
            // 
            gender_combobox.FormattingEnabled = true;
            gender_combobox.Location = new Point(123, 283);
            gender_combobox.Name = "gender_combobox";
            gender_combobox.Size = new Size(121, 23);
            gender_combobox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 65);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 14;
            label6.Text = "Role";
            // 
            // role_combobox
            // 
            role_combobox.FormattingEnabled = true;
            role_combobox.Location = new Point(111, 63);
            role_combobox.Name = "role_combobox";
            role_combobox.Size = new Size(121, 23);
            role_combobox.TabIndex = 15;
            role_combobox.SelectedIndexChanged += role_combobox_SelectedIndexChanged;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(123, 375);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(77, 33);
            update_btn.TabIndex = 9;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // userid
            // 
            userid.Location = new Point(418, 10);
            userid.Name = "userid";
            userid.Size = new Size(100, 23);
            userid.TabIndex = 16;
            // 
            // Add_and_ViewLecturers_and_staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userid);
            Controls.Add(role_combobox);
            Controls.Add(label6);
            Controls.Add(gender_combobox);
            Controls.Add(label5);
            Controls.Add(Lecturers_view);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(course_combobox);
            Controls.Add(nicnumber);
            Controls.Add(phonenumber);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_and_ViewLecturers_and_staff";
            Text = "Add_and_ViewLecturers";
            ((System.ComponentModel.ISupportInitialize)Lecturers_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name;
        private TextBox phonenumber;
        private TextBox nicnumber;
        private ComboBox course_combobox;
        private Button add_btn;
        private Button delete_btn;
        private DataGridView Lecturers_view;
        private Label label5;
        private ComboBox gender_combobox;
        private Label label6;
        private ComboBox role_combobox;
        private Button update_btn;
        private TextBox userid;
    }
}