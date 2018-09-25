using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopSystemManagement.Data.Entities
{
    public class Infraccion:EntityBase
    {
        public string Placa { get; set; }
        public string VehicleColor { get; set; }
        public int VehicleYear { get; set; }
        public string Ubicacion { get; set; }
        public Guid ProfileId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        /*todo Preguntar por estos fields*/
        public int EstadoId_EstadoId { get; set; }
        public int UsoId_UsoId { get; set; }
    }
}
