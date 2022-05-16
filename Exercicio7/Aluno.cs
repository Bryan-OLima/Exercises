using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoObj
{
    internal class Aluno
    {
        double Nota1 { get; set; }
        double Nota2 { get; set; }
        double Nota3 { get; set; }
        double Nota4 { get; set; }

        public Aluno (double nota1, double nota2, double nota3, double nota4)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }

        public double CalculaMedia()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }

    }
}