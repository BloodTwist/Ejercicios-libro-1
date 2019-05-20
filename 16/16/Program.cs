using System;

namespace _16
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pcNum = rnd.Next(1, 10);
            int num = 0;
            Console.WriteLine("Empecemos >:) recuerda que es entre 1 y 10");

            

            for (int i=0; i < 3; i++)
            {
                Console.Write("Digita un número ");
                num = int.Parse(Console.ReadLine());
                if (num == pcNum)
                {
                    break;
                }
                if ((num > 0) && (num <= 10))
                {



                    if (num < pcNum)
                    {
                        Console.WriteLine("Un poco más...");

                    }
                    else if (num > pcNum)
                    {
                        Console.WriteLine("Te pasaste, !Menos¡");

                    
                    }
                   
                }
                else
                {
                    Console.WriteLine("Digita un número entre el 1 y 10 por favor...");
                    i--;
                }
                
            }
            if (num == pcNum)
            {
                Console.WriteLine($"Vaya eres bueno, efectivamente es {pcNum} <:( ");
            }
            else
            {
                Console.WriteLine($"He ganado jejeje >:D el número era {pcNum}");
            }
            
                
            

            Console.ReadKey();
        }
    }
}
