using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item1.Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //var funcionario = new Funcionario();
            //funcionario.salario = 1000;

            //funcionario.Salario = 1000;

            //var funcionario = new Funcionario(1000);

            var funcionario = new Funcionario(1000, 150);
            Console.WriteLine(funcionario.SalarioLiquido);
            //funcionario.Descontos = 180;

            //Console.WriteLine(funcionario.SalarioMinimo);
            Console.WriteLine(Funcionario.SalarioMinimo);

        }
    }

    //class Funcionario
    //{
    //    public decimal salario;
    //}


    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //        set
    //        {
    //            salario = value;
    //        }
    //    }
    //}



    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //            }
    //            salario = value;
    //        }
    //    }
    //}



    //class Funcionario
    //{
    //    private decimal salario;

    //    public decimal Salario { get => salario; set => salario = value; }
    //}

    //class Funcionario
    //{
    //    public decimal Salario { get; set; }
    //}

    //class Funcionario
    //{
    //    private readonly decimal salario;
    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //    }

    //    public Funcionario(decimal salario)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //    }
    //}

    //class Funcionario
    //{
    //    private readonly decimal salario;
    //    private readonly decimal descontos;
    //    public decimal Salario
    //    {
    //        get
    //        {
    //            return salario;
    //        }
    //    }

    //    public Funcionario(decimal salario, decimal descontos)
    //    {
    //        if (salario < 0)
    //        {
    //            throw new ArgumentOutOfRangeException("salário não pode ser negativo");
    //        }
    //        this.salario = salario;
    //        this.descontos = descontos;
    //    }

    //    public decimal SalarioLiquido
    //    {
    //        get
    //        {
    //            return salario - descontos;
    //        }
    //    }
    //}

    class Funcionario
    {
        private static readonly decimal salarioMinimo = 700;
        private readonly decimal salario;
        private decimal descontos;
        public decimal Salario
        {
            get
            {
                return salario;
            }
        }

        public Funcionario(decimal salario, decimal descontos)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            }
            this.salario = salario;
            this.descontos = descontos;
        }

        public decimal SalarioLiquido
        {
            get
            {
                return salario - descontos;
            }
        }

        public decimal Descontos
        {
            get
            {
                return descontos;
            }
            private set
            {
                descontos = value;
            }
        }

        public static decimal SalarioMinimo
        {
            get
            {
                return salarioMinimo;
            }
        }
    }
}


