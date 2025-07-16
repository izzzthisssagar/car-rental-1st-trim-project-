using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _2
{
    public partial class bookingpage : Form
    {
        private List<Booking> bookings = new List<Booking>();

        public bookingpage()
        {
            InitializeComponent();
            InitializeCarTypes();
            InitializeFuelTypes();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            // Connect all input controls to calculation
            fname.TextChanged += AnyInputChanged;
            lname.TextChanged += AnyInputChanged;
            address.TextChanged += AnyInputChanged;
            number_of_days.TextChanged += AnyInputChanged;
            age.ValueChanged += AnyInputChanged;
            car_type.SelectedIndexChanged += AnyInputChanged;
            fueltype.SelectedIndexChanged += AnyInputChanged;
            validity.CheckedChanged += AnyInputChanged;
            checkBox2.CheckedChanged += AnyInputChanged;
            checkBox3.CheckedChanged += AnyInputChanged;
        }

        private void InitializeCarTypes()
        {
            car_type.Items.AddRange(Enum.GetNames(typeof(CarType)));
        }

        private void InitializeFuelTypes()
        {
           fueltype.Items.AddRange(Enum.GetNames(typeof(FuelType)));
        }

        private void CalculateTotalPrice()
        {
            if (!int.TryParse(number_of_days.Text, out int days) || days < 1 || days > 28) return;

            decimal total = 25 * days;

            // Car type surcharge
            switch ((CarType)car_type.SelectedIndex)
            {
                case CarType.Family: total += 50; break;
                case CarType.Sports: total += 75; break;
                case CarType.SUV: total += 65; break;
            }

            // Fuel type surcharge
            switch ((FuelType)fueltype.SelectedIndex)
            {
                case FuelType.Hybrid: total += 30; break;
                case FuelType.Electric: total += 50; break;
            }

            // Optional extras
            if (checkBox2.Checked) total += 10 * days;
            if (checkBox3.Checked) total += 2 * days;

            lblTotal.Text = $"Total Price: £{total:N2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var booking = new Booking
            {
                FirstName = fname.Text,
                LastName = lname.Text,
                Address = address.Text,
                Age = (int)age.Value,
                HasValidLicense = validity.Checked,
                Days = int.Parse(number_of_days.Text),
                SelectedCarType = (CarType)car_type.SelectedIndex,
                SelectedFuelType = (FuelType)fueltype.SelectedIndex,
                UnlimitedMileage = checkBox2.Checked,
                BreakdownCover = checkBox3.Checked,
                TotalCost = decimal.Parse(lblTotal.Text.Replace("Total Price: £", ""))
            };

            bookings.Add(booking);

            // Show summary form
            this.Hide();
            new summary(booking).Show(); // Pass the booking object to the summary form
            this.Close(); // Close the current form

        }



        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(fname.Text)) return ShowError("First name required");
            if (string.IsNullOrEmpty(address.Text)) return ShowError("Address required");
            if (car_type.SelectedIndex == -1) return ShowError("Car type required");
            if (fueltype.SelectedIndex == -1) return ShowError("Fuel type required");
            if (string.IsNullOrEmpty(number_of_days.Text)) return ShowError("Number of days required");
            if (!int.TryParse(number_of_days.Text, out int days) || days < 1 || days > 28)
                return ShowError("Invalid number of days (1-28)");

            if (string.IsNullOrEmpty(lname.Text)) return ShowError("Last name required");
            if (age.Value < 18) return ShowError("Minimum age is 18");
            if (!validity.Checked) return ShowError("Valid license required");
            if (!int.TryParse(number_of_days.Text, out int daysVal) || daysVal < 1 || daysVal > 28)
                return ShowError("Invalid days (1-28)");

            return true;
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void AnyInputChanged(object sender, EventArgs e) => CalculateTotalPrice();
    }

    public class Booking
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool HasValidLicense { get; set; }
        public int Days { get; set; }
        public CarType SelectedCarType { get; set; }
        public FuelType SelectedFuelType { get; set; }
        public bool UnlimitedMileage { get; set; }
        public bool BreakdownCover { get; set; }
        public decimal TotalCost { get; set; }
    }

    public enum CarType { City, Family, Sports, SUV }
    public enum FuelType { Petrol, Diesel, Hybrid, Electric }
}