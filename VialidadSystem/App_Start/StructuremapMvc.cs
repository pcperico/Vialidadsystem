using System.Web.Mvc;
using StructureMap;
using VialidadSystem.DependencyResolution;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VialidadSystem.WebApplication.App_Start.StructuremapMvc), "Start")]

namespace VialidadSystem.WebApplication.App_Start
{
    public static class StructuremapMvc
    {
        public static void Start()
        {
            var container = (IContainer)IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}