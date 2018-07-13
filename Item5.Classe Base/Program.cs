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
            //Uma interface não pode ser instanciada diretamente
            //IPessoa pessoa = new IPessoa();

            //IPessoa pessoa = new Pessoa();
            //pessoa.CPF = "123.456.789-00";
            //pessoa.Nome = "josé da silva";
            //pessoa.DataNascimento = new DateTime(2000, 1, 1);
            //pessoa.CrachaGerado += (s, e) =>
            //{
            //    Console.WriteLine("Crachá gerado");
            //};
            //pessoa.GerarCracha();






            //IPessoa pessoa = new Pessoa
            //{
            //    CPF = "123.456.789-00",
            //    Nome = "josé da silva",
            //    DataNascimento = new DateTime(2000, 1, 1)
            //};
            ////pessoa.CargaHorariaMensal = 168;
            ////pessoa.EfeturarPagamento();
            //pessoa.CrachaGerado += (s, e) =>
            //{
            //    Console.WriteLine("Crachá gerado");
            //};
            //pessoa.GerarCracha();





            //IPessoa pessoa = new Funcionario(1500)
            //{
            //    CPF = "123.456.789-00",
            //    Nome = "josé da silva",
            //    DataNascimento = new DateTime(2000, 1, 1)
            //};
            //pessoa.CargaHorariaMensal = 168;
            //pessoa.EfeturarPagamento();
            //pessoa.CrachaGerado += (s, e) =>
            //{
            //    Console.WriteLine("Crachá gerado");
            //};
            //pessoa.GerarCracha();


            //Funcionario pessoa = new Funcionario(1500)
            //{
            //    CPF = "123.456.789-00",
            //    Nome = "josé da silva",
            //    DataNascimento = new DateTime(2000, 1, 1)
            //};
            //pessoa.CargaHorariaMensal = 168;
            //pessoa.EfeturarPagamento();
            //pessoa.CrachaGerado += (s, e) =>
            //{
            //    Console.WriteLine("Crachá gerado");
            //};
            //pessoa.GerarCracha();


            Funcionario funcionario = new Funcionario(1500);
            var pessoa = (IPessoa)funcionario;
            pessoa.CPF = "123.456.789-00";
            pessoa.Nome = "josé da silva";
            pessoa.DataNascimento = new DateTime(2000, 1, 1);
            funcionario.CargaHorariaMensal = 168;
            funcionario.EfeturarPagamento();
            pessoa.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            pessoa.GerarCracha();

            Console.ReadKey();
        }
    }

    interface IPessoa
    {
        //propriedades
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        //métodos
        void GerarCracha();

        //eventos
        event EventHandler CrachaGerado;
    }

    abstract class Pessoa : IPessoa
    {
        string IPessoa.CPF { get; set; }
        string IPessoa.Nome { get; set; }
        DateTime IPessoa.DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        void IPessoa.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }
    }

    sealed class Funcionario : Pessoa
    {
        public decimal Salario { get; }
        public int CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }
}
