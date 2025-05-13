namespace BookShelf
{
    public partial class Tela_princpal : Form
    {
        public Tela_princpal()
        {
            InitializeComponent();
            timer.Interval = 1000; 
            timer.Tick += timer_Tick;
            timer.Start(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
