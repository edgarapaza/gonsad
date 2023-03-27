using System;
using System.Windows.Forms;


namespace GonsadSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String usuario = txtusuario.Text;
            String passwd = txtpassword.Text;

            Validacion login = new Validacion();

            int res = login.Validar(usuario, passwd);

            if (res == 1)
            {
                this.Hide();
                Dashboard das = new Dashboard();
                das.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no son los correctos");
                txtusuario.Text = "";
                txtpassword.Text = "";
                txtusuario.Focus();
            }
        }
    }
}
