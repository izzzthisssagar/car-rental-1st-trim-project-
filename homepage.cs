namespace _2
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginpage login = new loginpage();
            login.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            bookingpage booking = new bookingpage();
            booking.Show();
        }
    }
}
