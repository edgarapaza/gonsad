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
    public partial class ListadoProyectos : Form
    {
        Conexion conn = new Conexion();

        public static List<Nodo> nodos;
        //public static List<Elemento> elementos;
        public DataSet dtsN = null;

        public ListadoProyectos()
        {
            InitializeComponent();

            CargarDatosSQL();

        }

        public void CargarDatosSQL()
        {
            try
            {
                dtsN = CargaNodosSQL();
                CrearNododelPadre(0, null);
                treeProyectos.ExpandAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.ToString());
            }

        }
        public DataSet CargaNodosSQL()
        {
            DataSet dts = new DataSet();

            try
            {
                string consulta = "SELECT * FROM categorias";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn.Conectar());
                da.Fill(dts, "categorias");

                conn.CerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando listado de nodos" + e.ToString());
            }
            finally
            {
                conn.CerrarConexion();
            }

            return dts;
        }

        public void CrearNododelPadre(int indicePadre, TreeNode nodoPadre)
        {
            // Crear un DataView con los nodos que dependen del nodo padre pasado como parametro
            DataView dataviewHijos = new DataView(dtsN.Tables["categorias"]);
            dataviewHijos.RowFilter = dtsN.Tables["categorias"].Columns["nodoPadre"].ColumnName + " = " + indicePadre;

            // Agregar al Treeview los nodos hijos que se ha  obtenido
            foreach (DataRowView dataRowCurrent in dataviewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["nombre"].ToString().Trim();  // dato a mostrar
                nuevoNodo.Name = dataRowCurrent["nodo"].ToString().Trim();    // valor guardado en el nombre

                // Si el parametro nodoPadre es nulo, es poeque es la primera llamada, son los nodos
                // del primer nivel que no dependen de otro nodo
                if (nodoPadre == null)
                {
                    treeProyectos.Nodes.Add(nuevoNodo);
                }
                else
                {
                    nodoPadre.Nodes.Add(nuevoNodo);   //  Se añade el nuevo al nodo del padre
                }

                //  Llamada recurrente al mismo metodo para agregar los hijos del nodo Recien agregado
                CrearNododelPadre(Int32.Parse(dataRowCurrent["nodo"].ToString()), nuevoNodo);
            }
        }

        public void cargaElementos(string nodo)
        {
            /*
            try
            {
                // Limpiar la lista de elementos
                lstproy.Items.Clear();
                //  Cargar la lista de elementos cuando usamos SQL
                DataRow[] elements = dtsN.Tables["elementos"].Select("nodo=" + nodo.Trim());

                foreach (DataRow _elemento in elements)
                {
                    // Si pertenece al nodo seleccionado lo añadimos al listbox
                    lstproy.Items.Add(_elemento["elemento"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro cargando Elementos: " + e.ToString());
                
            }
            */



        }

        private void listadoDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaArchivos tablaArchivos = new TablaArchivos();
            tablaArchivos.MdiParent = this;
            tablaArchivos.Show();
        }


        private void treeProyectos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string n = "";
            try
            {
                // Recuperamos el nodo seleccionado
                n = treeProyectos.SelectedNode.Name.Trim();

                // Cargamos los nodos
                CargarArchivos(n);

            }
            catch (Exception)
            {
                MessageBox.Show("Error cargando " + e.ToString());
                throw;
            }
        }


        public void CargarArchivos(string codnodo = "%")
        {
            string ruta2 = null;

            try
            {
                string consulta = "SELECT ruta FROM categorias WHERE nodo = " + codnodo;
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ruta2 = reader.GetString(0);
                }
                conn.CerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Sin archivos que mostrar");
            }

            dgvFiles.Rows.Clear();
            dgvFiles.Columns.Clear();
            dgvFiles.Columns.Add("Archivo", "Archivo");
            dgvFiles.Columns[0].Width = 800;

            //MessageBox.Show("Nombre de cArpeta: " + ruta);

            string[] files = Directory.GetFiles(@ruta2);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                dgvFiles.Rows.Add(file);
            }

            string[] folders = Directory.GetDirectories(@ruta2);
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
                dgvFiles.Rows.Add("> " + folder);
            }

        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dgvFiles.CurrentRow.Cells[0].Value.ToString();
            Process.Start(Nombre);
        }

        private void eliminarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProyecto nuevoProyecto = new NuevoProyecto();
            nuevoProyecto.ShowDialog();
        }

        private void duplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProyecto frm = new NewProyecto();
            frm.ShowDialog();
        }
    }

}
