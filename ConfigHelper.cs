using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Calculadora.NETCore
{
    public static class ConfigHelper
    {
        public static IConfiguration Config
        {
            get
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                return builder.Build();
            }
        }
    }
}
