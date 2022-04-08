using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000.0;
            double fatorRendimento = 1.0036;
            int contadorAno;

            for (contadorAno = 1; contadorAno <= 5; contadorAno++)
            {                
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;

                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Tempo de investimento foi de " + contadorAno + " anos");
            Console.WriteLine("Após o término do investimento você terá R$ " + valorInvestido);


            Console.ReadLine();
        }
    }
}
