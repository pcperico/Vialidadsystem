using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;

namespace VialidadSystem.Controllers
{
    public class InfraccionsController : Controller
    {
        private readonly ITipoDeInfraccionRepository _tipoDeInfraccionRepository;

        public InfraccionsController(ITipoDeInfraccionRepository tipoDeInfraccionRepository)
        {
            _tipoDeInfraccionRepository = tipoDeInfraccionRepository;
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
    }
}