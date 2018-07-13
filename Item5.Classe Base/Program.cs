using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };

            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();


            Cliente cliente = new Cliente()
            {
                CPF = "789.456.123-99",
                Nome = "maria de souza",
                DataNascimento = new DateTime(1995, 1, 1),
                UltimaCompra = new DateTime(2018, 2, 3),
                ValorUltimaCompra = 1000
            };

            //Pessoa pessoa = new Pessoa()
            //{
            //    CPF = "000.111.222-33",
            //    Nome = "fulano de tal",
            //    DataNascimento = new DateTime(1998, 4, 5)
            //};

            Console.ReadKey();
        }
    }

    interface IFuncionario : IPessoa
    {
        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    interface IPlantonista
    {
        void GerarCracha();
        int CargaHorariaMensal { get; set; }
    }

    class Funcionario : Pessoa, IFuncionario, IPlantonista
    {
        public event EventHandler CrachaGerado;

        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        int IFuncionario.CargaHorariaMensal { get; set; }
        int IPlantonista.CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }

    sealed class Cliente : Pessoa
    {
        public DateTime UltimaCompra { get; set; }
        public decimal ValorUltimaCompra { get; set; }
    }

    //class ClienteEspecial: Cliente
    //{

    //}

    abstract class Pessoa : IPessoa
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    interface IPessoa
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }
    }
}
