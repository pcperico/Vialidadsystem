using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("TipoDeInfraccions")]
    public class TipoDeInfraccion:EntityBase
    {
        public string TipoDeInfraccionName { get; set; }
        public bool Activa { get; set; }
        public int Multiplicador { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
