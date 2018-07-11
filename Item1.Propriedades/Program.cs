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
            //Propriedades (Guia de Programação em C#)

            //Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. As propriedades podem ser usadas como se fossem membros de dados públicos, mas na verdade elas são métodos realmente especiais chamados acessadores. Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos.

            //Visão geral das propriedades
            //As propriedades permitem que uma classe exponha uma forma pública de obter e definir valores, enquanto oculta o código de implementação ou de verificação.

            //Um acessador de propriedade get é usado para retornar o valor da propriedade e um acessador de propriedade set é usado para atribuir um novo valor. Esses acessadores podem ter diferentes níveis de acesso. Para obter mais informações, consulte Restringindo a acessibilidade aos acessadores.

            //A palavra-chave value é usada para definir o valor que está sendo atribuído pelo acessador set.

            //As propriedades podem ser de leitura/ gravação(elas têm um acessador get e set), somente leitura(elas têm um acessador get, mas nenhum set) ou somente gravação(elas têm um acessador set, mas nenhum get).As propriedades somente gravação são raras e são mais comumente usadas para restringir o acesso a dados confidenciais.
            //As propriedades simples que não exigem nenhum código de acessador personalizado podem ser implementadas como definições de corpo da expressão ou como propriedades autoimplementadas.

            //Propriedades com campos de suporte
            //Um padrão básico para implementar uma propriedade envolve o uso de um campo de suporte particular da propriedade para definir e recuperar o valor da propriedade.O acessador get retorna o valor do campo particular e o acessador set pode realizar alguma validação de dados antes de atribuir um valor ao campo particular.Os dois acessadores também podem realizar alguma conversão ou cálculo nos dados antes de eles serem armazenados ou retornados.
            //O exemplo a seguir ilustra esse padrão.Neste exemplo, a classe TimePeriod representa um intervalo de tempo.Internamente, a classe armazena o intervalo de tempo em segundos em um campo particular chamado seconds.Uma propriedade de leitura/ gravação chamada Hours permite que o cliente especifique o intervalo de tempo em horas.Tanto o acessador get quanto o set executam a conversão necessária entre horas e segundos.Além disso, o acessador set valida os dados e gera um ArgumentOutOfRangeException se o número de horas é inválido.

            //using System;

            //class TimePeriod
            //{
            //    private double seconds;

            //    public double Hours
            //    {
            //        get { return seconds / 3600; }
            //        set
            //        {
            //            if (value < 0 || value > 24)
            //                throw new ArgumentOutOfRangeException(
            //                        $"{nameof(value)} must be between 0 and 24.");

            //            seconds = value * 3600;
            //        }
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        TimePeriod t = new TimePeriod();
            //        // The property assignment causes the 'set' accessor to be called.
            //        t.Hours = 24;

            //        // Retrieving the property causes the 'get' accessor to be called.
            //        Console.WriteLine($"Time in hours: {t.Hours}");
            //    }
            //}
            // The example displays the following output:
            //    Time in hours: 24

            //Definições de corpo de expressão
            //Os acessadores de propriedade geralmente consistem em instruções de linha única que simplesmente atribuem ou retornam o resultado de uma expressão. Você pode implementar essas propriedades como membros aptos para expressão. As definições de corpo da expressão consistem no símbolo => seguido pela expressão à qual atribuir ou recuperar da propriedade.
            //A partir do C#6, as propriedades somente leitura podem implementar o acessador get como um membro apto para expressão. Nesse caso, nem a palavra-chave do acessador get nem a palavra-chave return é usada. O exemplo a seguir implementa a propriedade Name somente leitura como um membro apto para expressão.

            //using System;

            //public class Person
            //{
            //    private string firstName;
            //    private string lastName;

            //    public Person(string first, string last)
            //    {
            //        firstName = first;
            //        lastName = last;
            //    }

            //    public string Name => $"{firstName} {lastName}";
            //}

            //public class Example
            //{
            //    public static void Main()
            //    {
            //        var person = new Person("Isabelle", "Butts");
            //        Console.WriteLine(person.Name);
            //    }
            //}
            //// The example displays the following output:
            ////      Isabelle Butts

            //Começando com o C# 7.0, os acessadores get e set podem ser implementados como membros aptos para expressão. Nesse caso, as palavras-chave get e set devem estar presentes. O exemplo a seguir ilustra o uso de definições de corpo de expressão para ambos os acessadores. Observe que a palavra-chave return não é usada com o acessador get.

            //using System;

            //public class SaleItem
            //        {
            //            string name;
            //            decimal cost;

            //            public SaleItem(string name, decimal cost)
            //            {
            //                this.name = name;
            //                this.cost = cost;
            //            }

            //            public string Name
            //            {
            //                get => name;
            //                set => name = value;
            //            }

            //            public decimal Price
            //            {
            //                get => cost;
            //                set => cost = value;
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main(string[] args)
            //            {
            //                var item = new SaleItem("Shoes", 19.95m);
            //                Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            //            }
            //        }
            //        // The example displays output like the following:
            //        //       Shoes: sells for $19.95

            //Propriedades autoimplementadas
            //Em alguns casos, os acessadores get e set da propriedade apenas atribuem um valor ou recuperam um valor de um campo de suporte sem incluir nenhuma lógica adicional.Usando propriedades autoimplementadas, você pode simplificar o código enquanto o compilador C# fornece de forma transparente o campo de suporte para você.

            //Se uma propriedade tiver tanto um acessador get quanto um set, ambos deverão ser autoimplementados.Você define uma propriedade autoimplementada usando as palavras - chave get e set sem fornecer qualquer implementação.O exemplo a seguir repete o anterior, exceto que Name e Price são propriedades autoimplementadas. Observe que o exemplo também remove o construtor parametrizado, para que os objetos SaleItem agora sejam inicializados com uma chamada para o construtor padrão e um inicializador de objeto.

            //using System;

            //public class SaleItem
            //{
            //    public string Name
            //    { get; set; }

            //    public decimal Price
            //    { get; set; }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            //        Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            //    }
            //}
            //// The example displays output like the following:
            ////       Shoes: sells for $19.95
    }
}
}
