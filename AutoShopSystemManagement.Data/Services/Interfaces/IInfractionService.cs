using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShopSystemManagement.Data.Dtos;
using AutoShopSystemManagement.Data.Entities;

namespace AutoShopSystemManagement.Data.Services.Interfaces
{
    public interface IInfractionService
    {
        Infraccion CreateNewInfraction(CreateInfractionModel model);
    }
}
