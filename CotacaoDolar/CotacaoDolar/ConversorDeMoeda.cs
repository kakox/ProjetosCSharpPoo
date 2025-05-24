

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double ValorEmReais(double cotacao, double qtdDolar)
        {
            double valorBruto = cotacao * qtdDolar;
            double valorTotal = valorBruto + (valorBruto * IOF);
            return valorTotal;
        }

       
    }
}
