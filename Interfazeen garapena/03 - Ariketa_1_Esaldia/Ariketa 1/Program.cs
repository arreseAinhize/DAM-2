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

    public class Esaldia {
        
        public string hitza { get; set; }
        
        /*public string EsaldiaBatuta{ 
            get
            {
                return this.hitza + " "; 
            }
        }*/
        
        /*public Esaldia(string testua)
        {
            this.hitza = testua;
        }*/

         
         public string esaldiaBatuta = "";
         public string EsaldiaBatuta { get { return this.hitza + " "; } }
         public void SetEsaldiaBatuta(string hitza){
            this.esaldiaBatuta = this.esaldiaBatuta + " " + hitza; //<-- this. ez dau falta eitten ez dauelako izen berdiñekorik.
         }
         


    }


}