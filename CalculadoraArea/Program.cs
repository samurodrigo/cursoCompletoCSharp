using System;
using System.Globalization;

namespace CalculadoraArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores separados por um espaço:");
            string[] valores = Console.ReadLine().Split(' ');

            double valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = (valorA * valorC) / 2;
            double areaCirculo = 3.14159 * Math.Pow(valorC, 2);
            double areaTrapezio = ((valorA + valorB) / 2) * valorC;
            double areaQuadrado = Math.Pow(valorB,2);
            double areaRetangulo = valorA * valorB;

            Console.WriteLine($"Triângulo: {areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Círculo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
