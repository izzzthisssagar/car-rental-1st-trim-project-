namespace _2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            using (Form1 splash = new Form1())
            {
                splash.ShowDialog(); // Blocks here until splash closes
            }

            Application.Run(new introduction()); // Run splash screen first

        }
    }
}