using GonsadSoft.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using GonsadSoft.Departamento;
using MySql.Data.MySqlClient;
using GonsadSoft.Gerencia;

namespace GonsadSoft
{
    public partial class NuevoProyecto : Form
    {
        Conexion conn = new Conexion();

        Computer computer = new Computer();

        CEspecialidades especialidades = new CEspecialidades();
        CDepartamentos departamentos = new CDepartamentos();
        CProvincias provincias= new CProvincias();
        CDistritos distritos = new CDistritos();

        CGerencias gerencias = new CGerencias();
        CCoordGeneral general = new CCoordGeneral();
        CCoordinadorEspecialidad coorespecialidad = new CCoordinadorEspecialidad();

        public NuevoProyecto()
        {
            InitializeComponent();

            CargarRecursos();
        }

        public void CargarRecursos()
        {
            especialidades.Especialidades(cboEspecialidad);
            departamentos.Departamentos(cboDepartamento);

            gerencias.ListadoGerencias(cboGerencia);
            coorespecialidad.ListaEspecialista(cboCoorEspecialidad);


        }

        public void CopiarCarpetas()
        {
            string corto = txtNombreCorto.Text;
            int indice = 0;
            indice = corto.LastIndexOf(" ");
            string reemplazar = "_";
            string resultado = "";

            resultado = corto.Replace(" ", reemplazar);

            string folderName = @"C:\GONSAD";
            string pathString = System.IO.Path.Combine(folderName, resultado);
            System.IO.Directory.CreateDirectory(pathString);

            //string fileName = "log.txt";
            string sourcePath = @"C:\GONSAD\modelo";
            string targetPath = @"C:\GONSAD\"+resultado;

            computer.FileSystem.CopyDirectory(sourcePath, targetPath, true);
            
            // Keep console window open in debug mode.
            MessageBox.Show("Listo!!!.   La Carpeta ya fue inicializada con los archivos del Modelo.");
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Dispose();
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            especialidades.InfoEspecialidades(cboEspecialidad, txtIdEspecialidad);
            
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamentos.InfoDepartamentos(cboDepartamento, txtIdDepartamento);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CProvincias provincias= new CProvincias();
            provincias.SelectProvincia(cboProvincia, txtIdProvincia);
        }

     
        private void btncargarProvincias_Click(object sender, EventArgs e)
        {
            // Llena el combo provincias
            cboProvincia.Items.Clear();
            string codigo = txtIdDepartamento.Text;
            provincias.ListadoProvincias(codigo, cboProvincia);
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDistritos distri = new CDistritos();
            distri.SelectDistrito(cboDistrito, txtIdDistrito);
        }

        private void btnCargdist_Click(object sender, EventArgs e)
        {
            string codprovincia = txtIdProvincia.Text;
            CDistritos distri = new CDistritos();
            distri.ListaDistritos(codprovincia, cboDistrito);
        }

       
        private void iconButton1_Click(object sender, EventArgs e)
        {
            CProyectos proy = new CProyectos();
            proy.GuardarProyecto(txtNombreProyecto.Text, txtNombreCorto.Text, txtCui.Text, cboDepartamento.Text, cboProvincia.Text, cboDistrito.Text, txtidpersonal.Text, txtobservaciones.Text, cboEspecialidad.Text, txtIdGerencia.Text, txtIdCoordinadorGeneral.Text, txtCoordinadorEspecialidad.Text, txtCliente.Text, txtplazo.Text, "");

            CopiarCarpetas();

            iconButton1.Enabled = false;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btncargarProvincias_Click_1(object sender, EventArgs e)
        {
            string codDepartamento = txtIdDepartamento.Text;
            

            try
            {
                string consulta = "SELECT Cod_pvi, Des_pvi FROM provincias WHERE Cod_dpt = '" + codDepartamento + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboProvincia.Items.Add(reader.GetString(1));
                }
                reader.Close();

                conn.CerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: " + e.ToString());
                throw;
            }

        }

        private void cboDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            departamentos.InfoDepartamentos(cboDepartamento, txtIdDepartamento);
            btncargarProvincias_Click(this, null);
        }

        private void cboProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboDistrito.Items.Clear();
            provincias.InfoProvincias(cboProvincia, txtIdProvincia);
            btnCargdist_Click(this, null);
        }

        private void btnCargdist_Click_1(object sender, EventArgs e)
        {
            string codProvincia = txtIdProvincia.Text;
            MessageBox.Show(codProvincia);

            try
            {
                string consulta = "SELECT Des_dst FROM distritos WHERE Cod_pvi = '" + codProvincia + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboDistrito.Items.Add(reader.GetString(0));
                }
                reader.Close();

                conn.CerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: " + e.ToString());
                throw;
            }
        }

        private void cboDistrito_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            distritos.InfoDistrito(cboDistrito, txtIdDistrito);
        }

        private void cboEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            especialidades.InfoEspecialidades(cboEspecialidad, txtIdEspecialidad);
        }

        private void cboGerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            gerencias.InfoGerencias(cboGerencia, txtIdGerencia, txtNomGerencia);
            cboCoorGeneral.Items.Clear();
            button1_Click(this, null);
        }

        private void cboCoorGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdGerencia = txtIdGerencia.Text;
            general.InfoGerencias(cboCoorGeneral, txtIdCoordinadorGeneral, txtCoordinadorGeneral);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            general.ListaCoordinadorGeneral(cboCoorGeneral, txtIdGerencia);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cboCoorEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            coorespecialidad.InfoEspecialista(cboCoorEspecialidad, txtIdCoordinadorEspecialidad, txtCoordinadorEspecialidad);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }
    }
}
