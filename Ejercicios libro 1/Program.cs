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

            /* En esta parte la unica  diferencia con respecto a la operación ant. es que tenemos a "b++", lo que nos
             dice que el valor de la variable "b" va a cambiar en la siguiente linea, es decir en el resultado de "c", 
             la variable "b" */ 

            e = ++a - b;
            y = (float)a / b;
            Console.WriteLine($" x= {x} c= {c} e= {e} y= {y} ");
            Console.ReadLine();

            /*Las variables "a" y "b" se van operando y almacenando en variables del tipo float y entero 
            
             */


        }
    }
}
