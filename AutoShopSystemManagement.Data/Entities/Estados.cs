using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("Estados")]
    public class Estados:EntityBase
    {
        public string EstadoName { get; set; }
        public string EstadoCountry { get; set; }
    }
}
