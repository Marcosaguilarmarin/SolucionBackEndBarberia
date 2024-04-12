using System;
using MongoDB.Driver;
using MongoDB.Bson;
using Entidades;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class AccesoMongoDB : IAccesoMongoDB
    {
        #region Atributos

        private readonly string CadenaConexion = @"mongodb://localhost:27017/";
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

        #region Usuarios

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

        #region Appointments
        /// <summary>
        /// Metodo para agregar Appointments
        /// </summary>
        /// <param name="P_Entidad">Entidad Appointments</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarAppointments(Appointments P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Appointments>("Appointments");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Appointments
        /// </summary>
        /// <param name="P_Entidad">Entidad Appointments</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarAppointments(Appointments P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Appointments>("Appointments");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Appointments
        /// </summary>
        /// <param name="P_Entidad">Entidad Appointments</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarAppointments(Appointments P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Appointments>("Appointments");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Appointments de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Appointments</param>
        /// <returns>Entidad lista de tipo Appointments</returns>
        public List<Appointments> ConsultarAppointments(Appointments P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Appointments>("Appointments");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.Id))
                    return Coleccion.Find(d => d.Id == P_Entidad.Id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }


        #endregion
        #region Clients
        /// <summary>
        /// Metodo para agregar Clients
        /// </summary>
        /// <param name="P_Entidad">Entidad Clients</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarClients(Clients P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Clients>("Clients");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Clients
        /// </summary>
        /// <param name="P_Entidad">Entidad Clients</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarClients(Clients P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Clients>("Clients");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Clients
        /// </summary>
        /// <param name="P_Entidad">Entidad Clients</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarClients(Clients P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Clients>("Clients");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Clients de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Clients</param>
        /// <returns>Entidad lista de tipo Clients</returns>
        public List<Clients> ConsultarClients(Clients P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Clients>("Clients");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.Id))
                    return Coleccion.Find(d => d.Id == P_Entidad.Id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }


        #endregion

        #region Services

        /// <summary>
        /// Metodo para agregar Services
        /// </summary>
        /// <param name="P_Entidad">Entidad Services</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarServices(Services P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services>("Services");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Services
        /// </summary>
        /// <param name="P_Entidad">Entidad Services</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarServices(Services P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services>("Services");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Services
        /// </summary>
        /// <param name="P_Entidad">Entidad Services</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarServices(Services P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services>("Services");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Services de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Services</param>
        /// <returns>Entidad lista de tipo Services</returns>
        public List<Services> ConsultarServices(Services P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services>("Services");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.Id))
                    return Coleccion.Find(d => d.Id == P_Entidad.Id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }

        #endregion

        #region Services_Categories

        /// <summary>
        /// Metodo para agregar Services_Categories
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarServices_Categories(Services_Categories P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services_Categories>("Services_Categories");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Services_Categories
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarServices_Categories(Services_Categories P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services_Categories>("Services_Categories");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Services_Categories
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarServices_Categories(Services_Categories P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services_Categories>("Services_Categories");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Services de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Entidad lista de tipo Services_Categories</returns>
        public List<Services_Categories> ConsultarServices_Categories(Services_Categories P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Services_Categories>("Services_Categories");
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

        #region Employees
        /// <summary>
        /// Metodo para agregar Employees
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarEmployees(Employees P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees>("Employees");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Employees
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarEmployees(Employees P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees>("Employees");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Employees
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarEmployees(Employees P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees>("Employees");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Services de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Entidad lista de tipo Services_Categories</returns>
        public List<Employees> ConsultarEmployees(Employees P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees>("Employees");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.Id))
                    return Coleccion.Find(d => d.Id == P_Entidad.Id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }


        #endregion

        #region Employees_Schedule

        /// <summary>
        /// Metodo para agregar Employees_Schedule
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees_Schedule</param>
        /// <returns>Resultado de la operacion</returns>
        public bool AgregarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees_Schedule>("Employees_Schedule");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para modificar Employees_Schedule
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees_Schedule</param>
        /// <returns>Resultado de la operacion</returns>
        public bool ModificarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees_Schedule>("Employees_Schedule");
            Coleccion.ReplaceOne(d => d.Id == P_Entidad.Id, P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para eliminar Employees
        /// </summary>
        /// <param name="P_Entidad">Entidad Employees</param>
        /// <returns>Resultado de la operacion</returns>
        public bool EliminarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees_Schedule>("Employees_Schedule");
            Coleccion.DeleteOne(d => d.Id == P_Entidad.Id);
            LimpiarAtributosGlobales();
            return true;
        }
        /// <summary>
        /// Metodo para consultar Services de base de datos
        /// </summary>
        /// <param name="P_Entidad">Entidad Services_Categories</param>
        /// <returns>Entidad lista de tipo Services_Categories</returns>
        public List<Employees_Schedule> ConsultarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            ObtenerConexion();

            var Coleccion = BaseDatos.GetCollection<Employees_Schedule>("Employees_Schedule");
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
