using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class summary : Form
    {
        // Correct constructor
        public summary(Booking booking)
        {
            InitializeComponent(); // Mandatory for Windows Forms
            PopulateFields(booking);
        }

        private void PopulateFields(Booking booking)
        {
            // Ensure these labels exist on your form
            lblName.Text = $"{booking.FirstName} {booking.LastName}";
            lblAddress.Text = booking.Address;
            lblAge.Text = booking.Age.ToString();
            lblDays.Text = booking.Days.ToString();
            lblCarType.Text = booking.SelectedCarType.ToString();
            lblFuelType.Text = booking.SelectedFuelType.ToString();
            lblMileage.Text = booking.UnlimitedMileage ? "Yes" : "No";
            lblBreakdown.Text = booking.BreakdownCover ? "Yes" : "No";
            lblTotal.Text = booking.TotalCost.ToString("C");
        }
    }

    // Form5 should be in a separate file, but if it must stay here:
    public partial class Form5 : Form
    {
        public string name { get; set; }
        public string Surname { get; set; }
        public string address { get; set; }
        public string umer { get; set; }
        public string drive { get; set; }
        public string days { get; set; }
        public string comboBox1 { get; set; }
        public string comboBox2 { get; set; }
        public string checkBox2 { get; set; }
        public string checkBox3 { get; set; }
    }
}






