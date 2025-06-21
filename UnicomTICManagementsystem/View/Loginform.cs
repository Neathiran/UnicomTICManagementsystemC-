using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Forms;
using UnicomTICManagementsystem.Models;

namespace UnicomTICManagementsystem
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }
        public void LoadForm(object formObj)
        {
            Form form = formObj as Form;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Id_Password id_Password = new Id_Password();
            id_Password.Id = userid.Text;
            id_Password.Password = password.Text;
            if (id_Password.Id == "Admin" && id_Password.Password == "12345")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();

            }
            else
            {
                LoginController lc = new LoginController();
                string role = lc.Check(id_Password);
                if (role != null)
                {
                    if (role == "Student")
                    {
                        MessageBox.Show("Student Login");
                    }

                }
                MessageBox.Show("INCORRCET USERID OR PASSWORD  ");
                userid.Clear();
                password.Clear();

            }
          
           

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
