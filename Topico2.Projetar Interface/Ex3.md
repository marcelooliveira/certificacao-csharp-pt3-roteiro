# Qual assinatura você deve usar para cada método?

Você está desenvolvendo as seguintes classes com os nomes:

* `Classe1`
* `Classe2`
* `Classe3`

Todas as classes farão parte de um único assembly chamado `Biblioteca.dll`. `Biblioteca.dll` será usado por vários aplicativos.

Todas as classes implementarão a seguinte interface, que também faz parte de Biblioteca.dll:

```
public interface Interface1
{
void Metodo1(decimal quantia);
void Metodo2(decimal quantia);
}
```

Você precisa garantir que o método `Metodo2` para a classe `Classe3` possa ser executado somente quando instâncias da classe são acessadas através da interface `Interface1`. A solução deve assegurar que as chamadas para o método `Metodo1` possam ser feitas através da interface ou através de uma instância da classe.

Qual assinatura você deve usar para cada método? (Para responder, selecione o assinatura para cada método na área de resposta.)

A.
public void Metodo1(decimal quantia)
void Interface1.Metodo2(decimal quantia)

B.
public void Metodo1(decimal quantia)
internal void Metodo2(decimal quantia)

C.
internal void Metodo1(decimal quantia)
void Interface1.Metodo2(decimal quantia)

D.
internal void Metodo1(decimal quantia)
internal void Metodo2(decimal quantia)

E.
public void Metodo1(decimal quantia)
public void Metodo2(decimal quantia)

F.
void Interface1.Metodo1(decimal quantia)
void Interface1.Metodo2(decimal quantia)
