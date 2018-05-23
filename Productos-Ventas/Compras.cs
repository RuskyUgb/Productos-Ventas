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
    public partial class Compras : Form
    {
        Conexion con = new Conexion();
        public Compras()
        {
            InitializeComponent();
            ShowData();
        }

        private void Compras_Load(object sender, EventArgs e)
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
            string guardarV = "insert into compras values ('" + Txcompra.Text + "','" + Txdia.Text + "','" + Txmes.Text + "','" + Txanio.Text + "', '" + Txproveedor.Text + "', '" + TxtProducto.Text + "', '" + Txcantipro.Text + "')";


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

            public void ShowData()
            {


                con.Consulta("select * from compras", "compras");
                DTG1.DataSource = con.ds.Tables["compras"];


            }


        public void Limpiar()
        {

           Txcompra.Clear();
            Txdia.Clear();
            Txmes.Clear();
            Txanio.Clear();
            Txcantipro.Clear();
            TxtProducto.Clear();
            Txproveedor.Clear();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Modificar

            string Updatedatos = "update compras set Dia_comp='" + Txdia.Text + "',Mes_comp='" + Txmes.Text + "',Anio_comp='" + Txanio.Text + "',ID_Proveedor='" + Txproveedor.Text + "',ID_Producto= '" + TxtProducto.Text + "',CantidadProducto_comp= '" + Txcantipro.Text + "' where id_compras='" + Txcompra.Text + "'";


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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string Delete = "delete from compras where id_compras ='" + Txcompra.Text + "'";

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

        private void DTG1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow DTG = DTG1.Rows[e.RowIndex];


            Txcompra.Text = DTG.Cells[0].Value.ToString();
            Txdia.Text = DTG.Cells[1].Value.ToString();
            Txmes.Text = DTG.Cells[2].Value.ToString();
            Txanio.Text = DTG.Cells[3].Value.ToString();
           Txproveedor.Text = DTG.Cells[4].Value.ToString();
            TxtProducto.Text = DTG.Cells[5].Value.ToString();
            Txcantipro.Text = DTG.Cells[5].Value.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where id_compras like '" + Txcompra.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where Dia_comp like '" + Txdia.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where Mes_comp like '" + Txmes.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where Anio_comp like '" + Txanio.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where ID_Proveedor like '" + Txproveedor.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string FilNombre = "select * from compras where ID_Producto like '" + TxtProducto.Text + "'";

            con.Consulta(FilNombre, "compras");
            DTG1.DataSource = con.ds.Tables["compras"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
