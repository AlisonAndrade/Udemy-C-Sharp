using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double somar = 0.0;

            for (int i = 0; i < n; i++)
            {
                somar += vect[i];
            }
            double media = somar / n;
            Console.WriteLine("MEDIA DE ALTURA = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
