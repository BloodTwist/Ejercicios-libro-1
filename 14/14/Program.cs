using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite hasta donde llegará la sumatoria: ");
           int b = int.Parse(Console.ReadLine());

            Console.Write("Digite hasta donde iniciará la sumatoria: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite el primer coeficiente de la sumatoria: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite el término independiente de la sumatoria: ");
            int y = int.Parse(Console.ReadLine());

            if (b>a)
            { 
                double sum, acum = 0;

                for (int i = a; i <= b; i++)
                {
                    sum = 1 / ((double)x + ((double)i * (double)y));
                    acum = acum + sum;
                }

                Console.Write($"El resultado de la sumatoria es: {acum} ");
            }
            else
            {
                Console.WriteLine("El valor del indice superior (Fin) es menor al valor del indice inferior (Inicio)");

            }
            Console.ReadKey();
        }
    }
}
