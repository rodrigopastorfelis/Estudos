using System;
using System.Globalization;
namespace CalculosRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();

            Console.WriteLine("Entre com a largura do retangulo: ");
            p.largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Entre com a altura do retangulo: ");
            p.altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            double area = p.Area();
            Console.WriteLine("A area é = " + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine();
            double perimetro = p.Perimetro();
            Console.Write("O Perimetro é = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            double diagona = p.Diagonal();
            Console.Write("A Diagonal é = " + diagona.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
