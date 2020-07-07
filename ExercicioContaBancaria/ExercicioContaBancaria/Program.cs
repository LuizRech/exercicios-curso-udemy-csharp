using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta = new Banco();

            Console.Write("Entre o numero da conta: ");
            int nroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá um depósito inicial? (s/n) ");
            char depInicial = char.Parse(Console.ReadLine());

            if(depInicial == 's'){
                Console.Write("Entre o valor de depósito inicial: ");
                double valDepInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Banco(nroConta, titularConta, valDepInicial);
            }else{
                conta = new Banco(nroConta, titularConta);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);


            Console.Write("Entre um valor para o depósito: ");
            double deposito = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para o saque: ");
            double saque = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
