using System;

namespace Ejercicios_libro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =10, b=3, c=1, d, e;
            float x, y;
            x = a / b;
            
            // "x" toma el valor de la suma entre 10 y 3, que son los datos que poseen las variables "a" y "b"

            c = a + b++;

            /* En esta parte la unica  diferencia con respecto a la operación ant. es el operador entre estas, y que tenemos a "b++", lo que nos
             dice que el valor de la variable "b" va a cambiar en la siguiente linea, es decir que en el resultado de "c", 
             la variable "b" va a tener el valor con el cual se inicializó*/ 

            e = ++a - b;

            /*En esta operación "b" ya tomo el valor de 4, debido al anterior "b++", y en este caso también la "++a" le va a pasar lo mismo que le pasó a la "b++",
             * anterior*/

            y = (float)a / b;
            /*En este caso se esta casteando un resultado, en este caso el cast se hace para que la división entre dos enteros quede en coma flotante (Decimal)    */

            Console.WriteLine($" x= {x} c= {c} e= {e} y= {y} ");
            /* En esta parte se hace la impresión de las variables que contienen resultados de operaciones, esto con la finalidad de entender mejor como funciona el codigo*/

            Console.ReadLine();

            /*El readline lo agregamos para que el programa no se cierre, sino tenga que esperar un enter para poder continuar y cerrarse */
        }
    }
}
