namespace Lab6
{
    internal static class Program
    {
        public static List<Book> book_list = new List<Book>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}