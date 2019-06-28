using System;
using System.Globalization;

namespace Entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com seu nome completo;");
            string nome = System.Console.ReadLine();

            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre seu último nome, idade e altura (mesma linha, separado por espaco)");
            string[] dados = System.Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco);
            System.Console.WriteLine(ultimoNome);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura);

        }
    }
}
