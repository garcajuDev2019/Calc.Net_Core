using System;
using Serilog;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.NETCore
{
    public class Calculadora : ICalculadora
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int Dividir(int num1, int num2)
        {
            int result;
            try
            {
                result = (num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Log.Information(e.Message);
                Log.Error(e.StackTrace);
                throw;
            }
            PrintResultOfCalculator(result);
            return result;
        }

        public int Multiplicacion(int num1, int num2)
        {
            int result;
            result = (num1 * num2);
            PrintResultOfCalculator(result);
            return result;
        }

        public int Resta(int num1, int num2)
        {
            int result;
            result = (num1 - num2);
            PrintResultOfCalculator(result);
            return result;
        }

        public int Suma(int num1, int num2)
        {
             int result;
             result = (num1 + num2);
             PrintResultOfCalculator(result);
             return result;
        }
            
        public void PrintResultOfCalculator(int result)
            {
                Console.WriteLine(ConfigHelper.Config["calculadoraResult"], this.GetType().FullName, result);
            }
    }
}
