using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the username and password are correct
            string username = textBox3.Text;
            string password = textBox2.Text;

            if (username == "sta001" && password == "givemethekeys123")
            {
                this.Hide(); // Hide the current form
                new homepage().Show(); // Show the new form

            }

            else
            {
                MessageBox.Show("Invalid credentials.");

            }



        }


        private void loginpage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                textBox2.UseSystemPasswordChar = true; // Hide password
            }
        }
    }
}
