
using System.Globalization;

namespace DadoFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;        

        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }

        public double Aumentarsalario(double AumentoSalarial)
        {
            double aumento = SalarioBruto * (AumentoSalarial / 100);
            return SalarioBruto =  aumento + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome +
                ", salario liquido: R$" +
                SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
