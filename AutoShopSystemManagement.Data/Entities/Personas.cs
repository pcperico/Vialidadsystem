using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopSystemManagement.Data.Entities
{
    [Table("Personas")]

    public class Personas:EntityBase
    {
        public  string FirstName { get; set; }
        public  string MiddleName { get; set; }
        public  string LastName1 { get; set; }
        public  string LastName2 { get; set; }
        public  string Direccion { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseType { get; set; }
        public byte[] PersonaPhoto { get; set; }
    }
}
