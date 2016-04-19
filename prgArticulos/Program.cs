
//Using son las bibliotecas de configuracion 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// La parte de regiones es una forma ordenada de poner el codigo
// Los metodos set y get de java aqui se le llaman properties

namespace prgArticulos
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
            Application.Run(new frmAcceso());
        }
    }
}
