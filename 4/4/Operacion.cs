using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class Operacion
    {
        public void Ecuacion(double a, double b, double c, double d, double valorx)
        {
            double res = 0;

            res = (a * (Math.Pow(valorx, 3))) + (b * (Math.Pow(valorx, 2))) - (c * 1) +d;

            Console.WriteLine($"El resultado es: {res}");
            Console.ReadLine();


        }

    }
}
