using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GonsadSoft.Clases
{
    internal class CPersonal
    {
        Conexion conn = new Conexion();

        public void MostrarPersonal(DataGridView tablaPersonal) {
            try {

             
                String consulta = "SELECT * FROM personal";
                tablaPersonal.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPersonal.DataSource = dt;
                conn.CerrarConexion();

            }
            catch(Exception e) {
                MessageBox.Show("No se pudo mostrar los datos. Error: " + e.ToString());
            }

        }

        public void GuardarPersonal(TextBox nombre, TextBox apellidos, TextBox dni, TextBox sexo, TextBox direccion, TextBox telefono, TextBox email)
        {
            try
            {
                

                string consulta = "INSERT INTO personal VALUES (null,'"+nombre.Text+"','"+apellidos.Text+"','"+dni.Text+"','"+sexo.Text+"','"+direccion.Text+"','"+telefono.Text+"','"+email.Text+"');";

                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Datos guardados satisfactoriamente");

                while(reader.Read()) { }

                conn.CerrarConexion();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error guardando"+e.ToString());
            }
        }

        public void SeleccionarPersonal(DataGridView tablaPersonal, 
            TextBox idpersonal, TextBox nombre, TextBox apellidos, 
            TextBox dni, TextBox sexo)
        {
            try
            {
                idpersonal.Text = tablaPersonal.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaPersonal.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tablaPersonal.CurrentRow.Cells[2].Value.ToString();
                dni.Text = tablaPersonal.CurrentRow.Cells[3].Value.ToString();
                sexo.Text = tablaPersonal.CurrentRow.Cells[4].Value.ToString();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Seleccionando. Error: " + e.ToString());
            }
        }

        public void SeleccionarPersonalCodigo(DataGridView tablaPersonal,TextBox idpersonal)
        {
            try
            {
                idpersonal.Text = tablaPersonal.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Seleccionando. Error: " + e.ToString());
            }
        }

        public void EliminarPersonal(TextBox idpersonal)
        {
            try
            {
               
                string consulta = "";

                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                
             
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error eliminando. Error: "+e.ToString());
            }
        }

        public void ModificarPersonal(TextBox idpersonal, TextBox nombre, TextBox apellidos,
            TextBox dni, TextBox sexo)
        {
            try
            {
             

                string consulta = "UPDATE personal SET nombre = '"+nombre.Text+"', apellidos = '"+apellidos.Text+"', dni = '"+dni.Text+"', sexo = '"+sexo.Text+"' WHERE idpersonal = '"+idpersonal.Text+"';";

                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("Actualizado corectamente");
               
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Actualizando. Error: " + e.ToString());
            }
        }

    }
}
