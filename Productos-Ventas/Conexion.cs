using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Productos_Ventas
{
    class Conexion
    {

        public SqlConnection cone = new SqlConnection("Data Source = LUIS; Initial Catalog = TelefoniaU; Integrated Security = True");
        private SqlCommandBuilder cmb;
        public SqlDataAdapter da;
        public DataSet ds = new DataSet();
        
        public SqlCommand cmd;
        

        public int evaluar;

        public void Conectar()
        {

            try
            {
                cone.Open();

            }
            catch (Exception)
            {

                MessageBox.Show("Conexion No establecida");
            }
            finally
            {
                cone.Close();
            }

        }



        public void Consulta(string sql, string Ntabla)
        {

            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cone);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, Ntabla);

        }




        public bool Operacion(string sql)
        {
            int i;
            cone.Open();
            cmd = new SqlCommand(sql, cone);
            i = cmd.ExecuteNonQuery(); // si se cumple o se ejecuta el comando i tomará valor de 1 
            cone.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public void Login(string sql)
            {

            da = new SqlDataAdapter(sql, cone);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            evaluar = dtbl.Rows.Count;



        }


        public void cerrarCon()
        {
            cone.Close();
        }



    }


       

    }

