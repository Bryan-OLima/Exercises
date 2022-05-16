using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, idealWeight;
            Console.Write("Informe o valor de sua altura: ");
            height = double.Parse(Console.ReadLine());

            idealWeight = (72.7 * height) - 58;

            Console.WriteLine($"Seu peso ideal é: {idealWeight}");
        }
    }
}
