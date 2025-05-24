
using System;
using System.Globalization;


namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação atual do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você deseja comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double a = ConversorDeMoeda.ValorEmReais(cotacaoDolar, qtdDolar);

            Console.WriteLine("Valor a ser pago em reais = " + a.ToString("F2", CultureInfo.InvariantCulture));

        }


    }

}

