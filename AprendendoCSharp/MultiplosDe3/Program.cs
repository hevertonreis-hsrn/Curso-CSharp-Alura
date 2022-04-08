using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio - Múltiplos de 3");


            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
