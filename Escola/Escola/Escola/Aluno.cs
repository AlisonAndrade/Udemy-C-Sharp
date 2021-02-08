using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Aluno
    {
        public string Nome;
        public double Nota;               
        public double Diferenca;
                 
        public void Calcular(int quantidade)
        {

         double[] ValorLista;

         ValorLista = new double[quantidade];

         double VlNota;

        Console.WriteLine("********************************");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite a nota: ");
                VlNota = double.Parse(Console.ReadLine());               

                ValorLista[i] = VlNota;

                Nota = Nota + VlNota;
            }

            Console.WriteLine("********************************");

            Diferenca = 60 - Nota;
           
        }                   

    }
}
