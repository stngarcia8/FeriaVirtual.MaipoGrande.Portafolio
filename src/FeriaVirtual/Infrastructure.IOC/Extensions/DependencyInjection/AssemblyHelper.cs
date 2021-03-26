using System.Collections.Concurrent;
using System.Reflection;

namespace FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection
{
    public static class AssemblyHelper
    {
        private static readonly ConcurrentDictionary<string, Assembly> _assemblies =
            new();

        public static Assembly GetInstance(string key) =>
            _assemblies.GetOrAdd(key, Assembly.Load(key));


    }


    public static class Assemblies
    {
        public const string Application = "mpfv_application";
    }




}
