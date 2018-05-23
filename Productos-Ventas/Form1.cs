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
    public partial class Form1 : Form
    {

        //Instancia

        Conexion con = new Conexion();
        public Form1()
        {
            InitializeComponent();
            con.Conectar();

            Pnl.Visible = false;
            BtnCerrar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ShowData();



        }

        #region MostrarDatos
        public void ShowData()
        {


            con.Consulta("select * from Productos", "Productos");
            DTG1.DataSource = con.ds.Tables["Productos"];


        }




        #endregion





        #region ClearTextBox


        public void Limpiar()
        {

            TxIdProd.Clear();
            TxNomProd.Clear();
            TxModPro.Clear();
            TxCantProd.Clear();
            TxPrecProd.Clear();

        }

        #endregion



        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }


        #region ConfiguracionBotones


        private void button1_Click(object sender, EventArgs e)
        {
            Pnl.Visible = true;
            BtnCerrar.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            Pnl.Visible = false;
            panel2.Visible = false;
            BtnCerrar.Visible = false;

        }


        private void button3_Click(object sender, EventArgs e)
        {


            string Delete = "delete from Productos where ID_Producto ='" + TxIdProd.Text + "'";

            if (con.Operacion(Delete))
            {
                MessageBox.Show("Datos Borrados Correctamente");
                
                ShowData();

                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al borrar datos");
            }

        }




        private void button4_Click(object sender, EventArgs e)
        {

            //Modificar

            string Updatedatos = "update Productos set Nom_Producto='" + TxNomProd.Text + "',Model_Producto='" + TxModPro.Text + "',Exist_Producto='" + TxCantProd.Text + "',Precio_Producto='" + TxPrecProd.Text + "' where ID_Producto='" + TxIdProd.Text + "'";


            if (con.Operacion(Updatedatos))
            {
                MessageBox.Show("Datos actualizados Correctamente");
                ShowData();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error de actualizacion de  datos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Guardar = "insert into Productos values ('" + TxIdProd.Text + "','" + TxNomProd.Text + "','" + TxModPro.Text + "','" + TxCantProd.Text + "', '" + TxPrecProd.Text + "')";

            if (con.Operacion(Guardar))
            {
                MessageBox.Show("Datos Guardados");
                ShowData();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar datos");
            }



        }
        
        private void button5_Click(object sender, EventArgs e)
        {

            //Consultar Todos los datos
            ShowData();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }



        #endregion



        #region datosentexbox
        private void ClicDGV(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DTG = DTG1.Rows[e.RowIndex];
            

            TxIdProd.Text = DTG.Cells[0].Value.ToString();
            TxNomProd.Text = DTG.Cells[1].Value.ToString();
            TxModPro.Text = DTG.Cells[2].Value.ToString();
            TxCantProd.Text = DTG.Cells[3].Value.ToString();
            TxPrecProd.Text = DTG.Cells[4].Value.ToString();

        }

        #endregion

        #region Checkboxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            string FilNombre = "select * from Productos where Nom_Producto like '" + TxNomProd.Text + "'";

            con.Consulta(FilNombre, "Productos");
            DTG1.DataSource = con.ds.Tables["Productos"];




        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            string FilModelo = "select * from Productos where Model_Producto like '"+TxModPro.Text+"'";


            //Se actualiza el datagrid

            con.Consulta(FilModelo, "Productos");
            DTG1.DataSource = con.ds.Tables["Productos"];

        }
        #endregion

    }
}
