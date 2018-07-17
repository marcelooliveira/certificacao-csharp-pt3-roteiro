Você está desenvolvendo um aplicativo. O aplicativo inclui classes denominadas `Lobo` e
`Carnivoro` e uma interface chamada `ICarnivoro`.
A classe `Lobo` deve atender aos seguintes requisitos:
Ele deve herdar da classe `Carnivoro` ou implementar a interface `ICarnivoro`.
Ele deve ser herdado por outras classes no aplicativo.
Você precisa garantir que a classe `Lobo` atenda aos requisitos.
Quais segmentos de código você pode usar para atingir esse objetivo? (Cada resposta correta apresenta
uma solução completa. Escolha dois.)

A.
abstract class Lobo : ICarnivoro
{
	...
}

B.
sealed class Lobo : ICarnivoro
{
	...
}

C.
abstract class Lobo : Carnivoro
{
	...
}

D.
sealed class Lobo : Carnivoro
{
	...
}

* Opção A
* Opção C