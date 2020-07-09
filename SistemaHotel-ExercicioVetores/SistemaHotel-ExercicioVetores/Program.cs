using System;
using System.Linq;

namespace SistemaHotel_ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos vao ser alugados?");
            int quartosAlugados = int.Parse(Console.ReadLine());

            Cliente[] cl = new Cliente[10];

            for (int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine("Cliente #"+ (i + 1) +":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int nroQuarto = int.Parse(Console.ReadLine());

                cl[nroQuarto] = new Cliente { Email = email, Nome = nome };
            }

            for (int i = 0; i < 10; i++){
                if(cl[i] != null)
                {
                    Console.WriteLine( i + ": " + cl[i]);
                }
            }
        }
    }
}
