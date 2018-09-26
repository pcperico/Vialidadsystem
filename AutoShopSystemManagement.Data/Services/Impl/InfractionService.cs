using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;
using AutoShopSystemManagement.Data.Services.Interfaces;
using System;

namespace AutoShopSystemManagement.Data.Services.Impl
{
    public class InfractionService:IInfractionService
    {
        private readonly ITipoDeInfraccionRepository _tipoDeInfraccionRepository;

        public InfractionService(ITipoDeInfraccionRepository tipoDeInfraccionRepository)
        {
            _tipoDeInfraccionRepository = tipoDeInfraccionRepository;
        }

        public Infraccion CreateNewInfraction(CreateInfractionModel model)
        {
            using (var context = new DbContextAutoShop())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        model.Infraccion.DateCreated = DateTime.Now;
                        model.Infraccion.DateUpdated = DateTime.Now;
                        model.Infraccion.Persona.DateCreated = DateTime.Now;
                        model.Infraccion.Persona.DateUpdated = DateTime.Now;
                        var infraccion = model.Infraccion;
                        context.Infraccions.Add(infraccion);
                        foreach (var infra in model.InfractionTypesSelected)
                        {
                            context.InfraccionDetails.Add(new InfraccionDetalle
                            {
                                InfraccionId = infraccion.Id,
                                TipoDeInfraccionId = _tipoDeInfraccionRepository.Get(infra).Id
                            });
                        }
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                        return infraccion;

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}
