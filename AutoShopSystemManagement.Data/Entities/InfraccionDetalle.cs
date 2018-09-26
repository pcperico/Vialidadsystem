using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("InfraccionDetalle")]
    public class InfraccionDetalle:EntityBase
    {
        public int InfraccionId { get; set; }
        public int TipoDeInfraccionId { get; set; }

        //[ForeignKey("InfraccionId")]
        //public virtual Infraccion Infraccion { get; set; }
        //[ForeignKey("TipoDeInfraccionId")]
        //public virtual TipoDeInfraccion TipoDeInfraccion { get; set; }

    }
}
