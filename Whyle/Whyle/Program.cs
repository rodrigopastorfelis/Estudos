using System;

namespace Whyle
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            Console.WriteLine("Digite os valores das vendas, quando quiser cancelar digite o valor como 0");
            int n1  = int.Parse(Console.ReadLine());
            while (n1 != 0)
            {
                soma += n1;
                n1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
        }
    }
}
