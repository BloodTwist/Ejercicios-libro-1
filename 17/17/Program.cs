using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trinomio de la forma ax^2+bx+c=0");
            Console.Write("Digite el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            if ((a==0)&&(b==0))
            {
                Console.WriteLine("la Ecuación es degenerada");
            }
            else if ((a==0)&&(b !=0))
            {
                double res= -c/b;

                Console.WriteLine($"El resultado de la raiz es {res}");
            }else
            {
                double cua = b * b;
                double cuadraticaPositiva= -((b) + Math.Sqrt((cua) - 4 * (a * c))) / (2 * (a));
                double cuadraticanegativa = -((b) - Math.Sqrt((cua) - 4 * (a * c))) / (2 * (a));

                string imgPositiva = Convert.ToString(cuadraticaPositiva);
                string imgNegativa = Convert.ToString(cuadraticanegativa);

                double d = Math.Sqrt((cua) - 4 * (a * c));
                if (d >= 0)
                {
                    Console.WriteLine($"Hay dos raices reales, cuyos resultados son: {cuadraticaPositiva} en positivo y {cuadraticanegativa} en negativa");
                }
                else if(d < 0)
                {
                    Console.WriteLine($"Hay dos raices complejas, asi que la respuesta esta dentro del conjunto de los imaginarios: \n {imgPositiva}j positivo y {imgNegativa}j negativo ");
                }

            }





            Console.ReadKey();
        }
    }
}
