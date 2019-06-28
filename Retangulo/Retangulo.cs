using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculosRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"AREA: {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"PERÍMETRO: {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"DIAGONAL: {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
