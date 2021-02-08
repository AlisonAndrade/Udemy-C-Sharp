using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculator
    {
        // maneira de alterar diretamente a variavel a
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        // maneira de lançar a variavel original sem modifica - lá diretamente, envia o resultado para saida
        public static void Calc(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
