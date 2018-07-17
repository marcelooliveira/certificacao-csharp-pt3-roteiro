# Quais interfaces você deve implementar?

Você está modificando um aplicativo existente que gerencia a folha de pagamento do funcionário.
A aplicação inclui uma classe chamada `FolhaDePagamento`. A classe `FolhaDePagamento` se conecta a uma folha de pagamento banco de dados e processa lotes de contracheques uma vez por semana.

Você precisa garantir que a classe `FolhaDePagamento`:

* suporta iteração dentro de um loop
* libera as conexões de banco de dados após o processamento em lote ser concluído

Quais são as duas interfaces que você deve implementar? (Cada resposta correta apresenta parte do solução completa. Escolha dois.)

A.
IEquatable

B.
IEnumerable

C.
IDisposable

D.
IComparable
