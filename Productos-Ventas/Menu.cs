using Empleados_Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos_Ventas
{
    public partial class Menu : Form
    {
       

        //Metodo constructor
        public Menu(string nUsu)
        {
            InitializeComponent();
            LblUsu.Text = nUsu;
            restaurar.Visible = false;
            
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            
        }


        #region Menu


        #endregion
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aumentar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            aumentar.Visible = false;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            aumentar.Visible = true;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #region mostrar_form

        private void MostrarForm(object Formhijo)
        {

            PanFormularios.Controls.Clear();
            Form ShowF = Formhijo as Form;

            ShowF.TopLevel = false;
            ShowF.Dock = DockStyle.Fill;

            PanFormularios.Controls.Add(ShowF);
            PanFormularios.Tag = ShowF;
            ShowF.Show();




        }



        #endregion


        private void BtnProductos_Click(object sender, EventArgs e)
        {


            MostrarForm(new Form1());

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            
            MostrarForm(new Ventas());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            if (PanLeft.Width == 48)
            {
                PanLeft.Width = 120;
            }
            else
            {
                PanLeft.Width = 48;
            }

            if (Logo.Width == 45)
            {
                Logo.Width = 114;
            }
            else
            {
                Logo.Width = 45;
            }
        }

        private void cerrar_Se_Click(object sender, EventArgs e)
        {

            
            Login log = new Login();
          
            log.ShowDialog();


            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            GenerarUsu ShU = new GenerarUsu();

            ShU.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarForm(new Empleados());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarForm(new Proveedores());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarForm(new Compras());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarForm(new Locales());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);

            label1.Text = DateTime.Now.ToLongDateString();
        }
    }
}
