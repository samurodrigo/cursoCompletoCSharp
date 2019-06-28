using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("******| Soma |*******");
            System.Console.WriteLine("Digite o primeiro numero:");
            int A = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo numero");
            int B = int.Parse(Console.ReadLine());

            int soma = A + B;

            System.Console.WriteLine($"A soma é {soma}");
        }
    }
}
