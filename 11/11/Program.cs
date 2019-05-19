using System;

namespace _11
{
    class Program
    {
        public void Caracter ()
        {
           

        }


        static void Main(string[] args)
        {
            char car = '\0';
            //Console.Write("Carácter: ");
            //car = (char)Console.Read();
            //Console.WriteLine(car);

            /*En este programa lo que sucede es que la variable "car" toma un valor en la linea
             11, pero al tratar de tomar un valor nuevo en la linea 16, este no toma la instrucción 
             del nuevo valor y toma el valor de \r, que en pocas palabras es un retorno de carro y
             hace que el programa termine en esa misma linea.*/


            Console.Write("Carácter: ");
            car = (char)Console.Read();
            Console.WriteLine(car);
            /*Despúes de probar con clases, métodos, ciclos y revisar el apartado de caracteres del libro,
             la única forma que pude notar que el programa funcionase es cuando se hace la lectura del caracter
             solo una vez, de lo contrario, surguen retornos de carro*/
             Console.ReadKey();

        }
    }
}
