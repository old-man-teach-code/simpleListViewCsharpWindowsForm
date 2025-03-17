namespace SE08101_SecondDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "linhhn13" && password == "123")
            {
                MessageBox.Show("Correct Username and Password");
                AppData.LoginState = true;
                AppData.CurrentForm = "FormList";
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
