using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;
using System.Collections.Generic;
using System.Web;

namespace AutoShopSystemManagement.Data.Services.Interfaces
{
    public interface IInfractionService
    {
        Infraccion CreateNewInfraction(CreateInfractionModel model, IEnumerable<HttpPostedFileBase> images);
    }
}
