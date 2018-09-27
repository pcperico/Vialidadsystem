using System.Collections.Generic;
using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoShopSystemManagement.Data.Services.Interfaces;

namespace VialidadSystem.Controllers
{
    public class InfraccionsController : Controller
    {
        private readonly IInfraccionRepository _infraccionRepository;
        private readonly ITipoDeInfraccionRepository _tipoDeInfraccionRepository;
        private readonly IEstadosRepository _estadosRepository;
        private readonly IUsosRepository _usosRepository;
        private readonly IVehicleBrandsRepository _vehicleBrandsRepository;
        private readonly IInfractionService _infractionService;

        public InfraccionsController(IInfraccionRepository infraccionRepository, ITipoDeInfraccionRepository tipoDeInfraccionRepository,IEstadosRepository estadosRepository,IUsosRepository usosRepository,IVehicleBrandsRepository vehicleBrandsRepository,IInfractionService infractionService)
        {
            _infraccionRepository = infraccionRepository;
            _tipoDeInfraccionRepository = tipoDeInfraccionRepository;
            _estadosRepository = estadosRepository;
            _usosRepository = usosRepository;
            _vehicleBrandsRepository = vehicleBrandsRepository;
            _infractionService = infractionService;
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

        [HttpPost]
        public ActionResult CrearInfraccion(CreateInfractionModel model, IEnumerable<HttpPostedFileBase> images)
        {
            var infraccion=_infractionService.CreateNewInfraction(model,images);
            var viewModel = new InfraccionDetailDto
            {
                Infraccion = infraccion,
                Infracciones = GetInfraccionNames(infraccion)
            };
            return View("InfraccionConfirmacion", viewModel);
        }

        public ActionResult InfraccionDetalle(int id)
        {
            var infraccion = _infraccionRepository.Get(id);
            var viewModel = new InfraccionDetailDto
            {
                Infraccion = infraccion,
                Infracciones = GetInfraccionNames(infraccion)
            };
            return View("InfraccionConfirmacion", viewModel);
        }

        private List<string> GetInfraccionNames(Infraccion infraccion)
        {
            if (infraccion?.Detalles == null) return null;

            return infraccion.Detalles.Select(i => _tipoDeInfraccionRepository.Get(i.TipoDeInfraccionId).TipoDeInfraccionName).ToList();

        }
    }
}