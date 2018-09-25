using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("TipoDeInfraccions")]
    public class TipoDeInfraccion:EntityBase
    {
        [Required(ErrorMessage = "Nombre de tipo de infracción es requerido")]
        public string TipoDeInfraccionName { get; set; }
        public bool Activa { get; set; }
        [Required(ErrorMessage = "Valor de multiplicador es requerido")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Multiplicador debe ser numerico")]
        public int Multiplicador { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
