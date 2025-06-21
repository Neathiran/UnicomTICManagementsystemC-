namespace UnicomTICManagementsystem.View
{
    partial class Add_and_veiwstudents
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
            add_student_btn = new Button();
            delete_student_btn = new Button();
            update_student_btn = new Button();
            student_veiw = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            back_btn = new Button();
            label5 = new Label();
            name = new TextBox();
            course = new ComboBox();
            age = new TextBox();
            address = new TextBox();
            gender_combobox = new ComboBox();
            label6 = new Label();
            NIC_number = new TextBox();
            ut_number = new TextBox();
            search_btn = new Button();
            ut = new TextBox();
            ((System.ComponentModel.ISupportInitialize)student_veiw).BeginInit();
            SuspendLayout();
            // 
            // add_student_btn
            // 
            add_student_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_student_btn.Location = new Point(12, 406);
            add_student_btn.Name = "add_student_btn";
            add_student_btn.Size = new Size(75, 32);
            add_student_btn.TabIndex = 1;
            add_student_btn.Text = "Add";
            add_student_btn.UseVisualStyleBackColor = true;
            add_student_btn.Click += add_student_btn_Click;
            // 
            // delete_student_btn
            // 
            delete_student_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_student_btn.Location = new Point(119, 406);
            delete_student_btn.Name = "delete_student_btn";
            delete_student_btn.Size = new Size(75, 32);
            delete_student_btn.TabIndex = 2;
            delete_student_btn.Text = "Delete";
            delete_student_btn.UseVisualStyleBackColor = true;
            delete_student_btn.Click += delete_student_btn_Click;
            // 
            // update_student_btn
            // 
            update_student_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_student_btn.Location = new Point(230, 406);
            update_student_btn.Name = "update_student_btn";
            update_student_btn.Size = new Size(75, 32);
            update_student_btn.TabIndex = 3;
            update_student_btn.Text = "Update";
            update_student_btn.UseVisualStyleBackColor = true;
            update_student_btn.Click += update_student_btn_Click_1;
            // 
            // student_veiw
            // 
            student_veiw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_veiw.Location = new Point(289, 29);
            student_veiw.Name = "student_veiw";
            student_veiw.Size = new Size(499, 328);
            student_veiw.TabIndex = 4;
            student_veiw.CellContentClick += dataGridView1_CellContentClick;
            student_veiw.SelectionChanged += student_veiw_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 97);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 5;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 142);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 249);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_btn.Location = new Point(4, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(51, 32);
            back_btn.TabIndex = 9;
            back_btn.Text = "⬅️";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 296);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 10;
            label5.Text = "Course";
            // 
            // name
            // 
            name.Location = new Point(113, 95);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 11;
            name.TextChanged += name_TextChanged;
            // 
            // course
            // 
            course.DropDownStyle = ComboBoxStyle.DropDownList;
            course.FormattingEnabled = true;
            course.Location = new Point(119, 294);
            course.Name = "course";
            course.Size = new Size(143, 23);
            course.TabIndex = 12;
            course.SelectedIndexChanged += course_SelectedIndexChanged;
            // 
            // age
            // 
            age.Location = new Point(113, 144);
            age.Name = "age";
            age.Size = new Size(100, 23);
            age.TabIndex = 13;
            age.TextChanged += age_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(119, 247);
            address.Name = "address";
            address.Size = new Size(143, 23);
            address.TabIndex = 15;
            address.TextChanged += address_TextChanged;
            // 
            // gender_combobox
            // 
            gender_combobox.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_combobox.FormattingEnabled = true;
            gender_combobox.Location = new Point(113, 195);
            gender_combobox.Name = "gender_combobox";
            gender_combobox.Size = new Size(107, 23);
            gender_combobox.TabIndex = 16;
            gender_combobox.SelectedIndexChanged += gender_combobox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 351);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 17;
            label6.Text = "NIC Number";
            // 
            // NIC_number
            // 
            NIC_number.Location = new Point(119, 349);
            NIC_number.Name = "NIC_number";
            NIC_number.Size = new Size(137, 23);
            NIC_number.TabIndex = 18;
            // 
            // ut_number
            // 
            ut_number.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ut_number.ForeColor = SystemColors.WindowFrame;
            ut_number.Location = new Point(61, 44);
            ut_number.Name = "ut_number";
            ut_number.Size = new Size(140, 25);
            ut_number.TabIndex = 19;
            ut_number.Text = "Enter the UT Number";
            ut_number.TextChanged += ut_number_TextChanged_1;
            // 
            // search_btn
            // 
            search_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_btn.Location = new Point(208, 45);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(63, 23);
            search_btn.TabIndex = 20;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // ut
            // 
            ut.Location = new Point(183, 12);
            ut.Name = "ut";
            ut.Size = new Size(100, 23);
            ut.TabIndex = 21;
            ut.Text = "no";
            // 
            // Add_and_veiwstudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ut);
            Controls.Add(search_btn);
            Controls.Add(ut_number);
            Controls.Add(NIC_number);
            Controls.Add(label6);
            Controls.Add(gender_combobox);
            Controls.Add(address);
            Controls.Add(age);
            Controls.Add(course);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(back_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(student_veiw);
            Controls.Add(update_student_btn);
            Controls.Add(delete_student_btn);
            Controls.Add(add_student_btn);
            Name = "Add_and_veiwstudents";
            Text = "Addstudents";
            Load += Add_and_veiwstudents_Load;
            ((System.ComponentModel.ISupportInitialize)student_veiw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add_student_btn;
        private Button delete_student_btn;
        private Button update_student_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button back_btn;
        private Label label5;
        private TextBox name;
        private ComboBox course;
        private TextBox age;
        private TextBox address;
        private ComboBox gender_combobox;
        private Label label6;
        private TextBox NIC_number;
        private TextBox ut_number;
        private Button search_btn;
        private DataGridView student_veiw;
        private TextBox ut;
    }
}