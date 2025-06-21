namespace UnicomTICManagementsystem.View
{
    partial class Add_Update_Delete
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
            add_update_delete_panel = new Panel();
            panel1 = new Panel();
            add_update_delete_panel.SuspendLayout();
            SuspendLayout();
            // 
            // add_update_delete_panel
            // 
            add_update_delete_panel.BackColor = SystemColors.ActiveCaption;
            add_update_delete_panel.Controls.Add(panel1);
            add_update_delete_panel.Location = new Point(-8, -3);
            add_update_delete_panel.Name = "add_update_delete_panel";
            add_update_delete_panel.Size = new Size(208, 459);
            add_update_delete_panel.TabIndex = 0;
            add_update_delete_panel.Paint += add_update_delete_panel_Paint;
            // 
            // panel1
            // 
            panel1.Location = new Point(205, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 456);
            panel1.TabIndex = 1;
            // 
            // Add_Update_Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_update_delete_panel);
            Name = "Add_Update_Delete";
            Text = "Add_Update_Delete";
            Load += Add_Update_Delete_Load;
            add_update_delete_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel add_update_delete_panel;
        private Panel panel1;
    }
}