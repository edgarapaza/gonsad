using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GonsadSoft.Departamento
{
    public class CDepartamentos
    {
        Conexion conn = new Conexion();

        public void Departamentos(ComboBox cboDepartamentos)
        {
            try
            {
                string consulta = "SELECT Cod_dpt, Des_dpt  FROM departamentos;";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboDepartamentos.Items.Add(reader.GetString(1));
                }

                conn.CerrarConexion();
            }
            catch (Exception)
            {

            }

        }

        public void InfoDepartamentos(ComboBox cboDepartamentos, TextBox txtIdDepartamento)
        {
            string depart = cboDepartamentos.SelectedItem.ToString();

            string consulta = "SELECT Cod_dpt, Des_dpt FROM departamentos WHERE Des_dpt = '"+depart+"';";
            
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIdDepartamento.Text = reader.GetString(0);
            }


            conn.CerrarConexion();
        }
    }
}
