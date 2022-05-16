using System;
using System.Globalization;
using Ex_02_EuroParaReais;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sejam bem vindos ao sistema de conversão do euro!");
            Console.WriteLine();

            Console.Write("Digite a cotação atual do Euro (Em reais): ");
            double euroCot = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite quantos euros deseja converter: ");
            double euro = double.Parse(Console.ReadLine());

            CalcEuro p = new CalcEuro(euro, euroCot);

            Console.WriteLine("O valor em reais é: R$ " + p.Calcular().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
