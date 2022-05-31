using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EstadoCivilNegocio
    {
        //metodo para mostar en el lector el tipo de estado

       public List<EstadoCivil>listar()
        {
            List<EstadoCivil> lista = new List<EstadoCivil>();      
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SettearConsulta("select id_estado_civil,n_estado_civil from estado_civil");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    EstadoCivil estado = new EstadoCivil();
                    estado.Id = (int)datos.Lector["id_estado_civil"];
                    estado.Nombre = (string)datos.Lector["n_estado_civil"];
                    //agregamos el estado a la lista
                    lista.Add(estado);



                }
                return lista;           

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();     
            }







        }






    }
}
