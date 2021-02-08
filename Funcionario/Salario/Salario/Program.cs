using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa1, pessoa2;

            pessoa1 = new Funcionario();
            pessoa2 = new Funcionario();

            double mediaSalario;

            Console.Write("Nome do Primeiro Funcionario: ");
            pessoa1.nome = Console.ReadLine();

            Console.Write("Salario: ");
            pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Nome do Segundo Funcionario: ");
            pessoa2.nome = Console.ReadLine();

            Console.Write("Salario: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                mediaSalario = (pessoa1.salario + pessoa2.salario) / 2.0;
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("MEDIA DE SALARIO É: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
