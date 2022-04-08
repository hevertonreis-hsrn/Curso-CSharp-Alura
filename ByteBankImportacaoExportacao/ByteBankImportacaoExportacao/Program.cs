using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //CriarArquivo();
            //CriarArquivoComWriter();
            //TestaEscrita();

            //using (var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //using (var escritor = new StreamWriter(fs))
            //{
            //    escritor.WriteLine(true);
            //    escritor.WriteLine(false);
            //    escritor.WriteLine(5646545645);
            //}

            //EscritaBinaria();

            //LeituraBinaria();

            //UsarStreamDeEntrada();

            //--------------------------------------------
            //Console.WriteLine("Digite o seu nome:");
            //var nome = Console.ReadLine();
            //
            //Console.WriteLine(nome);
            //--------------------------------------------

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("Aplicação finalizada!!!");

            Console.ReadLine();
        }

    }
}
