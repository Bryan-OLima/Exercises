using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Bem vindo ao sistema da faculdade FACUL IDADE!");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();

            Console.Write("Digite a idade do aluno mais jovem: ");
            int youngerStd = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do aluno mais velho: ")
            int olderStd = int.Parse(Console.ReadLine());
            double avgAge = (youngerStd + olderStd) / 2;

            Console.WriteLine($"A média de idade entre os alunos na FACUL IDADE é: {avgAge}");
        }
    }
}
