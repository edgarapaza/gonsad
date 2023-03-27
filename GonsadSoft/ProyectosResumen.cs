using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace GonsadSoft
{
    public partial class ProyectosResumen : Form
    {
        Conexion conn = new Conexion();

        
        public DataSet dtsN = null;
       
        public ProyectosResumen()
        {
            InitializeComponent();
            CargarLista(dgvListadoProyectos);
        }

        public void CargarLista(DataGridView TablaProyectos)
        {
            try
            {
                TablaProyectos.DataSource = null;

                String consulta = "SELECT p.idproyecto AS id,p.nomcorto AS Nombre_Corto,p.cui AS CUI, (SELECT g.cargo FROM gerencia as g WHERE g.idgerencia = p.idgerencia) AS Gerencia,p.plazo,p.obs, p.nomproyecto AS Nombre_Proyecto_Completo FROM proyecto as p;";
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaProyectos.DataSource = dt;
                conn.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
