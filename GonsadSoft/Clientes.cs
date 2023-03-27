using GonsadSoft.Clases;
using GonsadSoft.Proyectos;
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
    public partial class Clientes : Form
    {
        Conexion conn = new Conexion();
        CClientes clientes = new CClientes();

        public Clientes()
        {
            InitializeComponent();
            clientes.MostrarClientes(dgvClientes);
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clientes.Seleccionar(dgvClientes, txtIdCliente1, txtCliente1, txtRazonSocial1, txtRuc1);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            NuevoProyecto proy = new NuevoProyecto();
            proy.txtIdCliente.Text = txtIdCliente1.Text;
            proy.txtCliente.Text = txtCliente1.Text;
            proy.txtRazonSocial.Text = txtRazonSocial1.Text;
            proy.txtRuc.Text = txtRuc1.Text;

            proy.Show();
            Dispose();
        }
    }
}
