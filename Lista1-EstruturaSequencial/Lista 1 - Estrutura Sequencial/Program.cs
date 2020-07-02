using System;
using System.Globalization;

namespace Lista_1___Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1

            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa

            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int res = n1 + n2;
            Console.WriteLine("SOMA = " + res);
            */

            //Exercício 2

            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais.

            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159

            /*
            double raio, res;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            res = 3.14159 * (raio * raio);

            Console.WriteLine("A="+res.ToString("F4", CultureInfo.InvariantCulture));
            */

            //Exercício 3

            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            /*
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + dif);
            */

            //Exercício 4

            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.

            int nro_funcionario;
            double hrs, val_hr, sal;

            nro_funcionario = int.Parse(Console.ReadLine());
            hrs = double.Parse(Console.ReadLine());
            val_hr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            sal = (hrs * val_hr);

            Console.WriteLine("FUNCIONARY = " + nro_funcionario);
            Console.WriteLine("SALARY U$ = " + sal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
