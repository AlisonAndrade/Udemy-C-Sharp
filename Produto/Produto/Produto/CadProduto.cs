using System;
using System.Globalization;

namespace Produto
{
    class CadProduto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantAdic)
        {

            Quantidade = Quantidade + quantAdic;

            // as duas maneiras serve
            //Quantidade += quantAdic;
        }

        public void RemoverProdutos(int quantRemov)
        {

            Quantidade = Quantidade - quantRemov;

            // as duas maneiras serve
            //Quantidade -= quantRemov;
        }

        public override String ToString()
        {
            return
                Nome
                + " | Preço R$ "
                + (Preco.ToString("F2"))
                + " | Quantidade: "
                + Quantidade
                + " Unidades | Total R$: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
