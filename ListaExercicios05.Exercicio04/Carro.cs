using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio04
{
    internal class Carro
    {
        public int consumoCombustivel;
        public int kmInicial;
        public int kmFinal;

        public double CalculaConsumo()
        {
            return (kmFinal - kmInicial) / consumoCombustivel;
        }
    }
}
