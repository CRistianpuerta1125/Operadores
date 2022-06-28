using System;


namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // operadores unarios 

            num3 = -num1;
            Console.WriteLine("El valor negatico es {0}", num3);

            bool haySol = true;
            Console.WriteLine("Hay sol? {0}", !haySol);
            Console.Read();
        }
    }
}
