using System.Reflection;

namespace ToPontoBackend.CrossCutting.Assemblies;

public class AssemblyUtil
{
    public static IEnumerable<Assembly> GetCurrentAssemblies()
    {
        return new Assembly[]
        {
            Assembly.Load("ToPontoBackend.Api"),
            Assembly.Load("ToPontoBackend.Application"),
            Assembly.Load("ToPontoBackend.Domain"),
            Assembly.Load("ToPontoBackend.Infrastructure"),
            Assembly.Load("ToPontoBackend.CrossCutting")
        };
    }
}
