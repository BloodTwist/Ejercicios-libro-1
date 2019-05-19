using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //3x^5 - 5x^3 +2x -7
            //Para x = valor, 3x^5 - 5x^3 +2x -7 = resultado 

            double x, res=0;

            Console.WriteLine("Digite el valor de x, con el que se evulará la expresión 3x^5 - 5x^3 +2x -7 ");
            x=double.Parse( (Console.ReadLine()));
            res = (3*Math.Pow(x,5)) - (5* Math.Pow(x, 3)) + (2*x) - 7;
            Console.WriteLine($"para x = {x}, 3x ^ 5 - 5x ^ 3 + 2x - 7 = {res}");
            Console.ReadKey();

        }
    }
}
