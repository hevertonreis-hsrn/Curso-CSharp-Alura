using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula poupança");

            double valorInvestido = 1000.0;
            //int contadorMes;

            for(int contadorMes = 1; contadorMes <= 12;  contadorMes++)
            {
                valorInvestido *= 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês(es), você terá R$ " + valorInvestido);
                
            }

            Console.ReadLine();
        }
    }
}
