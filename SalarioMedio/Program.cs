using System;
using System.Globalization;

namespace SalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***| Quem tem o mairo salário? |***");
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            Console.WriteLine("Digite o nome do primeiro funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do primeiro funcionario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do segundo funcionario: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
