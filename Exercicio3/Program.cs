using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vendedor! Bem vindo ao sistema de Comissão da NOSSA CONCESSIONARIA!");
            Console.WriteLine();

            Console.Write("Por favor, insira o valor do veículo: ");
            double sellPrice, comValue;
            sellPrice = double.Parse(Console.ReadLine());
            comValue = sellPrice * 0.05;

            Console.WriteLine("O valor da comissão é: R$ " + comValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
