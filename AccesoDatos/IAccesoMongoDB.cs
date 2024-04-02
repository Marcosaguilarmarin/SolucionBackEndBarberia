using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public interface IAccesoMongoDB
    {
        bool AgregarUsuario(Usuarios P_Entidad);
        bool ModificarUsuario(Usuarios P_Entidad);
        bool EliminarUsuario(Usuarios P_Entidad);
        List<Usuarios> ConsultarUsuarios(Usuarios P_Entidad);

    }
}
