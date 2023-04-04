namespace ListaExercicios05.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 3;
            cilindro.altura = 2;

            Console.WriteLine("Volume Cilindro: " + cilindro.CalculaVolume());
        }
    }
}