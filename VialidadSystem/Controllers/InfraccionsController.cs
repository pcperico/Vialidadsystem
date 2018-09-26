using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace VialidadSystem.Controllers
{
    public class InfraccionsController : Controller
    {
        private readonly ITipoDeInfraccionRepository _tipoDeInfraccionRepository;
        private readonly IEstadosRepository _estadosRepository;
        private readonly IUsosRepository _usosRepository;
        private readonly IVehicleBrandsRepository _vehicleBrandsRepository;

        public InfraccionsController(ITipoDeInfraccionRepository tipoDeInfraccionRepository,IEstadosRepository estadosRepository,IUsosRepository usosRepository,IVehicleBrandsRepository vehicleBrandsRepository)
        {
            _tipoDeInfraccionRepository = tipoDeInfraccionRepository;
            _estadosRepository = estadosRepository;
            _usosRepository = usosRepository;
            _vehicleBrandsRepository = vehicleBrandsRepository;
        }
        [HttpGet]
        public ActionResult AgregarTipoInfraccion()
        {
            var model = new TipoDeInfraccion();
            return View(model);
        }
        [HttpPost]
        public ActionResult AgregarTipoInfraccion(TipoDeInfraccion model)
        {
            _tipoDeInfraccionRepository.AddNewInfractionType(model);
            return RedirectToAction("ListarConceptos");
        }

        [HttpGet]
        public ActionResult ListarConceptos()
        {
            var model = _tipoDeInfraccionRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult CrearInfraccion()
        {
            var model = new CreateInfractionModel
            {
                Infraccion = new Infraccion
                {
                    Persona = new Personas()
                },
                InfraccionTypes = _tipoDeInfraccionRepository.GetAll().ToList(),
                Estados=_estadosRepository.GetAll().ToList(),
                Usos = _usosRepository.GetAll().ToList(),
                VehicleBrands = _vehicleBrandsRepository.GetAll().ToList()
            };
            return View(model);
        }
    }
}