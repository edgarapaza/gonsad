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
    public class CProvincias
    {
        Conexion conn = new Conexion();


        public void ListadoProvincias(string codDepartamento, ComboBox cboProvincia)
        {
            try
            {
                string consulta = "SELECT Cod_pvi, Des_pvi FROM provincias WHERE Cod_dpt = '" + codDepartamento + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboProvincia.Items.Add(reader.GetString(1));
                }
                reader.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }

        }
        public void SelectProvincia(ComboBox cboProvincia, TextBox txtIdProvincia)
        {
            string provin = cboProvincia.SelectedItem.ToString();

            try
            { 
                String consulta = "SELECT Cod_pvi, Des_pvi FROM provincias WHERE Des_pvi = '" + provin + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtIdProvincia.Text= reader.GetString(0);
                }

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.ToString());
            }

        }

        public void InfoProvincias(ComboBox cboProvincia, TextBox txtIdProvincia)
        {
            string provin = cboProvincia.SelectedItem.ToString();
            

            string consulta = "SELECT Cod_pvi, Des_pvi FROM provincias WHERE Des_pvi = '"+provin+"';";
            
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIdProvincia.Text = reader.GetString(0);
            }


            conn.CerrarConexion();
        }
    }
}
