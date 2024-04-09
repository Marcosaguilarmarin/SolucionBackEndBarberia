using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public interface IAccesoMongoDB
    {
        #region Usuarios
        bool AgregarUsuario(Usuarios P_Entidad);
        bool ModificarUsuario(Usuarios P_Entidad);
        bool EliminarUsuario(Usuarios P_Entidad);
        List<Usuarios> ConsultarUsuarios(Usuarios P_Entidad);
        #endregion

        #region Appointments
        bool AgregarAppointments(Appointments P_Entidad);
        bool ModificarAppointments(Appointments P_Entidad);
        bool EliminarAppointments(Appointments P_Entidad);
        List<Appointments> ConsultarAppointments(Appointments P_Entidad);
        #endregion

        #region Clients
        bool AgregarClients(Clients P_Entidad);
        bool ModificarClients(Clients P_Entidad);
        bool EliminarClients(Clients P_Entidad);
        List<Clients> ConsultarClients(Clients P_Entidad);
        #endregion

    }
}
