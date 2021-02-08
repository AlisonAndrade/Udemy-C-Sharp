using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p;

            p = new Aluno();

            Console.Write("Nome do aluno: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite a quantidade de notas a serem inseridas: ");
            int quantidade = int.Parse(Console.ReadLine());

            p.Calcular(quantidade);

            if (p.Nota < 60)
                {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("NOTA FINAL: " + p.Nota);
                Console.WriteLine($"FALTARAM {p.Diferenca} PONTOS PARA SER APROVADO");
            }
            else
            {
                Console.WriteLine("Aluno Aprovado!!!");
                Console.WriteLine($"NOTA FINAL: {p.Nota}");
                Console.WriteLine("Boas Férias");
            }
        }
    }
}
