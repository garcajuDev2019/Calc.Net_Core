using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.NETCore
{
    interface ICalculadora
    {
        int num1 { get; set; }
        int num2 { get; set; }

        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}
