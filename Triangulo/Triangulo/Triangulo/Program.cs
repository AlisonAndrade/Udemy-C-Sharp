﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
          //  double xA,xB,xC;
          //  double yA, yB, yC;

            CalcularTriang x, y;

            x = new CalcularTriang();
            y = new CalcularTriang();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            //double p = (x.A + x.B + x.C) / 2.0;

            //Math.Sqrt = raiz quadrada

            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            // usando o metodo area X
            double areaX = x.area();


            //p = (y.A + y.B + y.C) / 2.0;

            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            // usando o metodo area X
            double areaY = y.area();


            //Mostrando na tela o resultado
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área : X" );
            }
            else
            {
                Console.WriteLine("Maior área : Y");
            }
        }
    }
}