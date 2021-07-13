using System;
using System.Globalization;
namespace DadoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome do funcionario: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o salario bruto do funcionario: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Digite o valor do imposto:");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario:" + f );

            Console.WriteLine();
            Console.WriteLine("Digite o a porcentagem de aumento salarial:");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Aumentarsalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Os dados atualizados do Funcionario: " + f);
        }
    }
}
