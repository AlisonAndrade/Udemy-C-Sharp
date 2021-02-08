using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulo
{
    class CalcularTriang
    {
        public double A;
        public double B;
        public double C;

        public double area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }
}
