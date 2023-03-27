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
    public class CDistritos
    {
        Conexion conn = new Conexion();

        public void ListaDistritos(string idprovincia, ComboBox cboDistrito)
        {
            try
            {
               
                String consulta = "SELECT Cod_dst, Des_dst FROM distritos WHERE Cod_pvi = '" + idprovincia + "';";
                
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboDistrito.Items.Add(dr.GetString(1));
                }
                dr.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void SelectDistrito(ComboBox cboDistrito, TextBox txtIdDistrito)
        {
            string distri = cboDistrito.SelectedItem.ToString();
            try 
            {
                
                String consulta = "SELECT Cod_dst, Des_dst FROM distritos WHERE Des_dst = '"+distri+"';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtIdDistrito.Text = dr.GetString(0);
                }

                dr.Close();

                conn.CerrarConexion();

            } catch (Exception e)
            {
                MessageBox.Show("Error: "+e.ToString());
            }
            
        }

        public void InfoDistrito(ComboBox cboDistrito, TextBox txtIdDistrito)
        {
            string distri = cboDistrito.SelectedItem.ToString();

            string consulta = "SELECT Cod_dst, Des_dst FROM distritos WHERE Des_dst = '" + distri + "';";

            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIdDistrito.Text = reader.GetString(0);
            }


            conn.CerrarConexion();
        }

    }
}
