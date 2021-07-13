using System;
using System.Globalization;
namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            Console.WriteLine();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as notas do aluno: ");
            Console.WriteLine();
            Console.Write("Nota 1: ");
            Console.WriteLine();
            aluno.n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Nota 2: ");
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Nota 3: ");
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota final: " +  aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine(aluno);
        }
    }
}
