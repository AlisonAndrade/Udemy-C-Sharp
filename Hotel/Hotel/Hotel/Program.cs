using System;
using System.Globalization;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de Estudantes: ");
            int estudantes = int.Parse(Console.ReadLine());

            Controlador[] vetor = new Controlador[10];

            int nQuartos = 10;

            if (nQuartos < estudantes)
            {
                Console.Write("Quantidade de estudantes maior que o numero de quartos, maximo 10 quartos");
            }
            else
            {
                for (int i = 0; i < estudantes; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Aluguel #{i}:");

                    Console.Write("Entre com o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.Write("Entre com o Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Entre com o valor do Quarto R$: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Entre com o numero do quarto: ");
                    int quarto = int.Parse(Console.ReadLine());

                    vetor[i] = new Controlador(nome, email, valor);
                }
            }

            // Controlador Exibir = new Controlador();
            Console.WriteLine("");
            Console.WriteLine("");
            

            Console.WriteLine("Clientes Hospedados: ");

            Console.WriteLine("");

            /*
            foreach (string objeto in vetor)
            {
                Console.WriteLine(objeto);
            }
            */
            
            for (int i = 0; i < nQuartos; i++)
            {
                if (vetor[i] != null)
                {                    
                    Console.WriteLine("Quarto Nº: ' " + i + " | " + vetor[i]);

                }
            }
            
        }
    }
}
