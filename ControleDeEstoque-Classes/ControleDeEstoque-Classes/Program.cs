using System;
using System.Globalization;

namespace ControleDeEstoque_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(p);

            Console.WriteLine("Adicionar qtd no estoque: ");
            int addqtd = int.Parse(Console.ReadLine());
            p.AddProduto(addqtd);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Remover qtd no estoque: ");
            int delqtd = int.Parse(Console.ReadLine());
            p.DelProduto(delqtd);

            Console.WriteLine("Dados atualizados: " + p);
        
        }
    }
}
