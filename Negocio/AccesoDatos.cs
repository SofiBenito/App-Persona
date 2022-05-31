using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        //atributos 
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        //propiedad para el lector
        public SqlDataReader Lector
        {
            get { return lector; }  
        }
        //constructor para inicializarlos

        public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=TUPPI;Integrated Security=True");
            comando = new SqlCommand();         
        }

        //seteamos consultas para que los insert, update y delete y le pasamos por parametros
        //un string que es la consulta 

        public void SettearConsulta(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText = consulta;   
        }

        //seteamos parametros de carga de las consultas 

        public void settearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);         
        }
        //ejecutamos consulta de lectura para el data grip view

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();    
                lector= comando.ExecuteReader();        

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //metodo para ejecutar accion de carga en una consulta 

        public void EjecutarAccion()
        {
            comando.Connection=conexion;    
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();  

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //metodo para cerrar conexion 

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();       
        }

    }
}
