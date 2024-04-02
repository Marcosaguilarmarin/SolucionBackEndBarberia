using System;
using MongoDB.Driver;
using MongoDB.Bson;
using Entidades;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class AccesoMongoDB
    {
        #region Atributos

        private readonly string CadenaConexion = @"mongodb://localhost:27017";
        private MongoClient InstanciaBD;
        private IMongoDatabase BaseDatos;
        private const string NombreBD = "BarberiaDB";

        #endregion

        #region Metodos

        #region Privados

        /// <summary>
        /// Metodo es para verificar la conexion a base de datos del MongoDB
        /// </summary>
        /// <returns></returns>
        private bool ObtenerConexion()
        {
            bool ConexionCorrecta = false;

            try
            {
                //Inicializar o asignar el objeto de InstanciaMongo
                InstanciaBD = new MongoClient(CadenaConexion);

                //Se inicializa el objeto o interfaz de conexion a la BD dentro de la instancia del MongoDb
                BaseDatos = InstanciaBD.GetDatabase(NombreBD);

                ConexionCorrecta = BaseDatos.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

            }
            catch (MongoException exMG)
            {
                throw exMG;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ConexionCorrecta;
        }
        private void LimpiarAtributosGlobales()
        {
            if (InstanciaBD != null)
                InstanciaBD = null;
            if (BaseDatos != null)
                BaseDatos = null;
        }

        #endregion

        #region Publicos

        /// <summary>
        /// Metodo para agregar usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad usuario</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarUsuario(Usuarios P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Usuarios>("Usuarios");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad usuario</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarUsuario(Usuarios P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Usuarios>("Usuarios");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad usuario</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarUsuario(Usuarios P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Usuarios>("Usuarios");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar usuarios de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad usuario</param>
        /// <returns>Entidad lista de tipo Usuarios</returns>
        public List<Usuarios> ConsultarUsuarios(Usuarios P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Usuarios>("Usuarios");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.Id))
                    return Coleccion.Find(d => d.Id == P_Entidad.Id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }

        #endregion

        #endregion

    }
}
