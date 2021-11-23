using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pizzeria
{
    static class Program
    {

        public static Usuario UsuarioLogueado;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        public static byte [] imageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);  

            return ms.ToArray();
        }
    }
}
 