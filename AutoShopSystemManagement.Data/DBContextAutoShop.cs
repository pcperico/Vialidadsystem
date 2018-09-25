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
        
    }
}
