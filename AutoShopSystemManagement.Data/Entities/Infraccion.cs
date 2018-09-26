using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("Infraccions")]

    public class Infraccion:EntityBase
    {
        public int PeopleId { get; set; }
        public int VehicleBrand { get; set; }
        public string Placa { get; set; }
        public string VehicleColor { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleModel { get; set; }
        public string Ubicacion { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int EstadoId { get; set; }
        public int UsoId { get; set; }
        public string OtherConcept { get; set; }
        [ForeignKey("PeopleId")]
        public virtual Personas Persona { get; set; }

        public virtual ICollection<InfraccionDetalle> Detalles { get; set; }

    }
}
