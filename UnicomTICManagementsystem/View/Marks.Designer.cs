namespace UnicomTICManagementsystem.View
{
    partial class Marks
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
            exam_name_com = new ComboBox();
            useid_combo = new ComboBox();
            mark = new TextBox();
            mark_view = new DataGridView();
            add_btn = new Button();
            update_btn = new Button();
            delet_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)mark_view).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 90);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Exam Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 144);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 205);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Marks";
            // 
            // exam_name_com
            // 
            exam_name_com.DropDownStyle = ComboBoxStyle.DropDownList;
            exam_name_com.FormattingEnabled = true;
            exam_name_com.Location = new Point(157, 92);
            exam_name_com.Name = "exam_name_com";
            exam_name_com.Size = new Size(121, 23);
            exam_name_com.TabIndex = 3;
            exam_name_com.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // useid_combo
            // 
            useid_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            useid_combo.FormattingEnabled = true;
            useid_combo.Location = new Point(152, 146);
            useid_combo.Name = "useid_combo";
            useid_combo.Size = new Size(126, 23);
            useid_combo.TabIndex = 4;
            useid_combo.SelectedIndexChanged += useid_combo_SelectedIndexChanged;
            // 
            // mark
            // 
            mark.Location = new Point(141, 207);
            mark.Name = "mark";
            mark.Size = new Size(122, 23);
            mark.TabIndex = 5;
            // 
            // mark_view
            // 
            mark_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mark_view.Location = new Point(374, 12);
            mark_view.Name = "mark_view";
            mark_view.Size = new Size(414, 287);
            mark_view.TabIndex = 6;
            mark_view.CellContentClick += mark_view_CellContentClick;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(42, 297);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(74, 33);
            add_btn.TabIndex = 7;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(141, 297);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(73, 33);
            update_btn.TabIndex = 8;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // delet_btn
            // 
            delet_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delet_btn.Location = new Point(237, 297);
            delet_btn.Name = "delet_btn";
            delet_btn.Size = new Size(84, 33);
            delet_btn.TabIndex = 9;
            delet_btn.Text = "Delete";
            delet_btn.UseVisualStyleBackColor = true;
            // 
            // Marks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delet_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(mark_view);
            Controls.Add(mark);
            Controls.Add(useid_combo);
            Controls.Add(exam_name_com);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Marks";
            Text = "Marks";
            ((System.ComponentModel.ISupportInitialize)mark_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox exam_name_com;
        private ComboBox useid_combo;
        private TextBox mark;
        private DataGridView mark_view;
        private Button add_btn;
        private Button update_btn;
        private Button delet_btn;
    }
}