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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            new bookingpage().Show(); // Show the new form

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
