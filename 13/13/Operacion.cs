using System;
using System.Collections.Generic;
using System.Text;

namespace _13
{
    class Operacion
    {

        int mod5, mod2, a, b, inicio, fin , sum=0;
        public void Condicion (int a, int b)
        {

            if (a < b)
            {
                inicio = a;
                fin = b;
                for (int i = inicio; i < fin; i++)
                {
                    mod5 = i % 5;
                    mod2 = i % 2;
                    if ((mod5 == 0) && (i != 0))
                    {
                        Console.WriteLine($"Núm {i}");
                        sum += i;
                    }

                }
            }
            else
            {
                inicio = b;
                fin = a;
                for (int i = inicio; i < fin; i++)
                {
                    mod5 = i % 5;
                    if ((mod5 == 0) && (i != 0))
                    {
                        mod5 = i % 5;
                        Console.WriteLine($"Núm {i}");

                    }

                }


            }

            Console.WriteLine($"El resultado de la sumatoria es: {sum}");
        }

    }
}
