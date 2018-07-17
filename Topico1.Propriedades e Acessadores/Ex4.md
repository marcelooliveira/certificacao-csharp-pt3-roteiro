Observe o trecho de código abaixo, localizado no assembly Servidor.dll:

#### Código no assembly Servidor.dll
```
public class MinhaClasse
{
    public int PropriedadePublic { get; set; }
    protected int PropriedadeProtected { get; set; }
    protected internal int PropriedadeProtectedInternal { get; set; }
    private int PropriedadePrivate { get; set; }
    internal int PropriedadeInternal { get; set; }
}
```

Agora veja o código em `Cliente.dll`, que utiliza um objeto da classe `MinhaClasse`: 

#### Código no assembly Cliente.dll
```
var meuObj = new MinhaClasse();

Console.WriteLine(funcionario.PropriedadePublic);
Console.WriteLine(funcionario.PropriedadeProtected);
Console.WriteLine(funcionario.PropriedadeProtectedInternal);
Console.WriteLine(funcionario.PropriedadeInternal);
Console.WriteLine(funcionario.PropriedadePrivate);
```

Quais das linhas no código cliente geram erro de compilação?

A
```
Console.WriteLine(funcionario.PropriedadePublic);
```

B
```
Console.WriteLine(funcionario.PropriedadeProtected);
```

C
```
Console.WriteLine(funcionario.PropriedadeProtectedInternal);
```

D
```
Console.WriteLine(funcionario.PropriedadeInternal);
```

E
```
Console.WriteLine(funcionario.PropriedadePrivate);
```

