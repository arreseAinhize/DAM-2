using System.Runtime.InteropServices;

namespace Ariketa_2
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
    public class Zenbakia
    {
        public float emaitza;
        public string emaitzaString;
        public float BukaerakoEmaitza { get { return this.emaitza; } }

        public float sartutakoZenbakia { get; set; }

        public Zenbakia(float sartutakoZenbakia) {
            this.sartutakoZenbakia = sartutakoZenbakia;
        }
        public void SetEmaitza(float z1, float z2, float z3, float z4)
        {
            emaitza = (z1 + (2 * z2) + (3 * z3) + (4 * z4)) / 4;
        }
        public string GetEmaitzaString(float z1, float z2, float z3, float z4)
        {
            emaitzaString = $"( {z1} + ({z2} * 2 ) + ({z3} * 3) + ({z4} * 4) ) / 4 = " + emaitza.ToString("0.00");
            // Berdiña beste era batera: emaitzaString = $"( {z1} + (2 * {z2}) + (3 * {z3}) + (4 * {z4})) / 4 = {emaitza:0.00}";
            return emaitzaString;
        }
    }
}