using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("Usos")]
    public class Usos:EntityBase
    {
        public string UsoName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
