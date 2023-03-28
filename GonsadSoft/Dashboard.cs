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
    public partial class Dashboard : Form
    {
        private Form currentChildForm;
        public Dashboard()
        {
            InitializeComponent();
        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void btnAcciones_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoPersonal nper = new NuevoPersonal();
            nper.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NuevoProyecto());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListadoProyectos());
            
        }

        private void calculoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TablaArchivos());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NuevoPersonal());
        }

        private void btnListadoProyectos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SendFiles());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new test1());
        }
    }
}
