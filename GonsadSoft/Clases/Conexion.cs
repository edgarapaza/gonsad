﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GonsadSoft.Clases
{
    class Conexion
    {
           
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "gonsad";
        static string usuario = "usuario";
        static string passwd = "archivo123$"; 
        static string puerto ="3306";

        string cadenaConexion = "Database=" + db + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + passwd + "; Port=" + puerto + ";";
        public MySqlConnection Conectar()
        {
            
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Conexion exitosa");
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }

            return conex;
        }
    
       public void CerrarConexion()
       {
            conex.Close();
       }


    }
}
