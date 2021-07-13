using System;
using System.Globalization;
namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Diga o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Diga a idade da primeira pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga o salario da primeira pessoa: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Diga o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Diga a idade da segunda pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga o salario da segunda pessoa: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " é o mais velho");
            }
            else
            {
                Console.WriteLine(p2.Nome + " é o mais velho");
            }

            double media = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("A media de salario entre os dois é: " + media.ToString("F2",CultureInfo.InvariantCulture));
        }


    }
}
