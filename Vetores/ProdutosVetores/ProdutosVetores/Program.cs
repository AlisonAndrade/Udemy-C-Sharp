using System;
using System.Globalization;

namespace ProdutosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de itens: ");
            int qtd = int.Parse(Console.ReadLine());

            Produtos[] vect = new Produtos[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Nome do Produto: ");
                string name = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produtos { Nome = name, Preco = price };
            }
            double sum = 0.0;
            for (int i = 0; i < qtd; i++)
            {
                sum += vect[i].Preco;
            }
            double avg = sum / qtd;

            Console.WriteLine("PREÇO MEDIO = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
