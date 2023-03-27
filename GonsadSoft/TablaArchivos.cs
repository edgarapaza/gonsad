using GonsadSoft.Clases;
using MySql.Data.MySqlClient;
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
    public partial class TablaArchivos : Form
    {
        Conexion conn = new Conexion();

        public TablaArchivos()
        {
            InitializeComponent();
            Desactivar();
            CalculosProyecto();

           
        }
        public void LlenarDatos()
        {
            try
            {
                string consulta = "SELECT idactivades,item,dias,parcial,estadia,subtotal FROM activades WHERE idproyecto = 1;";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta, conn.Conectar());
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dgvArchivo.DataSource = dataTable;

                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la data. Error : " + ex.ToString());
            }
        }
        private void TablaArchivos_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void dgvArchivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtiditem.Text = dgvArchivo.SelectedCells[0].Value.ToString();
            txtitem.Text = dgvArchivo.SelectedCells[1].Value.ToString();
            txtdias.Text = dgvArchivo.SelectedCells[2].Value.ToString();
            txtparcial.Text = dgvArchivo.SelectedCells[3].Value.ToString();
            txtestadia.Text = dgvArchivo.SelectedCells[4].Value.ToString();
            txttotal.Text = dgvArchivo.SelectedCells[5].Value.ToString();

            Activar();
            btnGuardar.Visible = false;
            
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
        }

        public void Limpiar()
        {
            txtiditem.Text = "";
            txtitem.Text = "";
            txtdias.Text = "";
            txtparcial.Text = "";
            txtestadia.Text = "";
            txttotal.Text = "";
            txtitem.Focus();
        }

        public void Desactivar()
        {
            txtiditem.Enabled = false;
            txtitem.Enabled = false;
            txtdias.Enabled = false;
            txtparcial.Enabled = false;
            txtestadia.Enabled = false;
            txttotal.Enabled = false;

            btnGuardar.Enabled = false;
            btnGuardar.Visible= true;
            btnCalcularCostos.Enabled = false;

        }
        public void Activar()
        {
            txtiditem.Enabled = false;
            txtitem.Enabled = true;
            txtdias.Enabled = true;
            txtparcial.Enabled = false;
            txtestadia.Enabled = false;
            txttotal.Enabled = false;

            btnGuardar.Enabled = false;
            btnGuardar.Visible = true;
            btnCalcularCostos.Enabled = false;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        public void CalculosProyecto()
        {
            // Suma del total Bruto
            double sumTotal = Convert.ToDouble(txtliquido.Text) + Convert.ToDouble(txtalojamiento.Text);
            double sumTotalR = Math.Round(sumTotal, 2);
            txtbruto.Text = sumTotalR.ToString();

            //  Calculo de los Valores diarios
            double liqDiario = Convert.ToDouble(txtliquido.Text) / 30;
            double liqDiarioR = Math.Round(liqDiario,2);
            txtLiquidoDiario.Text = liqDiarioR.ToString();

            double alojDiario = Convert.ToDouble(txtalojamiento.Text) / 30;
            double alojDiarioR = Math.Round(alojDiario, 2);
            txtAlojamientoDiario.Text = alojDiarioR.ToString();

            double brutoDiario = Convert.ToDouble(txtLiquidoDiario.Text) + Convert.ToDouble(txtAlojamientoDiario.Text);
            double brutoDiarioR = Math.Round(brutoDiario, 2);
            txtSueldoDiario.Text = brutoDiarioR.ToString();

            
        }

        public void CalculoCostosItem()
        {
            double dias = Convert.ToDouble(txtdias.Text);
            double parcial = Convert.ToDouble(txtLiquidoDiario.Text);
            double estadia = Convert.ToDouble(txtAlojamientoDiario.Text);
            double bruto = Convert.ToDouble(txtSueldoDiario.Text);

            double totalParcial = dias * parcial;
            double totalEstadia = dias * estadia;
            double totalCosto = totalParcial + totalEstadia;

            double totalParcialR = Math.Round(totalParcial, 2);
            double totalEstadiaR = Math.Round(totalEstadia, 2);
            double totalCostoR = Math.Round(totalCosto, 2);

            txtparcial.Text = totalParcialR.ToString();
            txtestadia.Text = totalEstadiaR.ToString();
            txttotal.Text = totalCostoR.ToString();
        }

        private void btnCalcularCostos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnCalcularCostos_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CalculosProyecto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CActividades actividades = new CActividades();
            if (txtitem.Text == "")
            {
                MessageBox.Show("La Casilla DESCRIPCION del item esta vacia");
            }
            else
            {
                if (txtdias.Text == "")
                {
                    MessageBox.Show("La caja DIAS esta vacia");
                }
                else
                {
                    if (txtparcial.Text == "")
                    {
                        MessageBox.Show("La caja PARCIAL esta vacia");
                    }
                    else
                    {
                        actividades.Guardar(txtitem.Text, txtdias.Text, txtparcial.Text, txtestadia.Text, txttotal.Text, lblCodigoProyecto.Text);
                        LlenarDatos();

                        btnGuardar.Visible = true;
                        

                        Desactivar();
                    }
                }
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Limpiar();
            Activar();

            btnGuardar.Enabled = true;
           
            btnCalcularCostos.Enabled = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Limpiar();
            Desactivar();
            btnGuardar.Enabled = false;
            btnGuardar.Visible = true;
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CalculoCostosItem();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            CalculoCostosItem();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            CActividades actividades = new CActividades();
            actividades.Modificar(txtiditem.Text, txtitem.Text, txtdias.Text, txtparcial.Text, txtestadia.Text, txttotal.Text);
            LlenarDatos();

            btnGuardar.Visible = false;
            

            Limpiar();
            Desactivar();
           
        }
    }
}
