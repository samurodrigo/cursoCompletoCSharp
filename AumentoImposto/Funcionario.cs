using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AumentoImposto
{
    class Funcionario
    {
        private string _Nome;
        private double _SalarioBruto;
        private double _Imposto;

        public Funcionario(string Nome, double SalarioBruto, double Imposto)
        {
            _Nome = Nome;
            _SalarioBruto = SalarioBruto;
            _Imposto = Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            _SalarioBruto += (_SalarioBruto * porcentagem) / 100;
        }

        public double SalarioLiquido()
        {
            return _SalarioBruto - _Imposto;
        }

        public override string ToString()
        {
            return $"\nFuncionário: {_Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
