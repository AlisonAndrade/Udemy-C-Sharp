using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Retangulo
{
    class Program
    {

        static void Main(string[] args)
        {
            CalcularRet retorno;

            retorno  = new CalcularRet();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.WriteLine("");
            Console.Write("Valor da Largura: ");
            retorno.Largura = double.Parse(Console.ReadLine()); ;

            Console.Write("Valor da Altura: ");
            retorno.Altura = double.Parse(Console.ReadLine()); ;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");

            double valorArea      = retorno.Area();
            double valorPerimetro = retorno.Perimetro();
            double valorDiagonal  = retorno.Diagonal();

            Console.WriteLine("Valor da Area: "         + valorArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do Perimetro: "    + valorPerimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da Diagonal: "     + valorDiagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
        }
    }
}
