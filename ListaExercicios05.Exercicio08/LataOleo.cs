using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio08
{
    internal class LataOleo
    {
        public int raio;
        public int altura;

        public double CalculaVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}
