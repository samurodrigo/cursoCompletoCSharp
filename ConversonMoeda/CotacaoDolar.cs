using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorMoeda
{
    class CotacaoDolar
    {
        static double IOF = 6.0;
        public static double ConverteEmReais(double valorDolarEmReais, double quantidade)
        {
            double total =  valorDolarEmReais * quantidade;
            return total + ((total * IOF) / 100);
        }
    }
}
