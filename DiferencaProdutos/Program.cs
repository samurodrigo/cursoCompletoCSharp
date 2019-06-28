using System;

namespace DiferencaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******| Diferença de produtos |******");
            Console.WriteLine("Digite o numero A:");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite no numero B:");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero C:");
            int numC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero D:");
            int numD = int.Parse(Console.ReadLine());

            int diferenca = (numA * numB) - (numC * numD);

            Console.WriteLine("Diferenca = " + diferenca);
        }
    }
}
