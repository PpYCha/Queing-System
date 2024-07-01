using ReaLTaiizor.Forms;

namespace AmoecQueingSystem
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

          

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(tb_Username.Text, tb_Password.Text) == true)
            {
                if (MainClass.ROLE == "Admin")
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else if (MainClass.ROLE == "Teller")
                {
                    this.Hide();
                    TellerForm tellerForm = new TellerForm();
                    tellerForm.Show();
                }
                else if (MainClass.ROLE == "Guard")
                {
                    this.Hide();
                    QueingForm queingForm = new QueingForm();
                    queingForm.Show();
                }



            }
            else
            {
                MessageBox.Show("Invalid username or password");

            }



        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_ShowQue_Click(object sender, EventArgs e)
        {
            QueueForm queueForm = new QueueForm();
            queueForm.Show();
        }
    }
}
