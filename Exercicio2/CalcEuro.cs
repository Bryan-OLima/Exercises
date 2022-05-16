using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_EuroParaReais
{
    internal class CalcEuro
    {
        double Euro { get; set; }
        double EuroCot { get; set; } 

        public CalcEuro(double euro, double euroCot)
        {
            Euro = euro;
            EuroCot = euroCot;
            
        }

        public double Calcular()
        {
            return Euro * EuroCot;
        }

    }
}