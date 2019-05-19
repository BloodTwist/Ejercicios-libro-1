using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int car1 = 'A', car2 = 65, car3 = 0;

            car3 =   car1 + 'a' - 'A';
            Console.WriteLine((char)car3 + " " + car3);
            /*El resultado de la operación se da ya que al tener un operador, el carácter 
             toma su valor de código, en el caso de "a" es 97 y de "A" es 65. Dando como 
             resultado 97, También al convertir el resultado en "char" se muestra el simbolo
             que se le asign al código, por ejemplo, el resultado final en los dos casos es 97
             asi que el ordenador tomará el carácter con esa especificación, el cual es "a" */

            car3 = car2 + 32;
            Console.WriteLine((char)car3 + " " + car3);

            Console.ReadKey();
        }
    }
}
