using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Bem Vindo a Calculadora ****");

            /// Maneira 1 usando Ref
            int a = 10;

            Calculator.Triple(ref a);

            Console.WriteLine(a);

            /// Maneira 1 usando out

            int b = 20;

            int triple;

            Calculator.Calc(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
