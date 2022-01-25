using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracjaSteamProjekt
{
    static class Program
    {
        /// <summary>
        /// W³aœciwoœæ przechowuj¹ca Task dla stworzonego hosta soapAPI
        /// </summary>
        public static Task SoapApiTask { get; set; }
        /// <summary>
        /// W³aœciwoœæ przechowuj¹ca Task dla stworzonego hosta APIGateway
        /// </summary>
        public static Task ApiGatewayTask { get; set; }
        /// <summary>
        /// W³aœciwoœæ przechowuj¹ca g³ówny form w celu odniesienia do niego z innych klas
        /// </summary>
        public static Form1 Form { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new();
            Application.Run(Form);
        }
    }
}
