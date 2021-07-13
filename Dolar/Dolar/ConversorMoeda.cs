using System.Globalization;
namespace Dolar
{
    class ConversorMoeda
    {
        public static double Iof = 6;
        public static double CompraDolar(double quantidade,double DolarAmericano)
        {
            double total = quantidade * DolarAmericano;
            return total + total * Iof / 100;
          
        }
    }
}
