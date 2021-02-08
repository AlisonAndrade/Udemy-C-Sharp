using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            CadProduto p = new CadProduto();

            Console.WriteLine("Entre com os Dados do Produto: ");
            Console.Write("Nome: " );
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados dos Produtos: "+ p);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtdAdic = int.Parse(Console.ReadLine());

            // Adicionar o valor acima para calcular a função
            p.AdicionarProdutos(qtdAdic);

            Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
            int qtdRemover = int.Parse(Console.ReadLine());

            // Remover o valor acima para calcular a função
            p.RemoverProdutos(qtdRemover);

            Console.WriteLine("Dados Atualizados dos Produtos: " + p);
        }
    }
}
