using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonsadSoft.Clases
{
    public class CProyectos
    {
        Conexion conn = new Conexion();
        public CProyectos() { }

        public void GuardarProyecto(string nomproyecto, string nomcorto, string cui, string departamento, string provincia, string distrito, string idpersonal, string obs, string idespecialidad, string idgerencia, string idcoordinador, string idcoorespecialidad, string idcliente, string plazo, string jornada)
        {
            try {
                string consulta = "INSERT INTO proyecto (idproyecto,nomproyecto,nomcorto,cui,departamento,provincia,distrito,idpersonal,obs,idespecialidad,idgerencia,idcoordinador,idcoorespecialidad,idcliente,plazo,jornada) VALUES (NULL,'" + nomproyecto + "','" + nomcorto + "','" + cui + "','" + departamento + "','" + provincia + "','" + distrito + "','" + idpersonal + "','" + obs + "','" + idespecialidad + "','" + idgerencia + "','" + idcoordinador + "','" + idcoorespecialidad + "','" + idcliente + "','" + plazo + "','" + jornada + "');";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("Proyecto Creado.  Por favor espere hasta que Termine de copiar la Carpeta y salga el Mensaje de Concluido.");
                
                conn.CerrarConexion();

            } catch (Exception ex) {
                MessageBox.Show("Error guardando proyecto. Error : " + ex.Message);
            }
        }

        public void ListadoProyectos(TreeNode tree)
        {
            try
            {
                tree.Nodes.Clear();
                string consulta = "SELECT nomcorto FROM proyecto ORDER BY nomcorto;";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tree.Nodes.Add(reader.GetString(0));
                    
                }

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show ("Error mostrando listado de proyectos. Error : "+e.Message);
            }
        }
    }
}
