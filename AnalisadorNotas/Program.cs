using System;
using System.Globalization;

namespace AnalisadorNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite tres notas para o aluno: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, n1, n2, n3);

            Console.WriteLine(aluno);
        }
    }
}
