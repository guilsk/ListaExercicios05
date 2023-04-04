namespace ListaExercicios05.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataOleo lataOleo = new LataOleo();
            lataOleo.altura = 7;
            lataOleo.raio = 1;
            Console.WriteLine("Volume: " + lataOleo.CalculaVolume());
        }
    }
}