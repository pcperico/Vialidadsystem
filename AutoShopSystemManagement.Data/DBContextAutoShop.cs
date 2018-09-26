using AutoShopSystemManagement.Data.Entities;
using System.Data.Entity;

namespace AutoShopSystemManagement.Data
{
    public class DbContextAutoShop:DbContext
    {
        public DbContextAutoShop():base("AutoshopConnectionString")
        {
        
        }

        public DbSet<TipoDeInfraccion> Roles { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Usos> Usos { get; set; }
        public DbSet<VehicleBrands> VehicleBrands { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Infraccion> Infraccions { get; set; }
        public DbSet<InfraccionDetalle> InfraccionDetails { get; set; }
        
    }
}
