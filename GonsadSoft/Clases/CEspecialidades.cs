using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GonsadSoft.Clases
{
    public class CEspecialidades
    {
        Conexion conn = new Conexion();

        public void Especialidades(ComboBox cboEspecialidad)
        {
            string consulta = "SELECT idEspecialidades, nomespecialidad, nivel FROM especialidades;";
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboEspecialidad.Items.Add(reader.GetString(1));
            }

            conn.CerrarConexion();
        }

        public void InfoEspecialidades(ComboBox cboEspecialidad, TextBox txtIdEspecialidad)
        {

            int posici_on = cboEspecialidad.SelectedIndex;
            int posicion = posici_on + 1;
            Console.WriteLine(posicion.ToString());

            string consulta = "SELECT idEspecialidades, nomespecialidad, nivel FROM especialidades WHERE idEspecialidades = '"+ posicion + "';";
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtIdEspecialidad.Text = reader.GetString(0);
            }


            conn.CerrarConexion();
        }
    }
}
