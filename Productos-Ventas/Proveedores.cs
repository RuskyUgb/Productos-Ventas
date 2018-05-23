using Productos_Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados_Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();

            MostrarDatos();

        }

        Conexion con = new Conexion();

        public void MostrarDatos()
        {
            con.Consulta("select * from Proveedores", "TelefoniaU");
            dgvProv.DataSource = con.ds.Tables["TelefoniaU"];

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string agregar = "insert into Proveedores values('" + txtID.Text + "', '" + txtNombre.Text + "','" + txtTelefono.Text + "', '" + txtCorreo.Text + "','" + txtDireccion.Text + "','" + txtID_Produc.Text + "')";
            if (con.Operacion(agregar))
            {
                MessageBox.Show("Datos agregados");
                MostrarDatos();
                limpiar();

            }
            else
            {
                MessageBox.Show("Error al agregar Datos");
            }

           

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar = "update Proveedores set Nombre_prov='" + txtNombre.Text + "', Telefono_prov='" + txtTelefono.Text + "', Correo_prov='" + txtCorreo.Text + "', Direccion_prov='" + txtDireccion.Text + "', ID_Producto='" + txtID_Produc.Text + "'  where ID_Proveedor = '" + txtID.Text + "'";
            if (con.Operacion(modificar))
            {
                MessageBox.Show("Registro Modificado");
                MostrarDatos();
                limpiar();

            }
            else
            {
                MessageBox.Show("Error al Modificar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string elimina = "delete from Proveedores where ID_Proveedor = '" + txtID.Text + "'";
            if (con.Operacion(elimina))
            {
                MessageBox.Show("Datos Eliminados");
                MostrarDatos();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al Eliminar Datos");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (rBtnID.Checked == true)
            {
                string consulta = ("select * from Proveedores where ID_Proveedor='" + txtID.Text + "'");
                con.Consulta(consulta, "Proveedores");
                dgvProv.DataSource = con.ds.Tables["Proveedores"];

            }

            else if (rBtnNombre.Checked == true)
            {
                string consulta = ("select * from Proveedores where Nombre_prov='" + txtNombre.Text + "'");
                con.Consulta(consulta, "Proveedores");
                dgvProv.DataSource = con.ds.Tables["Proveedores"];
            }

            else
            {
                MessageBox.Show("Porfavor seleccione una opcion");
            }
        }

        private void btnMTodos_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow DTG = dgvProv.Rows[e.RowIndex];

            txtID.Text = DTG.Cells[0].Value.ToString();
            txtNombre.Text = DTG.Cells[1].Value.ToString();
            txtTelefono.Text = DTG.Cells[2].Value.ToString();
           txtCorreo.Text = DTG.Cells[3].Value.ToString();
            txtDireccion.Text = DTG.Cells[4].Value.ToString();
            txtID_Produc.Text = DTG.Cells[5].Value.ToString();







        }

        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtID_Produc.Text = "";
            txtID.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
