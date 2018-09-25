using AutoShopSystemManagement.Data.Entities;

namespace AutoShopSystemManagement.Data.Repositories.Interfaces
{
    public interface ITipoDeInfraccionRepository:IRepository<TipoDeInfraccion>
    {
        TipoDeInfraccion AddNewInfractionType(TipoDeInfraccion infractionType);
    }
}
