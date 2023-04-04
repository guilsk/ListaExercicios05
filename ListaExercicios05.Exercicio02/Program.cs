namespace ListaExercicios05.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.grauFahrenheit = 32;
            

            Console.WriteLine("Grau em Celsius:" + temperatura.ConverteGrauFarenheitCelsius());
        }
    }
}