using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShopSystemManagement.Data.Entities;

namespace AutoShopSystemManagement.Data.Dtos
{
    public class CreateInfractionModel
    {
        public  Infraccion Infraccion { get; set; }
        public List<TipoDeInfraccion> InfraccionTypes { get; set; }
    }
}
