using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em graus Celsius: ");
            double cDeg = double.Parse(Console.ReadLine());
            double fDeg = (9 * cDeg + 160) / 5;

            Console.WriteLine($"A temperatura de graus Celsius para Fahrenheit é: {fDeg}°F.");
        }
    }
}
