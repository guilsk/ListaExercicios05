using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio09.Exercicio10
{
    internal class Aluno
    {
        public int nota1;
        public int nota2;
        public int peso1;
        public int peso2;

        
        public double CalculaMediaHarmonica()
        {
            double x = 1.0 / nota1;
            double y = 1.0 / nota2;
            return 2.0 / (x + y);
        }

        public double CalculaMediaPonderada()
        { 
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}
