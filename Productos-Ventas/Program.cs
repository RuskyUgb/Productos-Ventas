using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos_Ventas
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

            // INstancia

              Login usua = new Login();
             Conexion conp = new Conexion();
              usua.ShowDialog();


            if (usua.validar) {

           Application.Run(new Menu(usua.usuario));
            //Application.Run(new GenerarUsu());

            }





        }
    }
}
