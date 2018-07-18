using Ensaio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topico1;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario(1000, 120);
            Console.WriteLine(funcionario.Descontos);
            Console.WriteLine(funcionario.Salario);
            Console.WriteLine(funcionario.SalarioLiquido);
            funcionario.RedefinirDescontos(150);
            Console.WriteLine(funcionario.SalarioLiquido);
            Console.WriteLine(Funcionario.SalarioMinimo);

            MinhaClasse minhaClasse = new MinhaClasse();
            Console.WriteLine(minhaClasse.A);
            //Console.WriteLine(minhaClasse.B);
            //Console.WriteLine(minhaClasse.C);
            //Console.WriteLine(minhaClasse.D);
            //Console.WriteLine(minhaClasse.E);
            Console.ReadKey();
        }
    }
}
