namespace _2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Database.Initialize(); // Initialize the database

            using (Form1 splash = new Form1())
            {
                splash.ShowDialog(); // Blocks here until splash closes
            }

            Application.Run(new homepage()); // Run splash screen first
        }
    }
}
