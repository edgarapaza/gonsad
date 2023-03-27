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

namespace GonsadSoft
{
    public partial class AsignacionProyectos : Form
    {
        CEspecialista especialista = new CEspecialista();
        public AsignacionProyectos()
        {
            InitializeComponent();
            especialista.Especialistas(cboEspecialista);
        }

        public void ListaDepartamentos()
        {
            /*
            cboDepartamento.DataSource = new Operaciones().ObtenerDepartamento(codDepart);
            cboDepartamento.ValueMember = "codDepartamento";
            cboDepartamento.DisplayMember = "nombreDepartamento";
            */
            
        }
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CProyectos proyectos = new CProyectos();
            //proyectos.GuardarProyecto(txtNombreCompleto.Text, txtNombreCorto.Text, txtCui.Text, txtDepartamento.Text, txtProvincia.Text, txtDistrito.Text,txtIdPersonal.Text, txtObservaciones.Text);
            string nomcorto = txtNombreCorto.Text;

            // Specify a name for your top-level folder.
            string folderName = @"C:\GONSAD";
            string pathString = System.IO.Path.Combine(folderName, nomcorto);
            System.IO.Directory.CreateDirectory(pathString);
        }

        private void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            especialista.InfoEspecialistas(cboEspecialista, txtIdPersonal, txtNombre, txtDni, txtTelefono, txtEspecialidad, txtNumColegiatura);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CProyectos proyectos = new CProyectos();
            //proyectos.GuardarProyecto(txtNombreCompleto.Text, txtNombreCorto.Text, txtCui.Text, txtDepartamento.Text, txtProvincia.Text, txtDistrito.Text,txtIdPersonal.Text, txtObservaciones.Text);
            string nomcorto = txtNombreCorto.Text;

            // Specify a name for your top-level folder.
            string folderName = @"C:\GONSAD";
            string pathString = System.IO.Path.Combine(folderName, nomcorto);
            System.IO.Directory.CreateDirectory(pathString);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPersonal_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    
    }
}
