using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x,res;
            Operacion m = new Operacion();
            Console.WriteLine("polinomio de la forma ax^3+bx^2+cx+d ");

            Console.WriteLine("Digite el primer coeficiente (a): ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo coeficiente (b): ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer coeficiente (c): ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el cuarto coeficiente (d): ");
            d = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de la incognita (x): ");
            x = double.Parse(Console.ReadLine());

            m.Ecuacion(a, b, c, d, x);

            // Desde consola   m.Ecuacion(3, 3.5,2,5,5);


        }
    }
}
