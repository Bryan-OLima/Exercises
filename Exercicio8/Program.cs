using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a, b;
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            double res = a - b;

            if (res < 0)
            {
                Console.WriteLine($"O valor {res} é NEGATIVO!");
            }
            else
            {
                Console.WriteLine($"O valor {res} é POSITIVO!");
            }
        }
    }
}
