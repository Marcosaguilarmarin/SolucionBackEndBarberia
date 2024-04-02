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

        #region Metodos Usuarios
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
    }
}
