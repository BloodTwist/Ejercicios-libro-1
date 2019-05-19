using System;

namespace _13
{
    class Program
    {
        public static int index;
        static void Main(string[] args)
        {
            int mod5, mod2, a, b, inicio, fin;

            for (index = 0; index < 1; index++)
            {


                Console.Write("Digite inicio: ");
                a = int.Parse((Console.ReadLine()));

                Console.Write("Digite fin: ");
                b = int.Parse((Console.ReadLine()));

                Operacion m = new Operacion();
                Program g = new Program();

                if ((a > -1) && (b > -1))
                {
                    m.Condicion(a, b);
                }
                else
                {
                    Console.WriteLine("Digite valores positivos n");
                    index--;

                }
            }
            Console.ReadKey();
            
            




        }
    }
}
