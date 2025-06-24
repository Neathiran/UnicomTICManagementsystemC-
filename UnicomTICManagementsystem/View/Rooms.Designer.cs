namespace UnicomTICManagementsystem.View
{
    partial class Rooms
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
            roomtype = new TextBox();
            room_name = new TextBox();
            roomtype_combobox = new ComboBox();
            room_type = new Button();
            Add_btn = new Button();
            delete_btn = new Button();
            room_veiw = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)room_veiw).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 99);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 149);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Room Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 198);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Room Name";
            // 
            // roomtype
            // 
            roomtype.Location = new Point(170, 147);
            roomtype.Name = "roomtype";
            roomtype.Size = new Size(121, 23);
            roomtype.TabIndex = 3;
            roomtype.TextChanged += roomtype_TextChanged;
            // 
            // room_name
            // 
            room_name.Location = new Point(170, 196);
            room_name.Name = "room_name";
            room_name.Size = new Size(121, 23);
            room_name.TabIndex = 4;
            // 
            // roomtype_combobox
            // 
            roomtype_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomtype_combobox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomtype_combobox.FormattingEnabled = true;
            roomtype_combobox.Location = new Point(170, 99);
            roomtype_combobox.Name = "roomtype_combobox";
            roomtype_combobox.Size = new Size(121, 25);
            roomtype_combobox.TabIndex = 5;
            roomtype_combobox.SelectedIndexChanged += roomtype_combobox_SelectedIndexChanged;
            // 
            // room_type
            // 
            room_type.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            room_type.Location = new Point(146, 33);
            room_type.Name = "room_type";
            room_type.Size = new Size(121, 32);
            room_type.TabIndex = 6;
            room_type.Text = "Room Type";
            room_type.UseVisualStyleBackColor = true;
            room_type.Click += room_type_Click;
            // 
            // Add_btn
            // 
            Add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_btn.Location = new Point(89, 264);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(82, 32);
            Add_btn.TabIndex = 8;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(226, 264);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(80, 32);
            delete_btn.TabIndex = 9;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += button4_Click;
            // 
            // room_veiw
            // 
            room_veiw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            room_veiw.Location = new Point(399, 72);
            room_veiw.Name = "room_veiw";
            room_veiw.Size = new Size(374, 224);
            room_veiw.TabIndex = 10;
            room_veiw.CellContentClick += room_veiw_CellContentClick;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(room_veiw);
            Controls.Add(delete_btn);
            Controls.Add(Add_btn);
            Controls.Add(room_type);
            Controls.Add(roomtype_combobox);
            Controls.Add(room_name);
            Controls.Add(roomtype);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rooms";
            Text = "Rooms";
            Load += Rooms_Load;
            ((System.ComponentModel.ISupportInitialize)room_veiw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox roomtype;
        private TextBox room_name;
        private ComboBox roomtype_combobox;
        private Button room_type;
        private Button Add_btn;
        private Button delete_btn;
        private DataGridView room_veiw;
    }
}