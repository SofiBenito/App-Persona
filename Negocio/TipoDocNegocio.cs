using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TipoDocNegocio
    {
        //metodo para la lectura de los tipos de documentos
        public List<TipoDocumento> listar()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SettearConsulta("select id_tipo_documento,n_tipo_documento from tipo_documento");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    TipoDocumento Documento = new TipoDocumento();
                    Documento.Id = (int)datos.Lector["id_tipo_documento"];
                    Documento.Nombre = (string)datos.Lector["n_tipo_documento"];
                    //agregamos el estado a la lista
                    lista.Add(Documento);



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
