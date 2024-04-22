using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Logica : ILogica
    {
        #region Atributo

        private readonly IAccesoMongoDB _iaccesomongbd;

        #endregion

        #region Constructor 

        public Logica(IAccesoMongoDB P_IAccesomongobd)
        {
            _iaccesomongbd = P_IAccesomongobd;
        }

        #endregion

        #region Metodos

        #region Usuarios
        public bool AgregarUsuario(Usuarios P_Entidad)
        {
            return _iaccesomongbd.AgregarUsuario(P_Entidad);
        }
        public List<Usuarios> ConsultarUsuarios(Usuarios P_Entidad)
        {
            return _iaccesomongbd.ConsultarUsuarios(P_Entidad);
        }
        public bool EliminarUsuario(Usuarios P_Entidad)
        {
            return _iaccesomongbd.EliminarUsuario(P_Entidad);
        }
        public bool ModificarUsuario(Usuarios P_Entidad)
        {
            return _iaccesomongbd.ModificarUsuario(P_Entidad);
        }
        #endregion

        #region Appointments
        public bool AgregarAppointments(Appointments P_Entidad)
        {
            return _iaccesomongbd.AgregarAppointments(P_Entidad);
        }
        public List<Appointments> ConsultarAppointments(Appointments P_Entidad)
        {
            return _iaccesomongbd.ConsultarAppointments(P_Entidad);
        }
        public bool EliminarAppointments(Appointments P_Entidad)
        {
            return _iaccesomongbd.EliminarAppointments(P_Entidad);
        }
        public bool ModificarAppointments(Appointments P_Entidad)
        {
            return _iaccesomongbd.ModificarAppointments(P_Entidad);
        }
        #endregion

        #region Clients
        public bool AgregarClients(Clients P_Entidad)
        {
            return _iaccesomongbd.AgregarClients(P_Entidad);
        }
        public List<Clients> ConsultarClients(Clients P_Entidad)
        {
            return _iaccesomongbd.ConsultarClients(P_Entidad);
        }
        public bool EliminarClients(Clients P_Entidad)
        {
            return _iaccesomongbd.EliminarClients(P_Entidad);
        }
        public bool ModificarClients(Clients P_Entidad)
        {
            return _iaccesomongbd.ModificarClients(P_Entidad);
        }
        #endregion

        #region Services

        public bool AgregarServices(Services P_Entidad)
        {
            return _iaccesomongbd.AgregarServices(P_Entidad);
        }
        public List<Services> ConsultarServices(Services P_Entidad)
        {
            return _iaccesomongbd.ConsultarServices(P_Entidad);
        }
        public bool EliminarServices(Services P_Entidad)
        {
            return _iaccesomongbd.EliminarServices(P_Entidad);
        }
        public bool ModificarServices(Services P_Entidad)
        {
            return _iaccesomongbd.ModificarServices(P_Entidad);
        }

        #endregion

        #region Services_Categories
        public bool AgregarServices_Categories (Services_Categories P_Entidad) 
        {
            return _iaccesomongbd.AgregarServices_Categories(P_Entidad);        
        }
        public List<Services_Categories> ConsultarServices_Categories (Services_Categories P_Entidad)
        {
            return _iaccesomongbd.ConsultarServices_Categories(P_Entidad);
        }
        public bool EliminarServices_Categories (Services_Categories P_Entidad)
        {
            return _iaccesomongbd.EliminarServices_Categories(P_Entidad);
        }
        public bool ModificarServices_Categories (Services_Categories P_Entidad)
        {
            return _iaccesomongbd.ModificarServices_Categories(P_Entidad);
        }
        #endregion

        #region Employees
        public bool AgregarEmployees(Employees P_Entidad)
        {
            return _iaccesomongbd.AgregarEmployees(P_Entidad);
        }
        public List<Employees> ConsultarEmployees (Employees P_Entidad)
        {
            return _iaccesomongbd.ConsultarEmployees(P_Entidad);
        }
        public bool EliminarEmployees (Employees P_Entidad)
        {
            return _iaccesomongbd.EliminarEmployees(P_Entidad);
        }
        public bool ModificarEmployees (Employees P_Entidad)
        {
            return _iaccesomongbd.ModificarEmployees(P_Entidad);
        }
        #endregion

        #region Employees_Schedule

        public bool AgregarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _iaccesomongbd.AgregarEmployees_Schedule(P_Entidad);
        }
        public List<Employees_Schedule> ConsultarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _iaccesomongbd.ConsultarEmployees_Schedule(P_Entidad);
        }
        public bool EliminarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _iaccesomongbd.EliminarEmployees_Schedule(P_Entidad);
        }
        public bool ModificarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _iaccesomongbd.ModificarEmployees_Schedule(P_Entidad);
        }

        #endregion

        #region PerfilesXusuarios
        public bool AgregarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _iaccesomongbd.AgregarPerfilesXusuarios(P_Entidad);
        }
        public List<PerfilesXusuarios> ConsultarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _iaccesomongbd.ConsultarPerfilesXusuarios(P_Entidad);
        }
        public bool EliminarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _iaccesomongbd.EliminarPerfilesXusuarios(P_Entidad);
        }
        public bool ModificarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _iaccesomongbd.ModificarPerfilesXusuarios(P_Entidad);
        }
        #endregion

        #region Perfiles
        public bool AgregarPerfiles(Perfiles P_Entidad)
        {
            return _iaccesomongbd.AgregarPerfiles(P_Entidad);
        }
        public List<Perfiles> ConsultarPerfiles(Perfiles P_Entidad)
        {
            return _iaccesomongbd.ConsultarPerfiles(P_Entidad);
        }
        public bool EliminarPerfiles(Perfiles P_Entidad)
        {
            return _iaccesomongbd.EliminarPerfiles(P_Entidad);
        }
        public bool ModificarPerfiles(Perfiles P_Entidad)
        {
            return _iaccesomongbd.ModificarPerfiles(P_Entidad);
        }
        #endregion

        #region Services_Booked
        public bool AgregarServices_Booked(Services_Booked P_Entidad)
        {
            return _iaccesomongbd.AgregarServices_Booked(P_Entidad);
        }
        public List<Services_Booked> ConsultarServices_Booked(Services_Booked P_Entidad)
        {
            return _iaccesomongbd.ConsultarServices_Booked(P_Entidad);
        }
        public bool EliminarServices_Booked(Services_Booked P_Entidad)
        {
            return _iaccesomongbd.EliminarServices_Booked(P_Entidad);
        }
        public bool ModificarServices_Booked(Services_Booked P_Entidad)
        {
            return _iaccesomongbd.ModificarServices_Booked(P_Entidad);
        }
        #endregion


        #endregion
    }
}
