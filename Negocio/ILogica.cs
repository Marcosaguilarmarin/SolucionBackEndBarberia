using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface ILogica
    {
        bool AgregarUsuario(Usuarios P_Entidad);
        bool ModificarUsuario(Usuarios P_Entidad);
        bool EliminarUsuario(Usuarios P_Entidad);
        List<Usuarios> ConsultarUsuarios(Usuarios P_Entidad);

    }
}
