using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Starting());
            //Application.Run(new ProductEntry());
=======
            // Application.Run(new Starting());
            Application.Run(new ResetSalesmanPass());
>>>>>>> 0854c634a3d73ea5f487cb6d4aadb9bf43bc174b
        }
    }
}
