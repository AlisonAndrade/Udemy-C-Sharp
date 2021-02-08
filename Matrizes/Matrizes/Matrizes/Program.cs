using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz
            //double[,] mat = new double[2, 3];

            // total matriz
            //Console.WriteLine(mat.Length);

            // quantidade de linhas
            //Console.WriteLine(mat.Rank);

            Console.WriteLine("Entre com o valor: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }


            }



        }
    }
}
