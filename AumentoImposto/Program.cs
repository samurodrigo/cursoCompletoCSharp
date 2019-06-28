using System;
using System.Globalization;

namespace AumentoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados de um funcionário");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario f = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine(f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagemAumento);
            Console.WriteLine(f);

        }
    }
}
