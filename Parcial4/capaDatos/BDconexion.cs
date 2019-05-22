using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;



namespace capaDatos
{
    public class BDconexion
    {
        String cadena = "Data Source=localhost;Initial Catalog=hospital;Persist Security Info=True;User ID=admin;Password=123";
        SqlDataAdapter adaptador;
        public SqlDataAdapter da;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public bool conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
                conn = true;

            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }

        public void Desconectar()
        {
            conexion.Close();
        }


        public void cosultaSql(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";
            }
            catch (Exception es)
            {
                mensaje = "Error";
            }
        }

        public void mostrarSql(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                da = new SqlDataAdapter(comando);
                mensaje = "Correctamente";
            }
            catch
            {
                mensaje= "Error";
            }
        }
        
    }
}
