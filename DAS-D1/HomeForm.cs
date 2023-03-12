namespace DAS_D1
{
    public partial class HomeForm : Form
    {
        private const int loadingSeaconds = 1;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbHome.Value == loadingSeaconds)
            {
                timer1.Enabled = false;
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                return;
            }

            pgbHome.Value++;
        }
    }
}