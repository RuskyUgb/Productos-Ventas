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
    public partial class Locales : Form
    {
        Conexion con = new Conexion();
        public Locales()
        {
            InitializeComponent();
            BtnCerrar.Visible = false;
            ShowData();
        }

        private void Locales_Load(object sender, EventArgs e)
        {
            con.Conectar();


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

        private void BtnGuardar_Click(object sender, EventArgs e)

        {
            string guardarV = "insert into Locales values ('" + TxLocal.Text + "','" + Txnomlocal.Text + "','" + TxTelefono.Text + "','" + TxDireccion.Text + "', '" + TxCorreo.Text + "', '" + Txempleado.Text + "')";


            if (con.Operacion(guardarV))
            {

                MessageBox.Show("Datos guardados");
                ShowData();
                Limpiar();




            }
            else
            {


                MessageBox.Show("Error al guardar datos.");
            }



        }




        public void Limpiar()
        {

            TxCorreo.Clear();
            TxDireccion.Clear();
            Txempleado.Clear();
            TxTelefono.Clear();
            Txnomlocal.Clear();
            TxLocal.Clear();

        }

        #region MostrarDatos
        public void ShowData()
        {


            con.Consulta("select * from Locales", "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];


        }







        #endregion

        private void xx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Modificar

            string Updatedatos = "update Locales set nombre_loc='" + Txnomlocal.Text + "',telefono_loc='" + TxTelefono.Text + "',Direccion_loc='" + TxDireccion.Text + "',Correo_loc='" + TxCorreo.Text + "',cant_Empleados= '"+ Txempleado.Text+"' where id_local='" + TxLocal.Text + "'";


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

        private void DTG1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow DTG = DTG1.Rows[e.RowIndex];


            TxLocal.Text = DTG.Cells[0].Value.ToString();
            Txnomlocal.Text = DTG.Cells[1].Value.ToString();
            TxTelefono.Text = DTG.Cells[2].Value.ToString();
            TxDireccion.Text = DTG.Cells[3].Value.ToString();
            TxCorreo.Text = DTG.Cells[4].Value.ToString();
            Txempleado.Text = DTG.Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string Delete = "delete from Locales where id_local ='" + TxLocal.Text + "'";

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

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from Locales where id_local like '" + TxLocal.Text + "'";

            con.Consulta(FilNombre, "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from Locales where nombre_loc like '" + Txnomlocal.Text + "'";

            con.Consulta(FilNombre, "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from Locales where telefono_loc like '" + TxTelefono.Text + "'";

            con.Consulta(FilNombre, "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from Locales where Direccion_loc like '" + TxDireccion.Text + "'";

            con.Consulta(FilNombre, "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from Locales where Correo_loc like '" + TxCorreo.Text + "'";

            con.Consulta(FilNombre, "Locales");
            DTG1.DataSource = con.ds.Tables["Locales"];
        }
    }
}
