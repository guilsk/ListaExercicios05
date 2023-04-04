namespace ListaExercicios05.Exercicio09.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 10;
            aluno.nota2 = 5;
            aluno.peso1 = 5;
            aluno.peso2 = 3;

            Console.WriteLine("Média Harmônica: " + aluno.CalculaMediaHarmonica());
            Console.WriteLine("Média Ponderada: " + aluno.CalculaMediaPonderada());
            

        }
    }
}