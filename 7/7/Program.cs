using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double res=0, radio;
            double pi = Math.PI;
            Console.WriteLine("Digite el radio de la esfera: ");
            radio = double.Parse(Console.ReadLine());

            res = (4d / 3d) * pi * (Math.Pow(radio, 3));

            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
