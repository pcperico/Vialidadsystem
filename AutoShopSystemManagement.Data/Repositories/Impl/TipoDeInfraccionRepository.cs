using System;
using AutoShopSystemManagement.Data.Entities;
using AutoShopSystemManagement.Data.Repositories.Interfaces;

namespace AutoShopSystemManagement.Data.Repositories.Impl
{
    public class TipoDeInfraccionRepository: Repository<TipoDeInfraccion>,ITipoDeInfraccionRepository
    {
        public TipoDeInfraccion AddNewInfractionType(TipoDeInfraccion infractionType)
        {
            infractionType.Activa = true;
            infractionType.DateCreated = DateTime.Now;
            infractionType.DateUpdated = DateTime.Now;
            Save(infractionType);
            return infractionType;
        }
    }
}
