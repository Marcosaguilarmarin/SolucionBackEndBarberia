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


        #endregion
    }
}
