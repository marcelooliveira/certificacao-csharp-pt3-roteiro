Você está criando uma classe chamada `Funcionario`.

A classe expõe uma propriedade de string chamada `TipoFuncionario`.
O segmento de código a seguir define a classe `Funcionario`
(Os números das linhas são incluído apenas para referência.)

```
01 public class Funcionario
02 {
03 	internal string TipoFuncionario
04 	{
05		get;
06 		set;
07 	}
08 }
```

O valor da propriedade `TipoFuncionario` deve ser acessado e modificado apenas pelo código dentro da
classe `Funcionario` ou dentro de uma classe derivada da classe `Funcionario`.
Você precisa garantir que a implementação da propriedade `TipoFuncionario` atenda
os requisitos.

Quais ações você deve executar? (Cada resposta correta representa parte do solução completa. Escolha duas.)


Substitua a linha 05 pelo seguinte segmento de código:
protected get;

B.
Substitua a linha 06 pelo seguinte segmento de código:
private set;

C.
Substitua a linha 03 pelo seguinte segmento de código:
public string TipoFuncionario

D.
Substitua a linha 05 pelo seguinte segmento de código:
private get;

E.
Substitua a linha 03 pelo seguinte segmento de código:
protected string TipoFuncionario

F.
Substitua a linha 06 pelo seguinte segmento de código:
protected set;