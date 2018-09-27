using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("InfraccionImages")]
    public class InfraccionImages:EntityBase
    {
        public int InfraccionId { get;set; }
        public byte[] Image { get; set; }
    }
}
