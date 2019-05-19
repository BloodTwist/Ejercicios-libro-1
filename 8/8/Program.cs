using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, ¿Cómo te llamas?");
            String nombre = Console.ReadLine();

            Console.WriteLine("¿En qué año naciste?");
            int fNa=int.Parse( Console.ReadLine());
            int rta = 2030-fNa;

            Console.WriteLine($"Hola {nombre} en el año 2030 tendrás {rta} años");
            Console.ReadKey();
        }
    }
}
