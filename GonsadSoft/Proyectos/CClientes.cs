using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonsadSoft.Proyectos
{
    internal class CClientes
    {
        Conexion conn = new Conexion();

        public void MostrarClientes(DataGridView tablaClientes)
        {
            try
            {
                String consulta = "SELECT * FROM personal";
                tablaClientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaClientes.DataSource = dt;
                conn.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Seleccionar(DataGridView tablaClientes,TextBox idcliente, TextBox nomcliente, TextBox razonSocial, TextBox ruc)
        {
            idcliente.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
            nomcliente.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
            razonSocial.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
            ruc.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
        }


    }
}
