using System;

namespace Exercicio1_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMat = int.Parse(Console.ReadLine());

            int[,] mat = new int[sizeMat, sizeMat];

            Console.WriteLine("Digite os valores: ");

            for (int i = 0; i < sizeMat; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < sizeMat; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for(int i = 0; i < sizeMat; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < sizeMat; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }

            Console.Write("Main Diagonal: ");
            for (int i = 0; i < sizeMat; i++){
                for(int j = 0; j < sizeMat; j++)
                {
                    if(i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
        }
    }
}
