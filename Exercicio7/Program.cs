using System;
using AlunoObj;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno: ");
            nota4 = double.Parse(Console.ReadLine());

            Aluno student = new Aluno(nota1, nota2, nota3, nota4);

            double res = student.CalculaMedia();

            if (res > 7)
            {
                Console.WriteLine("Aluno APROVADO!");
                Console.WriteLine($"Nota: {res}");
            }
            else
            {
                Console.WriteLine("Aluno REPROVADO! ");
                Console.WriteLine($"Nota: {res}");
            }
        }
    }
}
