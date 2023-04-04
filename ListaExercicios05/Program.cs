using ListaExercicios05.Exercicio01;

namespace ListaExercicios05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();
            caixa.altura = 10;
            caixa.largura = 10;
            caixa.comprimento = 10;
            Console.WriteLine("Volume: " + caixa.CalculaVolume());
        }
    }
}