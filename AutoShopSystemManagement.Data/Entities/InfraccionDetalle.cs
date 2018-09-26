using System.ComponentModel.DataAnnotations.Schema;

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
