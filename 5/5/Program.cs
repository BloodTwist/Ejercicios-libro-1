using System;

namespace _5
{
    class Program
    {
        const int limInferior = 50;
        const int limSuperior = 273;
        const int incremento = 2;

        public static float ObtenerFahrenheit(float gradosC)
        {
            return 9F / 5F * gradosC + 32;
        }

        static void Main(string[] args)
        {
            int gradosCent = limInferior;
            float gradosFahr = 0;

            while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);

                System.Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent , gradosFahr);
                

                gradosCent += incremento;
                Console.ReadKey();
                /*Al cambiar los datos constantes lo que se genera es que el bucle en este caso se ejecute mas veces, lo que genera un dato mayor y diferente del ejemplo propuesto*/
            }

            


        }
    }
}
