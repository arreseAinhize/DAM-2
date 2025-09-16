namespace Ariketa_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    internal class Esaldia {
        public string hitza { get; set; }
        
        public string hitzakBatu{ 
            get
            {
                return this.hitza + " "; 
            }
        }
        public Esaldia(string testua )
        {
            this.hitza = testua;
        }

    }


}