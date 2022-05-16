using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a, b;
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0)
            {
                double res = a % b;
                Console.WriteLine($"O resto da divisão entre {a} e {b} é: {res}");
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
        }
    }
}
