using GonsadSoft.Clases;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GonsadSoft
{
    public partial class NewProyecto : Form
    {
        Conexion conn = new Conexion();
        Computer computer = new Computer();

        public NewProyecto()
        {
            InitializeComponent();

            

            int total = 0;
            try
            {
                string consulta = "SELECT count(*) as total FROM proynew;";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int t = Int32.Parse(reader.GetString(0));
                    total = t + 1;
                    
                }

                Console.WriteLine(total.ToString());

                txtCodigo.Text = total.ToString();
                txtCodigo.Enabled = false;

                reader.Close();
                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NewProyecto_Load(object sender, EventArgs e)
        {
            
        }

        public void Guardar()
        {
            string idpersonal = "1001";
            string nombre = txtProyecto.Text.ToUpper().Trim();
            string corto = txtCorto.Text.ToUpper().Trim();

            string date = DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss");

            try
            {
                string consulta = "INSERT INTO proynew VALUES (null,'" + nombre + "','" + corto + "','" + idpersonal + "','"+ date + "');";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("Guardado con exito");
                reader.Close();
                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar :" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomproyecto = txtProyecto.Text.ToUpper().Trim();
            string nomcorto = txtCorto.Text.ToUpper().Trim();

            if(nomproyecto== "")
            {
                MessageBox.Show("El campo NOMBRE DEL PROYECTO esta VACIO!");
            }
            else
            {
                if (nomcorto == "")
                {
                    MessageBox.Show("El campo NOMBRE CORTO esta VACIO!");
                }
                else
                {
                    
                    Guardar();
                    CopiarCarpetas();

                    MessageBox.Show("Por favor espere, se esta creando las carpetas y archivos al nuevo proyecto");

                }

            }

            

        }

        public void CopiarCarpetas()
        {
            string corto = txtCorto.Text.ToUpper().Trim();
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
            string targetPath = @"C:\GONSAD\" + resultado;

            computer.FileSystem.CopyDirectory(sourcePath, targetPath, true);

            // Keep console window open in debug mode.
            MessageBox.Show("Listo!!!.   La Carpeta ya fue inicializada con los archivos del Modelo.");


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string nomproyecto = txtProyecto.Text.ToUpper().Trim();
            string nomcorto = txtCorto.Text.ToUpper().Trim();

            if (nomproyecto == "")
            {
                MessageBox.Show("El campo NOMBRE DEL PROYECTO esta VACIO!");
            }
            else
            {
                if (nomcorto == "")
                {
                    MessageBox.Show("El campo NOMBRE CORTO esta VACIO!");
                }
                else
                {

                    Guardar();
                    CopiarCarpetas();

                    MessageBox.Show("Por favor espere, se esta creando las carpetas y archivos al nuevo proyecto");

                }

            }
        }
    }
}
