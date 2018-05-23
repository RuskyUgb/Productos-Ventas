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


    public partial class Ventas : Form
    {

        Conexion con = new Conexion();

        public Ventas()
        {
            InitializeComponent();
            BtnCerrar.Visible = false;

        }


        #region Limpiar
        public void Limpiar()
        {

            TxAnio.Clear();
            TxCliente.Clear();
            TxDia.Clear();
            TxDocumento.Clear();
            TxEmpleado.Clear();
            TxMes.Clear();
            TxNomProducto.Clear();
            TxTotal.Clear();
            TxVenta.Clear();
            

        }
        #endregion
        private void Ventas_Load(object sender, EventArgs e)
        {

            con.Conectar();

            Showdata();


        }

        private void Showdata()
        {
            con.Consulta("select * from Venta", "Ventas");
            DTG1.DataSource = con.ds.Tables["Ventas"];

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnCerrar.Visible = true;
            Pnl.Visible = true;
            

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Pnl.Visible = false;
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string guardarV = "insert into Venta values ('" + TxVenta.Text + "','" + TxDia.Text + "','" + TxMes.Text + "','" + TxAnio.Text + "', '" + TxEmpleado.Text + "', '"+ TxNomProducto.Text+"','"+TxDocumento.Text+"','"+TxCliente.Text+"','"+TxTotal.Text+"')";


            if (con.Operacion(guardarV))
            {

                MessageBox.Show("Datos guardados");
                Showdata();
                Limpiar();

            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string borrar = "DELETE from venta where ID_Venta = '" +TxVenta.Text +"'";

            if (con.Operacion(borrar))
            {
                MessageBox.Show("Datos Borrados Correctamente");

                Showdata();

                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al borrar datos");
            }


        }

        private void DTG1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow DTG = DTG1.Rows[e.RowIndex];

            TxVenta.Text = DTG.Cells[0].Value.ToString();
            TxDia.Text = DTG.Cells[1].Value.ToString();
            TxMes.Text = DTG.Cells[2].Value.ToString();
            TxAnio.Text = DTG.Cells[3].Value.ToString();
            TxEmpleado.Text = DTG.Cells[4].Value.ToString();
            TxNomProducto.Text = DTG.Cells[5].Value.ToString();
            TxDocumento.Text = DTG.Cells[6].Value.ToString();
            TxCliente.Text = DTG.Cells[7].Value.ToString();
            TxTotal.Text = DTG.Cells[8].Value.ToString();


        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            Showdata();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            string FilId = "select * from Venta where ID_Venta like '" + TxVenta.Text + "'";

            con.Consulta(FilId, "Venta");
            DTG1.DataSource = con.ds.Tables["Venta"];



        }
    }
}
