using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio03
{
    internal class Cilindro
    {
        public int raio;
        public int altura;

        public double CalculaVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}
