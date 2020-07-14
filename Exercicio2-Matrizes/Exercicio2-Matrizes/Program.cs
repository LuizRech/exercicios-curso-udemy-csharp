using System;

namespace Exercicio2_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de Linhas e Colunas");

            string[] matSize = Console.ReadLine().Split(' ');

            int[,] mat = new int [int.Parse(matSize[0]), int.Parse(matSize[1])];

            for(int i = 0; i < int.Parse(matSize[0]); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < int.Parse(matSize[1]); j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Informe um número dentro da matriz");

            int search = int.Parse(Console.ReadLine());


            for (int i = 0; i < int.Parse(matSize[0]); i++)
            {
                for (int j = 0; j < int.Parse(matSize[1]); j++)
                {
                    if(mat[i, j] == search)
                    {
                        Console.WriteLine("Position: " + i + " " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }
                        if (j+1 < int.Parse(matSize[1]))
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Top: " + mat[(i - 1), j]);
                        }
                        if (i + 1 < int.Parse(matSize[0]))
                        {
                            Console.WriteLine("Bot: " + mat[(i + 1), j]);
                        }
                       
                    }
                }
            }
        }
    }
}
