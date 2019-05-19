using System;

namespace _6
{
    class Program
    {
        const int limInferior = -30;
        const int limSuperior = 100;
        const int incremento = 6;

        public static float ObtenerFahrenheit(float gradosC)
        {
            return 9f / 5f * gradosC + 32;
        }

        static void Main(string[] args)
        {
            int gradosCent = limInferior;
            float gradosFahr = 0;

            while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);

                Console.WriteLine($"{gradosCent} C {gradosFahr} F");
                //System.Console.WriteLine("{0,8:d} C {1,8:f} F", gradosCent , gradosFahr);


                gradosCent += incremento;
                Console.ReadKey();

            }
        }
    }
}
