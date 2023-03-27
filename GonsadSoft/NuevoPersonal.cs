using GonsadSoft.Clases;
using System;
using System.Windows.Forms;

namespace GonsadSoft
{
    public partial class NuevoPersonal : Form
    {
        
        public NuevoPersonal()
        {
            InitializeComponent();
            Clases.CPersonal personal = new Clases.CPersonal();
            personal.MostrarPersonal(dgvPersonal);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CPersonal personal = new CPersonal();
            personal.SeleccionarPersonalCodigo(dgvPersonal, txtIdPersonal);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CPersonal personal = new CPersonal();
            personal.GuardarPersonal(txtnombre, txtapellidos, txtdni, txtsexo, txtdireccion, txttelefono, txtemail);

            personal.MostrarPersonal(dgvPersonal);
        }
    }
}
