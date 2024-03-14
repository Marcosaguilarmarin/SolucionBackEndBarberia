using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entities;
using System.Linq;

namespace AccesoDatos
{
    public class AccesoSQL : IAccesoSQL
    {

        #region Usuarios - tabla prueba

        public bool Agregar()
        {
            bool resultado = false;
            Context contexto = null;

            try
            {
                contexto = new ();
                contexto.Usuarios.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        public List<Usuarios> Consultar()
        {
            Context contexto = null;
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                contexto = new Context();

                if (String.IsNullOrEmpty(P_Entidad.NombreUsuario))
                {
                    var consulta = (from x in contexto.Usuarios
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.Usuarios
                                    where x.NombreUsuario.Equals(P_Entidad.NombreUsuario)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }
        public bool Eliminar(Usuarios P_Entidad)
        {
            bool resultado = false;
            HotelPrograContext contexto = null;

            try
            {
                contexto = new Context();
                var consulta = (from x in contexto.Usuarios
                                where x.NombreUsuario.Equals(P_Entidad.NombreUsuario)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.Usuarios.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        public bool Modificar(Usuarios P_Entidad)
        {
            bool resultado = false;
            Context contexto = null;

            try
            {
                contexto = new Context();
                var consulta = (from x in contexto.Usuarios
                                where x.NombreUsuario.Equals(P_Entidad.NombreUsuario)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.NombreUsuario = P_Entidad.NombreUsuario;
                    consulta.ApellidoUsuario = P_Entidad.ApellidoUsuario;
                    consulta.Contrasena = P_Entidad.Contrasena;
                    consulta.CorreoUsuario = P_Entidad.CorreoUsuario;
                    consulta.EstadoUsuario = P_Entidad.EstadoUsuario;
                    consulta.IdLogueo = P_Entidad.IdLogueo;
                    consulta.TelefonoUsuario = P_Entidad.TelefonoUsuario;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }