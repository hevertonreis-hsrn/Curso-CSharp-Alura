﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            //ListExtensoes<int>.AdicionarVarios(idades, 34,45,56);
            idades.AdicionarVarios(34, 45, 56);

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");

            //ListExtensoes<string>.AdicionarVarios(nomes, "Pedro", "Lucas");
            nomes.AdicionarVarios("Pedro", "Lucas");
        }
    }
}
