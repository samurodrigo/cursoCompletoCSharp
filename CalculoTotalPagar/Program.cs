using System;
using System.Globalization;
namespace CalculoTotalPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***| Calculo de total a pagar |***");
            Console.WriteLine("Digite o codigo, quantidade e valor da peça 1 (separado por um espaço):");
            string[] peca1 =  Console.ReadLine().Split(' ');
            Console.WriteLine("Digite o codigo, quantidade e valor da peça 2 (separado por um espaço):");
            string[] peca2 = Console.ReadLine().Split(' ');

            double totalPeca1 = double.Parse(peca1[2],CultureInfo.InvariantCulture) * int.Parse(peca1[1]);
            
            double totalPeca2 = double.Parse(peca2[2],CultureInfo.InvariantCulture) * int.Parse(peca2[1]);

            double soma = totalPeca1 + totalPeca2;
            
            Console.WriteLine("Valor total a pagar = R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
