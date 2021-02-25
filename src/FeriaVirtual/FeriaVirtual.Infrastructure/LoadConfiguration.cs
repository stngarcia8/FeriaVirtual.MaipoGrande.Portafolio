using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace FeriaVirtual.Infrastructure
{
    public class LoadConfiguration 
        : ILoadConfiguration
    {
        private IConfigurationRoot _configurationRoot;
        public IConfigurationRoot GetConfiguration => _configurationRoot;


        private LoadConfiguration() =>
            LoadConfigFromFile();

        public static ILoadConfiguration Load() =>
            new LoadConfiguration();

        private void LoadConfigFromFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json", true, true);
            _configurationRoot = builder.Build();
        }

    }
}
