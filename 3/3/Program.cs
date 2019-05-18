using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=5, b= -1.7, c=2, d=3.5, k=3, x = 10.5,res=0;

            res=(a*(Math.Pow(x, 4))) + (b*(Math.Pow(x, 3))) - (c*(Math.Pow(x, 2)))+(d*x)+k;

            Console.WriteLine($"El resultado es: {res}");
            Console.ReadLine();


        }
    }
}
