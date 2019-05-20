using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el día de su nacimiento: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el mes de su nacimiento: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el año de su nacimiento: ");
            int year = int.Parse(Console.ReadLine());
            if ((year <= 2019)&&(mes>0 && mes<=12)&&(dia>0 && dia <= 31))
            {


                int suma = dia + mes + year;
                int n1, n2, res;
                int[] var = new int[8];

                var[0] = suma % 10;
                var[1] = suma / 10;
                var[2] = var[1] % 10;
                var[3] = var[1] / 10;
                var[4] = var[3] % 10;
                var[5] = var[3] / 10;

                n1 = var[0] + var[2] + var[4] + var[5];

                var[6] = n1 % 10;
                var[7] = n1 / 10;

                res = var[6] + var[7];

                Console.WriteLine($"Su número del tarot es el {res}");
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento no valida...");
            }
            Console.ReadKey();
        }
    }
}
