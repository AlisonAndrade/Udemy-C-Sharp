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

            Controlador[] vetor = new Controlador[estudantes];

            int nQuartos = 10;

            if (nQuartos < estudantes)
                {
                Console.Write("Quantidade de estudantes maior que o numero de quartos, maximo 10 quartos");
            } else
            {
                for (int i = 0; i < estudantes; i++)
                {
                    Console.Write("Entre com o valor do Quarto R$: ");
                    double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.Write("Entre com o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.Write("Entre com o Email: ");
                    string email = Console.ReadLine();

                    vetor[i] = new Controlador { Nome = nome, Email = email , Valor = valor};
                }
            }

           // Controlador Exibir = new Controlador();
                    Console.Write("");
                    Console.Write("");


                for (int i = 0; i < nQuartos; i++)
                {
                    if (vetor[i] != null)
                    {
                            Console.WriteLine("Clientes Hospedados: ");
                                 Console.WriteLine(i + " | " + vetor[i]);

                     }
                }
        }


    }

}
