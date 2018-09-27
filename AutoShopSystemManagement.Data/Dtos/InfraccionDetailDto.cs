using AutoShopSystemManagement.Data.Entities;
using System.Collections.Generic;

namespace AutoShopSystemManagement.Data.Dtos
{
    public class InfraccionDetailDto
    {
        public Infraccion Infraccion { get; set; }
        public List<string> Infracciones { get; set; }
    }
}
