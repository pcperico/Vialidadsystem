using AutoShopSystemManagement.Data.Entities;
using System.Collections.Generic;

namespace AutoShopSystemManagement.Data.Dtos
{
    public class CreateInfractionModel
    {
        public  Infraccion Infraccion { get; set; }
        public List<TipoDeInfraccion> InfraccionTypes { get; set; }
        public List<Estados> Estados { get; set; }
        public List<Usos> Usos { get; set; }
        public List<VehicleBrands> VehicleBrands { get; set; }
    }
}
