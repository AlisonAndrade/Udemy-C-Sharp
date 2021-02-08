using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Hotel
{
    class Controlador
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public double Valor { get; set; }

        public Controlador(string nome, string email, double valor )
        {
            Nome  = nome;
            Email = email;
            Valor = valor;
        }

        public override string ToString()
        {
            return Nome + ", " + Email + ", " + Valor.ToString("F2",CultureInfo.InvariantCulture);
        }
       
    }
}
