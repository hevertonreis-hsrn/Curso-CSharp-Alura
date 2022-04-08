using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 574809),
                null,
                new ContaCorrente(432, 376562),
                new ContaCorrente(343, 498280),
                null,
                null,
                new ContaCorrente(204, 498280)
            };

            //contas.Sort();

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var listaSemNulos = new List<ContaCorrente>();

            /*
            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    listaSemNulos.Add(conta);
                }
            }
            */

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);
            
            /*
            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }
            */

            Console.WriteLine();
            Console.WriteLine();

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Guilherme",
                "Wellington",
                "Luana",
                "Ana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            var idades = new List<int>();

            idades.Add(5);
            idades.Add(1);
            idades.Add(5);
            idades.Add(78);


            idades.Remove(5);
            //idades.Remove(5);
            idades.AddRange(new int[] { 1, 2, 3, 9 });

            idades.AdicionarVarios(1, 5687, 1987, 1567, 987);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
        static void TestaString()
        {
            // --------------- Trabalhando com Datas -----------------
            //DateTime dataFimPagamento = new DateTime(2022,2,23);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente;

            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(dataCorrente);

            //string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            //Console.WriteLine(mensagem);
            //----------------------------------------------------------

            //---------------- Trabalhando com Strings 1 ------------
            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de 'moedaDestino': " + valor);

            //string valorOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de 'moedaOrigem': " + valorOrigem);

            //Console.WriteLine("Valor de 'valor': " + extratorDeValores.GetValor("VALOR"));
            // --------------------------------------------------------------

            // --------------- Trabalhando com Strings 2 -----------------
            //string urlTeste = "http://www.bytebank.com/cambio";
            //int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            //Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio/"));

            //Console.WriteLine(urlTeste.Contains("ByteBank"));
            // ------------------------------------------------------------

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            ContaCorrente conta = new ContaCorrente(456, 687876);

            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(456, 87654);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.WriteLine(resultado);
        }
        static void TestaVoid()
        {
            int[] idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];

                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 11111111);

            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));

            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 5679787), new ContaCorrente(874, 5679787));


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia}/{itemAtual.Numero}");
            }
        }

    }
}