using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonsadSoft.Proyectos
{
    internal class CCategorias
    {
        Conexion conn = new Conexion();
        internal void Listar(TreeView treeProyectos,TextBox txtIdCategoria, ListView lstproy)
        {
            try
            {
                string conculta = "SELECT idcategoria, nombre FROM categoria;";
                MySqlCommand cmd = new MySqlCommand(conculta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstproy.Items.Add(dr.GetString(0));
                    treeProyectos.Nodes.Add(dr.GetString(1));
                }
                dr.Close();
                conn.CerrarConexion();
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex);
            }
        }

       
    }
}
