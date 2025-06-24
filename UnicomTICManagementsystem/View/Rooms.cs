using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem.View
{
    public partial class Rooms : Form
    {
        RoomCountroller rooms;
        int add = 0;
        public Rooms()
        {
            InitializeComponent();
            rooms = new RoomCountroller();
            addview();
            addcombobox();
            Hide_02(false);
        }
        public void Hide_01(bool view_01)
        {
            label1.Visible = view_01;
            label3.Visible = view_01;
            roomtype_combobox.Visible = view_01;
            room_name.Visible = view_01;


        }
        public void Hide_02(bool view_02)
        {
            label2.Visible = view_02;
            roomtype.Visible = view_02;

        }
        public void addview()
        {
            List<Rooms_mo> rooms_s = rooms.GetRooms();
            room_veiw.DataSource = rooms_s;
            room_veiw.Columns["ID"].Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (add > 0)
            {
                rooms.Delete_roomtype(roomtype.Text);
                addview();
                addcombobox();
                Hide_01(true);
                Hide_02(false);
                add = 0;

            }
            else
            {
                rooms.Delete_roomname(room_name.Text);
                room_name.Clear();
                addview();
            }
        }
        public void addcombobox()
        {
            List<string> list = rooms.GetRoomType();
            roomtype_combobox.DataSource = list;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (add > 0)
            {
                Hide_01(true);
                Hide_02(false);
                add = 0;
            }
            else
            {
                Student_Details student_Details = new Student_Details();
                student_Details.Show();
                this.Hide();
            }

        }

        private void roomtype_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (add > 0)
            {
                rooms.AddRoomtype(roomtype.Text);

                addview();
                addcombobox();
                Hide_01(true);
                Hide_02(false);
                add = 0;
            }
            else
            {
                if (room_name.Text.Trim() != "")
                {
                    Rooms_mo rooms_ = new Rooms_mo();
                    rooms_.RoomName = room_name.Text.Trim();
                    rooms_.RoomType = roomtype.Text;
                    rooms.AddRooms(rooms_);
                    addview();
                    room_name.Clear();


                }
                else
                {
                    MessageBox.Show("Invalid Room Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void room_type_Click(object sender, EventArgs e)
        {
            Hide_01(false);
            Hide_02(true);
            add = 2;


        }

        private void room_veiw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            if (Role.role != "Admin")
            {
               Add_btn.Visible = false;
               delete_btn.Visible = false;   
            }
        }
    }
}
