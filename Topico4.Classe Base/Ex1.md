# Escolha uma seqüência de linhas de código

Você está desenvolvendo um aplicativo de console C# que gera informações na tela.

Os seguinte segmentos de código implementam as duas classes responsáveis ​​por fazer chamadas para o objeto do console:

```
abstract class BaseLogger
{
	public virtual void Log(string mensagem)
	{
		Console.WriteLine("Base: " + mensagem);
	}
	
	public virtual LogCompletado()
	{
		Console.WriteLine("Completado");
	}
}

class Logger : BaseLogger
{
	public override void Log(string mensagem)
	{
		Console.WriteLine(mensagem);
	}
	
	public new void LogCompletado()
	{
		Console.WriteLine("Terminado");
	}
}
```

Quando o aplicativo é executado, a saída do console deve ser o seguinte texto:

```
Log iniciado
Base: Log sendo processado
Terminado
```

Você precisa garantir que o aplicativo produza o texto correto.
Quais quatro linhas de código você deve usar em seqüência? (Para responder, mova o
classes da lista de classes para a área de resposta e organizá-las na ordem correta.)

```
1. logger.Log("Base: Log sendo processado");
2. ((BaseLogger)logger).Log("Log sendo processado");
3. var logger = new BaseLogger();
4. ((Logger)logger).LogCompletado();
5. logger.Log("Log iniciado");
6. BaseLogger logger = new Logger();
7. logger.LogCompletado();
```

Resposta:

```
6. BaseLogger logger = new Logger();
5. logger.Log("Log iniciado");
1. logger.Log("Base: Log sendo processado");
7. logger.LogCompletado();
```
