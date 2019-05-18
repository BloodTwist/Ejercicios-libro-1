using System;

namespace _5
{
    class Program
    {
        const int limInferior = -30;
        const int limSuperior =100;
        const int incremento = 6;

        public static float ObtenerFahrenheit(float gradosC)
        {
            float res = 9f/5f *gradosC+ 32;
            /*La explicación del porqué el "9/5" se tiene que usar la letra "f", se debe al identificador
             este nos dice que tomará un dato de coma flotante, de este modo no se puede poner 1.8 (Solución de 9/5) 
             porque estamos diciendo que el dato es del tipo double, lo que crea conflictos. Asi que, la mejor solución es
             hacer un "cast"*/

            return res;
        }

        static void Main(string[] args)
        {
            int  gradosCent = limInferior;
            float gradosFahr = 0;

            while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);

               // Console.WriteLine($"{gradosCent} C {gradosFahr} F");
                System.Console.WriteLine("{0,8:d} C {1,8:f} F", gradosCent , gradosFahr);
                

                gradosCent += incremento;
                Console.ReadKey();
                
            }

            


        }
    }
}
