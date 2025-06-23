using UnicomTICManagementsystem.Controllers;
using UnicomTICManagementsystem.Forms;
using UnicomTICManagementsystem.Models;
using UnicomTICManagementsystem.View;

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
            id_Password.Id = userid.Text.Trim();
            id_Password.Password = password.Text.Trim();

            
            if (string.IsNullOrEmpty(id_Password.Id) || string.IsNullOrEmpty(id_Password.Password))
            {
                MessageBox.Show("Please enter both UserID and Password.");
                return;
            }

           
            LoginController lc = new LoginController();
            string role = lc.Check(id_Password);

            
            if (role != null)
            {
                if (role == "Student")
                {
                    MessageBox.Show("Student Login");
                }
                else if (role == "Lecturer")  
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else if (role == "Staff")
                {
                  
                    MessageBox.Show("Staff Login");
                }
            }
            else
            {
                
                MessageBox.Show("Incorrect UserID or Password");
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
