﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    class CalcularRet
    {
        public double Altura;
        public double Largura;


        public double Area()
        {
            return (Largura * Altura);
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }


        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
