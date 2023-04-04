namespace ListaExercicios05.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.grauCelsius = 0;
            Console.WriteLine("Graus Fahrenheit: "+temperatura.ConverteGrauCelisusFahrenheit());
        }
    }
}