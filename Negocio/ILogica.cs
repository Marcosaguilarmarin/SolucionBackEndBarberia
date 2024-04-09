﻿using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface ILogica
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

        #region Services
        bool AgregarServices(Services P_Entidad);
        bool ModificarServices(Services P_Entidad);
        bool EliminarServices(Services P_Entidad);

        List<Services> ConsultarServices(Services P_Entidad);

        #endregion

        #region Services_Categories
        bool AgregarServices_Categories(Services_Categories P_Entidad);
        bool ModificarServices_Categories(Services_Categories P_Entidad);
        bool EliminarServices_Categories(Services_Categories P_Entidad);

        List<Services_Categories> ConsultarServices_Categories(Services_Categories P_Entidad);
        #endregion

    }
}
