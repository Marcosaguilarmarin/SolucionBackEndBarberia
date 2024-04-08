using Entidades;
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

    }
}
