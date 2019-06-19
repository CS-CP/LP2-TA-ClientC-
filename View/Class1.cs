using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace View
{
    static class Class1
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainWindow mainWindow = new MainWindow();
                Application.Run(new AuthenticationForm(mainWindow));
                //Application.Run(new MainWindow());
            }
        }
    }
}
