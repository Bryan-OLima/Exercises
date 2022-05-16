using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em graus Fahrenheit: ");
            double fDeg = double.Parse(Console.ReadLine());
            double cDeg = (fDeg - 32) * 5 / 9;

            Console.WriteLine($"A temperatura de graus  Fahrenheit para Celsius é: {cDeg}°C.");
        }
    }
}
