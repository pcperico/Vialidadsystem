using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("InfraccionDetalle")]
    public class InfraccionDetalle:EntityBase
    {
        public int InfraccionId { get; set; }
        public int TipoDeInfraccionId { get; set; }

        [ForeignKey("InfraccionId")]
        public Infraccion Infraccion { get; set; }
        [ForeignKey("TipoDeInfraccionId")]
        public TipoDeInfraccion TipoDeInfraccion { get; set; }

    }
}
