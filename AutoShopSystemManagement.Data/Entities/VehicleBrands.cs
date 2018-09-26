using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("VehicleBrands")]

    public class VehicleBrands:EntityBase
    {
        public string VehicleBrandName { get; set; }
    }
}
