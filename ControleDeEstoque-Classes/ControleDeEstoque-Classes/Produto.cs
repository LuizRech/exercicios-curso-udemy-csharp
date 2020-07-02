using System;
using System.Globalization;

namespace ControleDeEstoque_Classes
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double TotalEmEstoque(){
            return Quantidade * Preco;
        }

        public void AddProduto(int quantidade){
            Quantidade += quantidade;
        }
        public void DelProduto(int quantidade){
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, valor total em estoque: $ "
                + TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
