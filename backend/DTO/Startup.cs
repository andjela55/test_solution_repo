using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DTO
{
    public static class Startup
    {
        public static Assembly GetDtoAssembly(this IServiceCollection service)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            return currentAssembly;
        }
    }
}
