using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade. Pode entrar.");    
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João é menor de idade. Não pode entrar.");
                }
                
            }

            Console.ReadLine();
        }
    }
}
