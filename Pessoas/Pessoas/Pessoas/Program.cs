using OpenXmlPowerTools;
using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;

            A = new Pessoa();
            B = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            A.nome  = Console.ReadLine();

            try
            {
                Console.Write("Digite a idade: ");
                A.idade = int.Parse(Console.ReadLine());
            }          
            catch (Exception ex)
            {
                //   throw ex;//new System.InvalidOperationException("Valor invalido!!!");
                Console.WriteLine(ex.Message);
                //console.Readline();
                //throw new ArgumentNullException(ex, “O valor do parâmetro não pode ser null”);
            }

            Console.Write("Digite o nome da segunda pessoa: ");
            B.nome  = Console.ReadLine();

            try
            {
                Console.Write("Digite a idade: ");
                B.idade = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //console.Readline();
            }


            if (A.idade > B.idade)
                Console.WriteLine("Pessoa mais velha é " + A.nome);
            else
                Console.WriteLine("Pessoa mais velha é " + B.nome);

        }
    }
}
