using Microsoft.AspNetCore.Mvc;
using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/Seguridad")]
    [ApiController]
    public class SeguridadController : Controller
    {
        #region Atributos

        private readonly ILogica _ilogica;

        #endregion

        #region Constructor 

        public SeguridadController(ILogica P_Ilogica)
        {
            _ilogica = P_Ilogica;
        }


        #endregion

        #region Metodos 

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarUsuario))]
        public bool AgregarUsuario(Usuarios P_Entidad)
        {
            return _ilogica.AgregarUsuario(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarUsuario))]
        public bool ModificarUsuario(Usuarios P_Entidad)
        {
            return _ilogica.ModificarUsuario(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarUsuario))]
        public bool EliminarUsuario(Usuarios P_Entidad)
        {
            return _ilogica.EliminarUsuario(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuarios))]
        public IEnumerable<Usuarios> ConsultarUsuarios()
        {
            Usuarios u = new Usuarios();
            return _ilogica.ConsultarUsuarios(u).ToList();
        }


        #endregion 

    }
}

