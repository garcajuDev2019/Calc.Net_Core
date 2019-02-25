using System;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace Calculadora.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt",
                    outputTemplate: ConfigHelper.Config["logOutTemplate"])
                .CreateLogger();

            ICalculadora calculadora = new Calculadora();
            calculadora.Dividir(9, 0);
        }
    }
}
