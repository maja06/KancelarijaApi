using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using KancelarijaApi.Attributes;

namespace RrepTest.MyAttributes
{
    public static class FilterServices
    {
        public static void AddFiltersService(this IServiceCollection services)
        {
            Assembly filterAssembly = Assembly.GetExecutingAssembly();
            var types = filterAssembly.GetTypes().Where(x => x.GetCustomAttributes<UniversalFilterAttribute>().Any());
            services.AddMvc(option =>
            {
                foreach (var type in types)
                {
                    option.Filters.Add(type);
                }
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
    }
}