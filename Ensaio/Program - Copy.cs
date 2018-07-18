//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ensaio
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Para instanciar essa classe, criamos uma variável funcionario:

//            Funcionario funcionario = new Funcionario();
//            //E para definir o seu salário, atribuímos com o operador “=”.
//            //funcionario.salario = 1000;
//            //Para imprimir o salário, basta usar o método Console.WriteLine:
//            //Console.WriteLine(funcionario.salario);
//            //Mas isso provoca um erro, 
//            //já que o nível de acessibilidade do campo salario é private, por padrão.
//            Console.ReadKey();

//            //Rodando a aplicação...

//            //Agora, digamos que você tenha um código
//            //que mude o salário do funcionário para um valor negativo:
//            //funcionario.salario = -1200;
//            //Console.WriteLine(funcionario.salario);

//            //Rodando a aplicação, temos...

//            //Note que a classe Funcionario aceitou um salário negativo.
//            //Mas isso nunca poderia ocorrer no mundo real.
//            //O que precisamos fazer é proteger o campo salario, 
//            //para que ele não seja alterado para valores inválidos, 
//            //como números negativos. 
//            //Uma das maneiras de se fazer isso
//            //é utilizando propriedades.

//            //E então repetimos o código anterior, só que mudando o acesso ao campo pelo 
//            //acesso ao nome da propriedade (com inicial em maiúscula):
//            funcionario.Salario = -1200;
//            Console.WriteLine(funcionario.Salario);

//            //Executando o programa...

//            //Com isso, o acesso ao campo fica proibido de fora da classe Funcionario.
//            //Temos então que comentar as linhas anteriores:

//            //Note que fizemos tudo isso para proteger o campo salario contra acesso externo.
//            //Esse tipo de proteção é chamado de ENCAPSULAMENTO.
//        }
//    }

//    //Você está desenvolvendo uma aplicação de um departamento de recursos humanos.

//    //Vamos começar com a criação de uma classe para representar funcionários de uma empresa

//    class Funcionario
//    {
//        //Ainda falta um passo para completarmos o uso correto da propriedade: 
//        //como trocamos o acesso ao campo pelo acesso à propriedade,
//        //vamos deixar o campo privado, “escondendo” ele.
//        //Além disso, adicionamos o modificador readonly, indicando
//        //que ela só pode ser alterada dentro de um construtor:
//        public readonly decimal salario;
//        //Primeiro, declaramos uma nova propriedade, digitando o tipo de retorno decimal,
//        //seguido pelo nome da propriedade, Salario, e seguido por um par 
//        //de chaves, de abertura e fechamento:

//        public decimal Salario
//        {
//            //Dentro das chaves, adicionamos um trecho de código responsável
//            //por retornar o valor do campo salario
//            //Esse trecho começa com a palavra get
//            //e é seguido por outro par de chaves:
//            get
//            {
//                //Dentro das chaves do get, criamos
//                //a instrução de retorno:  return salario;
//                return salario;
//            }
//            //Depois do trecho com get, vamos adicionar outra parte da declaração da propriedade,
//            //começando com a palavra set:
//            set
//            {
//                //E dentro das chaves do set, adicionamos o código responsável por modificar o valor do 
//                //campo salario:
//                salario = value;
//            }
//        }
//    }
//}
