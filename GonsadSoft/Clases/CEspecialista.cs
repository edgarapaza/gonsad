using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GonsadSoft.Clases
{
    public class CEspecialista
    {
        Conexion conn = new Conexion();

        public void Especialistas(ComboBox cboEspecialista)
        {
           
            string consulta = "SELECT p.idpersonal, concat(p.nombre, ' ', p.apellidos) AS nombres FROM personal AS p;";
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboEspecialista.Items.Add(reader.GetString(1));
            }
           
            conn.CerrarConexion();
        }

        public void InfoEspecialistas(ComboBox cboEspecialista, TextBox idpersonal, TextBox nombres, TextBox dni, TextBox telefono, TextBox especialidad, TextBox colegiatura)
        {

            int posici_on = cboEspecialista.SelectedIndex;
            int posicion = posici_on + 1;
            Console.WriteLine(posicion.ToString());
            
            string consulta = "SELECT p.idpersonal, concat(p.nombre, ' ', p.apellidos) AS nombres, p.dni, p.telefono, e.especialidad, e.colegiatura FROM personal as p, especialista as e WHERE p.idpersonal = e.idpersonal AND p.idpersonal = '"+posicion+"';";
            MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idpersonal.Text = reader.GetString(0);
                nombres.Text = reader.GetString(1);
                dni.Text = reader.GetString(2);
                telefono.Text = reader.GetString(3);
                especialidad.Text = reader.GetString(4);
                colegiatura.Text = reader.GetString(5);
            }

            
            conn.CerrarConexion();
        }
    }
}
