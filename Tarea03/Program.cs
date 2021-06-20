using System;

namespace Tarea03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 5;
            Console.WriteLine("Valor de la variable a: {0}", a);
            Console.WriteLine("Valor de la variable b: {0}", b);

            Console.WriteLine("Suma: {0}",  a + b);
            Console.WriteLine("Resta: {0}", a - b);
            Console.WriteLine("Multiplicación: {0}", a * b);
            Console.WriteLine("División: {0}", a / b);
            Console.WriteLine("Módulo: {0}", a % b);
            
            Console.ReadKey();
        }
    }
}
