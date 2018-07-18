using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensaio
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse minhaClasse = new MinhaClasse();
            Console.WriteLine(minhaClasse.A);
            //Console.WriteLine(minhaClasse.B);
            Console.WriteLine(minhaClasse.C);
            //Console.WriteLine(minhaClasse.D);
            Console.WriteLine(minhaClasse.E);
        }
    }

    public class MinhaClasse
    {
        public MinhaClasse()
        {
            Console.WriteLine(this.A);
            Console.WriteLine(this.B);
            Console.WriteLine(this.C);
            Console.WriteLine(this.D);
            Console.WriteLine(this.E);
        }

        public int A { get; set; }
        protected int B { get; set; }
        protected internal int C { get; set; }
        private int D { get; set; }
        internal int E { get; set; }
    }

    public class ClasseDerivada : MinhaClasse
    {
        public ClasseDerivada()
        {
            Console.WriteLine(this.A);
            Console.WriteLine(this.B);
            Console.WriteLine(this.C);
            //Console.WriteLine(this.D);
            Console.WriteLine(this.E);
        }
    }
}
