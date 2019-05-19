using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, res = 0, a, b, c ;

            Console.WriteLine("Digite valores de coeficientes para la expresión ax^5 - bx^3 +cx -7 ");

            Console.WriteLine("Digite el valor de a");
            a = double.Parse((Console.ReadLine()));

            Console.WriteLine("Digite el valor de b");
            b = double.Parse((Console.ReadLine()));

            Console.WriteLine("Digite el valor de c");
            c = double.Parse((Console.ReadLine()));

            Console.WriteLine("Digite el valor de x");
            x = double.Parse((Console.ReadLine()));

            res = (a * Math.Pow(x, 5)) - (b * Math.Pow(x, 3)) + (c * x) - 7;

            Console.WriteLine($"para x = {x}, {a}x ^ 5 - {b}x ^ 3 + {c}x - 7 = {res}");


            Console.ReadKey();
        }
    }
}
