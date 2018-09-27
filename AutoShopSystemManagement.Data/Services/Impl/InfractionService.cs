using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;
using AutoShopSystemManagement.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace AutoShopSystemManagement.Data.Services.Impl
{
    public class InfractionService:IInfractionService
    {
        private readonly ITipoDeInfraccionRepository _tipoDeInfraccionRepository;
        private readonly IInfraccionImagesRepository _imagesRepository;

        public InfractionService(ITipoDeInfraccionRepository tipoDeInfraccionRepository,IInfraccionImagesRepository imagesRepository)
        {
            _tipoDeInfraccionRepository = tipoDeInfraccionRepository;
            _imagesRepository = imagesRepository;
        }

        public Infraccion CreateNewInfraction(CreateInfractionModel model, IEnumerable<HttpPostedFileBase> images)
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
                        AddPictureToCar(infraccion.Id, images);
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

        public bool AddPictureToCar(int infraccionId,IEnumerable<HttpPostedFileBase> infractionImages)
        {
            if (infractionImages == null)
                return false;
            foreach (var cp in infractionImages)
            {
                var photo = new InfraccionImages {InfraccionId = infraccionId };
                using (var ms = new MemoryStream())
                {
                    cp.InputStream.CopyTo(ms);
                    photo.Image = ms.GetBuffer();
                }
                _imagesRepository.Save(photo);
            }
            return true;
        }
    }
}
