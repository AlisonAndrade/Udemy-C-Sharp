using System;
using System.Collections.Generic;

namespace Listagem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Salvador");
            list.Add("Alison");
            list.Add("Leandro");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Bolsonaro");

            //inserindo com ponteiro
            list.Insert(2, "Chaves");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // CONTAGEM DE LINHAS
            Console.WriteLine("Quantidade de linhas: " + list.Count);


            // Maneira 1 de percorrer linhas no array
            string s1 = list.Find(Palavra);        
            Console.WriteLine("Primeira com a letra 'L':" + s1);

            static bool Palavra(string s)
            {
                return s[0] == 'L';
            }

            // Maneira 2 de percorrer linhas no array
            string s2 = list.Find(x => x[0] == 'B');
            Console.WriteLine("Primeira com a letra 'B':" + s2);

            // POSIÇÃO DA LISTA PRIMEIRO ITEM
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro item com a letra A esta posicionado na: " + pos1);

            // POSIÇÃO DA LISTA ULTIMO ITEM
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo item com a letra A esta posicionado na: " + pos2);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Listagem com nomes com 6 caracteres: ");
            List<string> list2 = list.FindAll(x => x.Length == 6);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            //remvendo uma pesssoa expecifica
            list.Remove("Alison");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            //remvendo pessoas começando com a letra M
            list.RemoveAll(x=> x[0] == 'A');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
