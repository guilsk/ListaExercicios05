using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio05
{
    internal class Esfera
    {
        public int raio;
        public double CalculaVolume()
        {
            return 4 * Math.PI * Math.Pow(raio, 3) / 3;
        }
    }
}
