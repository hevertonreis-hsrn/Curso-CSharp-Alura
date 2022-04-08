using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3900.0;

        if (salario > 3751.0 && salario <= 4664.00)
        {
            Console.WriteLine("Sua alíquota é de 22.5% e pode deduzir R$ 636.");
        }
        else if (salario > 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("Sua alíquota é de 15% e pode deduzir R$ 350.");
        }
        else if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Sua alíquota é de 7.5% e pode deduzir na declaração o valor de R$ 142.");
        }

        Console.ReadLine();
    }
}