using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace PiKitchen.Dal.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path, false);

            var root = configBuilder.Build();
            var appSettings = root.GetSection("ConnectionStrings:DefaultConnection");
            sqlConnectionString = appSettings.Value;
        }

        public string sqlConnectionString { get; set; }
    }
}
