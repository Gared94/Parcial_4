using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data;


namespace capaPresentacion
{
    public class manttHospital
    {
        BDconexion bd = new BDconexion();
        private int hospital, ncama;

        public int Ncama
        {
            get { return ncama; }
            set { ncama = value; }
        }

        public int Hospital
        {
            get { return hospital; }
            set { hospital = value; }
        }
        private string nombre, direccion, telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DataTable dt = new DataTable();

        public void insertarHospital()
        {
            try
            {
                string insertar = "INSERT INTO HOSPITAL VALUES('" + hospital + "','" + nombre + "', '" + direccion + "', '" + telefono + "', '" + ncama + "')";
                bd.conectar();
                bd.cosultaSql(insertar);
                bd.Desconectar();
            }
            catch
            {

            }
           
        }


        public void modificarHospital()
        {
            try
            {
                string modificar = "UPDATE HOSPITAL SET nombre = '"+nombre+"' where Hospital_cod = '"+hospital+"'";
                bd.conectar();
                bd.cosultaSql(modificar);
                bd.Desconectar();
            }
            catch
            {

            }

        }

        public void borrarHospital()
        {
            try
            {
                string borrar = "DELETE HOSPITAL where Hospital_cod = '" + hospital + "'";
                bd.conectar();
                bd.cosultaSql(borrar);
                bd.Desconectar();
            }
            catch
            {

            }

        }

        public string prueba()
        {
            String mensaje;
            if(bd.conectar()==true)
            {
                bd.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                bd.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;
        }
        public object da { get; set; }
    }
}
