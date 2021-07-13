using System;
using System.Globalization;
namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Quantos dolares você vai comprar?");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor ser pago em reais: " + ConversorMoeda.CompraDolar(quantidade,cotacao).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
