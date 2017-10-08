using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace WorkCards.Configuration
{
    public static class Configurations
    {
        private static IConfigurationRoot _configuration { get; set; }

        static  Configurations()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }

        public static string GetSection(string Key)
        {
            return _configuration.GetSection(Key).Path;
        }
    }
}
