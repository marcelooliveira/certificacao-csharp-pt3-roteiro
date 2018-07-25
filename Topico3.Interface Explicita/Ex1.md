# Implementando interfaces explicitament


Você está desenvolvendo um aplicativo que pode ler tanto informações mantidas em arquivos quanto
em banco de dados. Esse aplicativo inclui o seguinte segmento de código:

```
interface IArquivo
{
    void Abrir();
}

interface IConexaoBancoDeDados
{
    void Abrir();
}
```

Você precisa implementar o método `Abrir()` de cada interface numa classe derivada chamada `Recursos`, e chamar o método `Abrir()` de cada uma das duas interfaces.

Quais dois segmentos de código você deve usar? (Cada resposta correta representa parte da solução. Escolha duas.)

```
class Recursos : IArquivo, IConexaoBancoDeDados
{
    void IArquivo.Abrir()
    {
        ...
    }
    void IConexaoBancoDeDados.Abrir()
    {
        ...
    }
}

```



```
var manager = new Recursos();
manager.Abrir();
```



```
var manager = new Recursos();
((IArquivo)manager).Abrir();
((IConexaoBancoDeDados)manager).Abrir();
```




```
class Recursos : IArquivo, IConexaoBancoDeDados
{
    public void IArquivo.Abrir()
    {
        ...
    }
    public void IConexaoBancoDeDados.Abrir()
    {
        ...
    }
}
```



```
var manager = new Recursos();
manager.Abrir(IArquivo);
manager.Abrir(IConexaoBancoDeDados);
```


```
var manager = new Recursos();
((IArquivo, IConexaoBancoDeDados)manager).Abrir();
```



Answer
* Option A
* Option C

Explanation:

Uma interface contém somente as assinaturas dos métodos, propriedades, eventos e indexadores.
Uma classe ou struct que implementa a interface deve implementar os membros da interface
que são especificados na definição da interface.



```
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();
        // Call the member.
        obj.SampleMethod();
    }
}
```