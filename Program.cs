namespace _2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                Database.Initialize(); // Initialize the database
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Form1 splash = new Form1())
            {
                splash.ShowDialog(); // Blocks here until splash closes
            }

            Application.Run(new homepage()); // Run splash screen first
        }
    }
}
