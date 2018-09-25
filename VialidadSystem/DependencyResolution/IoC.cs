using StructureMap;
namespace VialidadSystem.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.Assembly("AutoShopSystemManagement.Data");                   
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            });
            return ObjectFactory.Container;
        }
    }
}