using Microsoft.Extensions.Configuration;

namespace FeriaVirtual.Infrastructure
{
    public interface ILoadConfiguration
    {
        IConfigurationRoot GetConfiguration { get; }
    }
}