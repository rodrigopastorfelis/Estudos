using System.Globalization;
namespace NotasAluno
{
    class Aluno
    {
        public string Nome;
        public double n1, n2, n3;


        public double NotaFinal()
        {
            return n1 + n2 + n3/3;
        }

        public bool Aprovado()
        {
            if (NotaFinal()>= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            double pontos = 60 - NotaFinal();
            if (Aprovado() == true )
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado, "
                    + pontos.ToString("F2", CultureInfo.InvariantCulture)
                    + "  pontos faltaram para a aprovação";
            }
            
        }
    }
}
