using System.Security.Cryptography.X509Certificates;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set the timer interval to 5 seconds
            timer1.Interval = 5000;

            timer1.Tick += Timer1_Tick; // Subscribe to the Tick event

            //start the timer when the form loads
            timer1.Start();

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Stop the timer


            // Close the splash screen
            this.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {








        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
