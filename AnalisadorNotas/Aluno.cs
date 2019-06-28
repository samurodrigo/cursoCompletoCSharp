using System;
using System.Globalization;

namespace AnalisadorNotas
{
    internal class Aluno
    {
        private string _Nome;
        private double _N1;
        private double _N2;
        private double _N3;
        private readonly double NOTA_MINIMA = 60;

        public Aluno(string nome, double n1, double n2, double n3)
        {
            _Nome = nome;
            _N1 = n1;
            _N2 = n2;
            _N3 = n3;
        }

        public double ObterNotaFinal()
        {
            return _N1 + _N2 + _N3;
        }

        public bool AlunoAprovado()
        {
            return ObterNotaFinal() >= NOTA_MINIMA;
        }

        public double ObterPontosFaltantes()
        {
            double notaFaltante = NOTA_MINIMA - ObterNotaFinal();

            if (notaFaltante < 0)
                notaFaltante = 0;

            return notaFaltante;
        }

        public override string ToString()
        {
            string dados = $"NOTA FINAL = {ObterNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                           (AlunoAprovado() ? "APROVADO" : "REPROVADO") + "\n";

            if (!AlunoAprovado())
            {
                dados += $"FALTAM {ObterPontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }

            return dados;
        }
    }
}