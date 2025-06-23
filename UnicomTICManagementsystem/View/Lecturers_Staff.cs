using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    using UnicomTICManagementsystem.Forms;

namespace UnicomTICManagementsystem.View
{
    public partial class Lecturers : Form
    {
        public Lecturers()
        {
            InitializeComponent();
        }
        public void LoadForm(object formObj)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(form);
            this.main_panel.Tag = form;
            form.Show();
        }
        private void sub_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Add_and_ViewLecturers());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
