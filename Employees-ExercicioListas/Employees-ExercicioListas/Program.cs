using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Employees_ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incrementou = false;

            Console.Write("Quantos empregados serão registrados? ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            List<Employees> emp = new List<Employees>();

            for(int i = 0; i < qtdEmployee; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.Add(new Employees { Id = id, Name = name, Salary = salary });
            }


            Console.Write("Selecione o ID do funcionario que recebera aumento: ");
            int idIncrements = int.Parse(Console.ReadLine());
            
            /*
            foreach (Employees idx in emp)
            {
                
                if(idx.Id == idIncrements)
                {
                    Console.Write("Porcentagem do aumento: ");
                    double incrementsValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    idx.IncrementSalary(incrementsValue);
                    incrementou = true;



                }
            }

            if(incrementou == false)
            {
                Console.WriteLine("Esse ID nao existe");
            }

            Console.WriteLine("Lista de empregados atualizada: ");
            */

            Employees list = emp.Find(x => x.Id == idIncrements);

            if(list != null)
            {
                Console.Write("Porcentagem do aumento: ");
                double incrementsValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                
                list.IncrementSalary(incrementsValue);
            }
            else
            {
                Console.WriteLine("Esse ID nao existe");
            }
            foreach (Employees idx in emp)
            {
                Console.WriteLine(idx);
            }

        }
    }
}
