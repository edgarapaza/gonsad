using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonsadSoft.Gerencia
{
    internal class CCoordGeneral
    {
        Conexion conn = new Conexion();

        public void ListaCoordinadorGeneral(ComboBox cboCoorGeneral, TextBox txtIdGerencia)
        {
            

            try
            {
                int id_gerencia = Int32.Parse(txtIdGerencia.Text);
                String consulta = "SELECT nombre FROM coordinadorgeneral WHERE idgerencia = "+ id_gerencia + ";";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboCoorGeneral.Items.Add(dr.GetString(0));
                }
                dr.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
        }

        public void InfoGerencias(ComboBox CoorGeneral, TextBox txtidCoorGeneral, TextBox txtCargoCoordinador)
        {
            string nomCoordinador = CoorGeneral.SelectedItem.ToString();

            try
            {
                string consulta = "SELECT idcoordinador, cargo FROM coordinadorgeneral WHERE nombre = '"+nomCoordinador+"';";
                

                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtidCoorGeneral.Text = dr.GetString(0);
                    txtCargoCoordinador.Text = dr.GetString(1);
                }
                dr.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.ToString());
            }

        }
    }
}
