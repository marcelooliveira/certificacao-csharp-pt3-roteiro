﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico5
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno()
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            var aluno2 = new Aluno()
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            var aluno3 = new Aluno()
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));

            var aluno4 = new Aluno()
            {
                Nome = "ANDRÉ DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            var aluno5 = new Aluno()
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1);
            Console.WriteLine(aluno2);
            Console.WriteLine(aluno3);
            Console.WriteLine(aluno4);
            Console.WriteLine(aluno5);

            var alunos = new List<Aluno>
                { aluno1, aluno2, aluno3, aluno4, aluno5};

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Sort();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadKey();
        }
    }

    //class Aluno
    //{
    //    public string Nome { get; set; }
    //    public DateTime DataNascimento { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome: {Nome}, Nascimento: {DataNascimento}";
    //    }
    //}


    //class Aluno
    //{
    //    public string Nome { get; set; }
    //    public DateTime DataNascimento { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome: {Nome}, Nascimento: {DataNascimento}";
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        Aluno outro = obj as Aluno;
    //        if (outro == null)
    //        {
    //            return false;
    //        }

    //        return outro.Nome.Equals(this.Nome);
    //    }
    //}

    //class Aluno
    //{
    //    public string Nome { get; set; }
    //    public DateTime DataNascimento { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome: {Nome}, Nascimento: {DataNascimento}";
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        Aluno outro = obj as Aluno;
    //        if (outro == null)
    //        {   
    //            return false;
    //        }

    //        return outro.Nome.Equals(this.Nome, StringComparison.CurrentCultureIgnoreCase);
    //    }

    //    public override int GetHashCode()
    //    {
    //        return this.Nome.GetHashCode();
    //    }
    //}

    //class Aluno
    //{
    //    public string Nome { get; set; }
    //    public DateTime DataNascimento { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome: {Nome}, Nascimento: {DataNascimento}";
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        Aluno outro = obj as Aluno;
    //        if (outro == null)
    //        {
    //            return false;
    //        }

    //        return outro.Nome.Equals(this.Nome, StringComparison.CurrentCultureIgnoreCase)
    //            && outro.DataNascimento.Equals(this.DataNascimento);
    //    }

    //    public override int GetHashCode()
    //    {
    //        var hashCode = -1523756618;
    //        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
    //        hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
    //        return hashCode;
    //    }
    //}



    //class Aluno : IComparable
    //{
    //    public string Nome { get; set; }
    //    public DateTime DataNascimento { get; set; }

    //    public override string ToString()
    //    {
    //        return $"Nome: {Nome}, Nascimento: {DataNascimento}";
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        Aluno outro = obj as Aluno;
    //        if (outro == null)
    //        {
    //            return false;
    //        }

    //        return outro.Nome.Equals(this.Nome, StringComparison.CurrentCultureIgnoreCase)
    //            && outro.DataNascimento.Equals(this.DataNascimento);
    //    }

    //    public override int GetHashCode()
    //    {
    //        var hashCode = -1523756618;
    //        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
    //        hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
    //        return hashCode;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        Aluno outro = obj as Aluno;
    //        return this.DataNascimento.CompareTo(outro.DataNascimento);
    //    }
    //}



    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Nascimento: {DataNascimento}";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }

            return outro.Nome.Equals(this.Nome, StringComparison.CurrentCultureIgnoreCase)
                && outro.DataNascimento.Equals(this.DataNascimento);
        }

        public override int GetHashCode()
        {
            var hashCode = -1523756618;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                throw new ArgumentException("Objeto não é um aluno");
            }

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if (resultado == 0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }

            return resultado;
        }
    }
}


