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

        #region Usuarios

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

        #region Appointments
        [HttpPost]
        [Route(nameof(AgregarAppointments))]
        public bool AgregarAppointments(Appointments P_Entidad)
        {
            return _ilogica.AgregarAppointments(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarAppointments))]
        public bool ModificarAppointments(Appointments P_Entidad)
        {
            return _ilogica.ModificarAppointments(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarAppointments))]
        public bool EliminarAppointments(Appointments P_Entidad)
        {
            return _ilogica.EliminarAppointments(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarAppointments))]
        public IEnumerable<Appointments> ConsultarAppointments()
        {
            Appointments u = new Appointments();
            return _ilogica.ConsultarAppointments(u).ToList();
        }
        #endregion

        #region Clients
        [HttpPost]
        [Route(nameof(AgregarClients))]
        public bool AgregarClients(Clients P_Entidad)
        {
            return _ilogica.AgregarClients(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarClients))]
        public bool ModificarClients(Clients P_Entidad)
        {
            return _ilogica.ModificarClients(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarClients))]
        public bool EliminarClients(Clients P_Entidad)
        {
            return _ilogica.EliminarClients(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarClients))]
        public IEnumerable<Clients> ConsultarClients()
        {
            Clients u = new Clients();
            return _ilogica.ConsultarClients(u).ToList();
        }
        #endregion




        #endregion

    }
}

