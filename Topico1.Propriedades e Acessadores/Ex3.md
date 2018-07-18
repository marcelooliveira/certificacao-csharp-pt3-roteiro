Observe a declaração propriedade autoimplementada abaixo:

```
public decimal Descontos { get; set; }
```

Qual dos trechos é o equivalente da propriedade autoimplementada `Descontos` acima?

A  

```
private decimal descontos;
public decimal Descontos
{
    get { return descontos; }
    set { descontos = value; }
}

```

B


```
public decimal Descontos
{
    get { return Descontos; }
    set { Descontos = value; }
}

```

C

```
public decimal descontos;
```

D

```
public decimal descontos;
private decimal descontos
{
    get { return descontos; }
    set { descontos = value; }
}

``