using System;
using System.Globalization;
namespace Raio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********| Cálculo de Área do circulo |************");
            System.Console.WriteLine("Digite o raio do circulo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            System.Console.WriteLine("Área = " + area);
        }
    }
}
