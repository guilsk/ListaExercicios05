using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio06
{
    internal class Temperatura
    {
        public int grauCelsius;

        public double ConverteGrauCelisusFahrenheit()
        {
            return (grauCelsius * 1.8) + 32;
        }
    }
}
