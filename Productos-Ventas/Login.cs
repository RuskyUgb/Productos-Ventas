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
    public partial class Login : Form
    {

        Conexion con = new Conexion();

        public string usuario;
        public bool validar = false;
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            #region u 

            //GenerarUsu usua = new GenerarUsu();

            string passwd;

            usuario = TxUsuario.Text;
            passwd = TxContrasena.Text;

            // se accede al meto getsha1 para encriptar la contraseña para luego evaluar y comparar en la base de datos
            passwd = getsha1(TxContrasena.Text);

            string sql = ("Select * from Usuarios where username = '" + usuario + "' and Userpassword = '" + passwd + "'");
            con.Login(sql);

            if (con.evaluar == 1)
            {
                MessageBox.Show("Bienvenido " + usuario);

                validar = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

            con.cerrarCon();

            #endregion








        }

        private void TxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mismo proceso del botón de ingresar solo que al presionar la tecla enter
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string passwd;

                usuario = TxUsuario.Text;
                passwd = TxContrasena.Text;

                // se accede al meto getsha1 para encriptar la contraseña para luego evaluar y comparar en la base de datos
                passwd = getsha1(TxContrasena.Text);

                string sql = ("Select * from Usuarios where username = '" + usuario + "' and Userpassword = '" + passwd + "'");
                con.Login(sql);

                if (con.evaluar == 1)
                {
                    MessageBox.Show("Bienvenido " + usuario);

                    validar = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

                con.cerrarCon();


            }
            

        }

#region sha1
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
        #endregion




    }
}
