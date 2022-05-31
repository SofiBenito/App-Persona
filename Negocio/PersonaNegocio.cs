using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
  public  class PersonaNegocio
    {

        //funcion para mostar la persona 

        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SettearConsulta("select p.apellido apellido,p.nombres nombre,p.tipo_documento tipoDoc,t.n_tipo_documento nombreDoc,p.documento documento,p.estado_civil tipoEstado,e.n_estado_civil estadoCivil,p.sexo sexo,p.fallecio fallecio from personas p, tipo_documento t,estado_civil e where p.tipo_documento=t.id_tipo_documento and p.estado_civil=e.id_estado_civil and fallecio=0");

                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Persona persona = new Persona();
                    persona.Apellido = (string)datos.Lector["apellido"];
                    persona.Nombre = (string)datos.Lector["nombre"];

                    persona.TipoDocumento = new TipoDocumento();
                    persona.TipoDocumento.Id = (int)datos.Lector["tipoDoc"];
                    persona.TipoDocumento.Nombre = (string)datos.Lector["nombreDoc"];


                    persona.Documento = (int)datos.Lector["documento"];

                    persona.EstadoCivil = new EstadoCivil();
                    persona.EstadoCivil.Id = (int)datos.Lector["tipoEstado"];
                    persona.EstadoCivil.Nombre = (string)datos.Lector["estadoCivil"];


                    persona.Sexo = (int)datos.Lector["sexo"];
                    persona.Fallecio = (bool)datos.Lector["fallecio"];

                    lista.Add(persona);


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

        //funcion para agregar
        public void Agregar(Persona nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SettearConsulta("insert into personas(apellido,nombres,tipo_documento,documento,estado_civil,sexo,fallecio) values(@apellido,@nombres,@tipoDoc,@documento,@tipoEstado,@sexo,@fallecio)");
                datos.settearParametros("@apellido", nuevo.Apellido);
                datos.settearParametros("@nombres", nuevo.Nombre);
                datos.settearParametros("@tipoDoc", nuevo.TipoDocumento.Id);
                datos.settearParametros("@documento", nuevo.Documento);
                datos.settearParametros("@tipoEstado", nuevo.EstadoCivil.Id);
                datos.settearParametros("@sexo", nuevo.Sexo);
                datos.settearParametros("@fallecio", nuevo.Fallecio);

                datos.EjecutarAccion();



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

        //funcion para modificar

        public void Modificar(Persona modificar)
        {
            AccesoDatos datos=new AccesoDatos();

            try
            {

                datos.SettearConsulta("update personas set apellido = @apellido,nombres=@nombres,tipo_documento=@tipoDoc,estado_civil=@tipoEstado,sexo=@sexo,fallecio=@fallecio where documento=@documento");
                datos.settearParametros("@apellido",modificar.Apellido);
                datos.settearParametros("@nombres",modificar.Nombre);
                datos.settearParametros("@tipoDoc",modificar.TipoDocumento.Id);
                datos.settearParametros("@tipoEstado",modificar.EstadoCivil.Id);
                datos.settearParametros("@sexo",modificar.Sexo);
                datos.settearParametros("@fallecio",modificar.Fallecio);
                datos.settearParametros("@documento", modificar.Documento);

                datos.EjecutarAccion();



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

        //funcion para eliminar 
        public void Eliminar(int documento)//clave primaria de la tabla
        {
            AccesoDatos datos =new AccesoDatos();
            try
            {
                datos.SettearConsulta("delete from personas where documento = @documento");
                datos.settearParametros("@documento", documento);

                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //funcion para eliminar logico
        public void eliminarLogico(int documento)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SettearConsulta("update personas set fallecio= 1 where documento=@documento");
                datos.settearParametros("@documento", documento);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }

}
