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

        #region Services 

        [HttpPost]
        [Route(nameof(AgregarServices))]
        public bool AgregarServices(Services P_Entidad)
        {
            return _ilogica.AgregarServices(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarServices))]
        public bool ModificarServices(Services P_Entidad)
        {
            return _ilogica.ModificarServices(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarServices))]
        public bool EliminarServices(Services P_Entidad)
        {
            return _ilogica.EliminarServices(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarServices))]
        public IEnumerable<Services> ConsultarServices()
        {
            Services u = new Services();
            return _ilogica.ConsultarServices(u).ToList();
        }

        #endregion

        #region Services_Categories

        [HttpPost]
        [Route(nameof(AgregarServices_Categories))]
        public bool AgregarServices_Categories(Services_Categories P_Entidad)
        {
            return _ilogica.AgregarServices_Categories(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarServices_Categories))]
        public bool ModificarServices_Categories(Services_Categories P_Entidad)
        {
            return _ilogica.ModificarServices_Categories(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarServices_Categories))]
        public bool EliminarServices_Categories(Services_Categories P_Entidad)
        {
            return _ilogica.EliminarServices_Categories(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarServices_Categories))]
        public IEnumerable<Services_Categories> ConsultarServices_Categories()
        {
            Services_Categories u = new Services_Categories();
            return _ilogica.ConsultarServices_Categories(u).ToList();
        }

        #endregion

        #region Employees
        [HttpPost]
        [Route(nameof(AgregarEmployees))]
        public bool AgregarEmployees(Employees P_Entidad)
        {
            return _ilogica.AgregarEmployees(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarEmployees))]
        public bool ModificarEmployees(Employees P_Entidad)
        {
            return _ilogica.ModificarEmployees(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarEmployees))]
        public bool EliminarEmployees(Employees P_Entidad)
        {
            return _ilogica.EliminarEmployees(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarEmployees))]
        public IEnumerable<Employees> ConsultarEmployees()
        {
            Employees u = new Employees();
            return _ilogica.ConsultarEmployees(u).ToList();
        }

        #endregion

        #region Employees_Schedule

        [HttpPost]
        [Route(nameof(AgregarEmployees_Schedule))]
        public bool AgregarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _ilogica.AgregarEmployees_Schedule(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarEmployees_Schedule))]
        public bool ModificarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _ilogica.ModificarEmployees_Schedule(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarEmployees_Schedule))]
        public bool EliminarEmployees_Schedule(Employees_Schedule P_Entidad)
        {
            return _ilogica.EliminarEmployees_Schedule(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarEmployees_Schedule))]
        public IEnumerable<Employees_Schedule> ConsultarEmployees_Schedule()
        {
            Employees_Schedule u = new Employees_Schedule();
            return _ilogica.ConsultarEmployees_Schedule(u).ToList();
        }

        #endregion

        #region PerfilesXusuarios
        [HttpPost]
        [Route(nameof(AgregarPerfilesXusuarios))]
        public bool AgregarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _ilogica.AgregarPerfilesXusuarios(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarPerfilesXusuarios))]
        public bool ModificarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _ilogica.ModificarPerfilesXusuarios(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarPerfilesXusuarios))]
        public bool EliminarPerfilesXusuarios(PerfilesXusuarios P_Entidad)
        {
            return _ilogica.EliminarPerfilesXusuarios(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarPerfilesXusuarios))]
        public IEnumerable<PerfilesXusuarios> ConsultarPerfilesXusuarios()
        {
            PerfilesXusuarios u = new PerfilesXusuarios();
            return _ilogica.ConsultarPerfilesXusuarios(u).ToList();
        }
        #endregion

        #region Perfiles
        [HttpPost]
        [Route(nameof(AgregarPerfiles))]
        public bool AgregarPerfiles(Perfiles P_Entidad)
        {
            return _ilogica.AgregarPerfiles(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarPerfiles))]
        public bool ModificarPerfiles(Perfiles P_Entidad)
        {
            return _ilogica.ModificarPerfiles(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarPerfiles))]
        public bool EliminarPerfiles(Perfiles P_Entidad)
        {
            return _ilogica.EliminarPerfiles(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarPerfiles))]
        public IEnumerable<Perfiles> ConsultarPerfiles()
        {
            Perfiles u = new Perfiles();
            return _ilogica.ConsultarPerfiles(u).ToList();
        }
        #endregion

        #region Services_Booked
        [HttpPost]
        [Route(nameof(AgregarServices_Booked))]
        public bool AgregarServices_Booked(Services_Booked P_Entidad)
        {
            return _ilogica.AgregarServices_Booked(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarServices_Booked))]
        public bool ModificarServices_Booked(Services_Booked P_Entidad)
        {
            return _ilogica.ModificarServices_Booked(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarServices_Booked))]
        public bool EliminarServices_Booked(Services_Booked P_Entidad)
        {
            return _ilogica.EliminarServices_Booked(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarServices_Booked))]
        public IEnumerable<Services_Booked> ConsultarServices_Booked()
        {
            Services_Booked u = new Services_Booked();
            return _ilogica.ConsultarServices_Booked(u).ToList();
        }
        #endregion







        #endregion

    }
}

