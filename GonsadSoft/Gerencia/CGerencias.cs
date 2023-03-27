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
    public class CGerencias
    {
        Conexion conn = new Conexion();

        public void ListadoGerencias(ComboBox cboGerencia)
        {
            try
            {
                String consulta = "SELECT cargo FROM gerencia;";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboGerencia.Items.Add(dr.GetString(0));
                }
                dr.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
        }

        public void InfoGerencias(ComboBox gerencia, TextBox txtIdGerencia, TextBox txtNomGerencia)
        {
            string nomGerencia = gerencia.SelectedItem.ToString();
                        
            try
            {
                String consulta = "SELECT idgerencia, nombre, telefono FROM gerencia WHERE cargo = '"+nomGerencia+"';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    txtIdGerencia.Text = dr.GetString(0);
                    txtNomGerencia.Text = dr.GetString(1);
                }
                dr.Close();

                conn.CerrarConexion();
            }catch(Exception e)
            {
                MessageBox.Show("Error : " + e.ToString());
            }
            
        }

    }
}
