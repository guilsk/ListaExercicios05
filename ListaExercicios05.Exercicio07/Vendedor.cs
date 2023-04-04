using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio07
{
    internal class Vendedor
    {
        public double salarioBase;
        public int totalVendas;
        public double comissao;

        public double CalculaSalario()
        {
            return salarioBase + (totalVendas * (comissao / 100));
        }
    }
}
