using System;
using System.Data;
using System.Windows.Forms;
using GonsadSoft.Clases;
using MySql.Data.MySqlClient;

namespace GonsadSoft
{
    class Validacion
    {
        public int Validar(String usuario, String passwd)
        {
            int res = 0;
            String user = usuario;
            String pass = passwd;

            try
            {
                Conexion conn = new Conexion();

                String consulta = "SELECT idpersonal, nivel, activo FROM login WHERE loginname = '"+usuario+"' AND passwd = '"+passwd+"';";
                
                MySqlCommand command = new MySqlCommand(consulta, conn.Conectar());

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) { }

                res = 1;

                conn.CerrarConexion();
            }
            catch {
                MessageBox.Show("Error");
                res = 0;
            }

            return res;
        }
    }
}
