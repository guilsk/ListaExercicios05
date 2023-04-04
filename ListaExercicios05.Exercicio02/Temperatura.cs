using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio02
{
    internal class Temperatura
    {
        public int grauFahrenheit;

        public double ConverteGrauFarenheitCelsius()
        {
            return (grauFahrenheit - 32) / 1.8;
        }
    }
}
