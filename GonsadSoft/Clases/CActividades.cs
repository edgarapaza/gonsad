using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonsadSoft.Clases
{
    public class CActividades
    {
        Conexion conn = new Conexion();
        public void Guardar(string item, string dias, string parcial, string estadia, string subtotal, string idproyecto)
        {
            try {

                string consulta = "INSERT INTO activades (idactivades,item,dias,parcial,estadia,subtotal,idproyecto) VALUES (NULL,'" + item + "','" + dias + "','" + parcial + "','" + estadia + "','" + subtotal + "','" + idproyecto + "');";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                
                conn.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error actualizando.  " +ex.ToString()+" Contacte con el Administrador del sistema");
            }

        }

        public void Modificar(string idtitem, string item, string dias, string parcial, string estadia, string subtotal)
        {
            try
            {
                string consulta = "UPDATE activades SET item = '" + item + "',dias = '" + dias + "',parcial = '" + parcial + "',estadia = '" + estadia + "',subtotal = '" + subtotal + "' WHERE idactivades = " + idtitem + ";";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Los datos fueron actualizados con exito");

                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando.  " + ex.ToString() + " Contacte con el Administrador del sistema");
            }

        }
    }
}
