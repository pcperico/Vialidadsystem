using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("infraccions")]

    public class Infraccion:EntityBase
    {
        public int PeopleId { get; set; }
        public string Placa { get; set; }
        public string VehicleColor { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleModel { get; set; }
        public string Ubicacion { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        [ForeignKey("PeopleId")]
        public Personas Persona { get; set; }
        public int EstadoId_EstadoId { get; set; }
        public int UsoId_UsoId { get; set; }
        public string OtherConcept { get; set; }
    }
}
