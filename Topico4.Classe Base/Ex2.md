# Quais segmentos de código você deve usar?

Você está desenvolvendo um aplicativo que inclui o seguinte segmento de código:

```
interface IHome
{
	void Start();
}

interface IOffice
{
	void Start();
}
```

Você precisa implementar ambos os métodos Start() em uma classe derivada chamada UseStart que usa o método Start() de cada interface.

Quais segmentos de código você deve usar? (Cada resposta correta apresenta parte do solução. Escolha dois.)

A.
```
var starter = new UseStart();
((IHome, IOffice)starter).Start();
```

B.
```
class UseStart
{
	public void IHome.Start()
	{
		...
	}
	
	public void IOffice.Start()
	{
		...
	}
}
```

C.
```
class UseStart : IHome, IOffice
{
	void IHome.Start()
	{
		...
	}
	
	void IOffice.Start()
	{
		...
	}
}
```

D.
```
var starter = new UseStart();
((IHome)starter).Start();
((IOffice)starter).Start();
```

E.
```
var starter = new UseStart();
starter.Start();
starter.Start();
```

F.
```
var starter = new UseStart();
starter.Start();
```
