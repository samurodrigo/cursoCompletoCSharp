using System;
using System.Globalization;
namespace CalculadoraSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****| Calculadora de salário |****");
            Console.WriteLine("Qual o numero do funcionario?");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o número de horas trabalhadas?");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o salário por hora?");
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salarioHora * horasTrabalhadas;

            Console.WriteLine("Number = " + numeroFuncionario);
            Console.WriteLine($"Salário = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
