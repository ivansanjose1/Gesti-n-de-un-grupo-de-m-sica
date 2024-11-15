using Gestion_de_un_grupo_musical.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_un_grupo_musical
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Global.CargarDatosGolbal();
            Login Login = new Login();
            Login.Show();
            Application.Run();
        }
    }
}
