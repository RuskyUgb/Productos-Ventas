using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Productos_Ventas
{
    public partial class GenerarUsu : Form
    {


        Conexion con = new Conexion();
        public GenerarUsu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BTNaceptar_Click(object sender, EventArgs e)
        {

            //instancia clase encriptado

              string usuario, passwd,Empleado;


            Empleado = TxEMP.Text;
            usuario = TxUsuario.Text;
            passwd = Txpasswd.Text;


           passwd =  getsha1(Txpasswd.Text);




            string insertar = "insert into Usuarios values('" + usuario + "', '"+passwd+ "', '" + Empleado + "' )";

            if (con.Operacion(insertar))
            {
                MessageBox.Show("Datos Guardados");
                //Txsha.Text = passwd;   text box 3 para mostrar la contraseña encriptada
            }
            else
            {
                MessageBox.Show("Error al guardar datos");
            }

           


        }



        public static string getsha1(string str)
        {

            SHA1 sha1 = SHA1Managed.Create(); // se usa para generar el SHA1

            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;

            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();


        }






    }
}
