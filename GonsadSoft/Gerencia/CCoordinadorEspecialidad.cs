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
    public class CCoordinadorEspecialidad
    {
        Conexion conn = new Conexion();

        public void ListaEspecialista(ComboBox cboEspecialista)
        {
            try
            {
                String consulta = "SELECT especialidad FROM especialista;";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboEspecialista.Items.Add(dr.GetString(0));
                }
                dr.Close();

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
        }

        public void InfoEspecialista(ComboBox cboEspealista, TextBox txtIdEspecialista, TextBox txtNomEspecialista)
        {
            string nomEspecialidad = cboEspealista.SelectedItem.ToString();

            try
            {
                string consulta = "SELECT idEspecialista, nombre FROM especialista WHERE especialidad = '"+ nomEspecialidad + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtIdEspecialista.Text = dr.GetString(0);
                    txtNomEspecialista.Text = dr.GetString(1);
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
