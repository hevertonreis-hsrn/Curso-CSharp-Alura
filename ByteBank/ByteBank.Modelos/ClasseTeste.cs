using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado();
            //teste.MetodoProtegido();
            teste.MetodoInterno();
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            // Visível fora da classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            // Visível fora da classe "ModificadoresTeste"
        }

        internal void MetodoInterno()
        {
            // Visível apena spara o projeto ByteBank.Modelos
        }
    }
}
