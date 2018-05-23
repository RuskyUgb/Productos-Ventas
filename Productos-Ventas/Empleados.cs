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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();

            MostrarDatos();

        }

        Conexion con = new Conexion();

        public void MostrarDatos()
        {
            con.Consulta("select * from Empleado", "Empleado");
            dgvEmpleado.DataSource = con.ds.Tables["Empleado"];

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into Empleado values('" + txtID.Text + "', '" + txtNombre.Text + "','" + txtApellido.Text + "', '" + txtCargo.Text + "','"+ txtTelefono.Text +"','"+Txlocal.Text+"')";
            if (con.Operacion(agregar))
            {
                MessageBox.Show("Datos agregados");
                MostrarDatos();

            }
            else
            {
                MessageBox.Show("Error al agregar Datos");
            }

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar = "update Empleado set Nombre_emp='" + txtNombre.Text + "', Apellido_emp='" + txtApellido.Text + "', Cargo_emp='" + txtCargo.Text + "', Telefono_emp='"+ txtTelefono.Text +"', id_local = '"+Txlocal.Text+"'  where ID_Empleado = '" + txtID.Text + "'";
            if (con.Operacion(modificar))
            {
                MessageBox.Show("Registro Modificado");
                MostrarDatos();
                limpia();
            }
            else
            {
                MessageBox.Show("Error al Modificar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string elimina = "delete from Empleado where ID_Empleado = '" + txtID.Text + "'";
            if (con.Operacion(elimina))
            {
                MessageBox.Show("Datos Eliminados");
                MostrarDatos();
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
                string consulta = ("select * from Empleado where ID_Empleado='" + txtID.Text + "'");
                con.Consulta(consulta, "empleados");
                dgvEmpleado.DataSource = con.ds.Tables["empleados"];

            }

            else if (rBtnNombre.Checked == true)
            {
                string consulta = ("select * from Empleado where Nombre_emp='" + txtNombre.Text + "'");
                con.Consulta(consulta, "empleados");
                dgvEmpleado.DataSource = con.ds.Tables["empleados"];
            }

            else if (rBtnCargo.Checked == true)
            {
                string consulta = ("select * from Empleado where Cargo_emp='" + txtCargo.Text + "%'");
                con.Consulta(consulta, "empleados");
                dgvEmpleado.DataSource = con.ds.Tables["empleados"];
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


        public void limpia()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            
            txtID.Focus();


        }

        private void rBtnID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DTG = dgvEmpleado.Rows[e.RowIndex];

            txtID.Text= DTG.Cells[0].Value.ToString();
            txtNombre.Text = DTG.Cells[1].Value.ToString();
            txtApellido.Text = DTG.Cells[2].Value.ToString();
            txtCargo.Text = DTG.Cells[3].Value.ToString();
           txtTelefono.Text = DTG.Cells[4].Value.ToString();
            Txlocal.Text = DTG.Cells[5].Value.ToString();



        }

        private void label8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
