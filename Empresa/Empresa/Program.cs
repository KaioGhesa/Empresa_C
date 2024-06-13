using System;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas funcionarios tem registrados?: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("Funcionario # " + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionario que você quer um aumento de salario: ");
            int searchID = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == searchID);
            if(func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("ID não encontrado!!! ");
            }
            Console.WriteLine();
            Console.WriteLine("Mostrando a lista de colaboradores: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
